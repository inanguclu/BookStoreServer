﻿using BookStoreServer.WebApi.Context;
using BookStoreServer.WebApi.Dtos;
using BookStoreServer.WebApi.Enums;
using BookStoreServer.WebApi.Models;
using BookStoreServer.WebApi.Services;
using BookStoreServer.WebApi.ValueObjects;
using Iyzipay;
using Iyzipay.Model;
using Iyzipay.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStoreServer.WebApi.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]


public sealed class ShoppingCartsController : ControllerBase
{
    [HttpPost]
    public IActionResult Add(AddShoppingCartDto request)
    {
        AppDbContext context = new();
        ShoppingCart cart = new()
        {
            BookId = request.BookId,
            Price = request.Price,
            Quantity = 1,
            UserId = request.UserId,
        };
        context.Add(cart);
        context.SaveChanges();
        return NoContent();

    }



    [HttpGet("{id}")]
    public IActionResult RemoveById(int id)
    {
        AppDbContext context = new();
        var shoppingCart = context.ShoppingCarts.Where(p => p.Id == id).FirstOrDefault();
        if (shoppingCart != null)
        {
            context.Remove(shoppingCart);
            context.SaveChanges();
        }

        return NoContent();
    }



    [HttpGet("{userId}")]
    public IActionResult GetAll(int userId)
    {
        AppDbContext context = new();
        List<ShoppingCartResponseDto> books = context.ShoppingCarts.AsNoTracking().Include(p => p.Book).Select(s => new ShoppingCartResponseDto()
        {
            Author = s.Book.Author,
            CoverImageUrl = s.Book.CoverImageUrl,
            CreateAt = s.Book.CreateAt,
            Id = s.Book.Id,
            IsActive = s.Book.IsActive,
            ISBN = s.Book.ISBN,
            IsDeleted = s.Book.IsDeleted,
            Price = s.Price,
            Quantity = s.Quantity,
            Summary = s.Book.Summary,
            Title = s.Book.Title,
            ShoppingCartId = s.Id

        }).ToList();
        return Ok(books);
    }


    [HttpPost]
    public IActionResult SetShoppingCartsFromLocalStorage(List<SetShoppingCartsDto> request)
    {
        AppDbContext context = new();
        List<ShoppingCart> shoppingCarts = new();
        foreach (var item in request)
        {
            ShoppingCart shoppingCart = new()
            {
                BookId = item.BookId,
                UserId = item.UserId,
                Price = item.Price,
                Quantity = item.Quantity
            };
            shoppingCarts.Add(shoppingCart);

        }
        context.AddRange(shoppingCarts);
        context.SaveChanges();
        return NoContent();
    }


    [HttpPost]
    public async Task<IActionResult> Payment(PaymentDto requestDto)
    {//buraya mı gelmesi laızm ödemenin evet hocam gelmiyor :)
        decimal total = 0;
        decimal commission = 0;//komisyon
        foreach (var book in requestDto.Books)
        {
            total += book.Price.Value;
        }
        commission = total;
        // commission = total * 1.2m / 100;

        Currency currency = Currency.TRY;
        string requestCurrency = requestDto.Books[0]?.Price?.Currency;
        if (!string.IsNullOrEmpty(requestCurrency))
        {
            switch (requestCurrency)
            {
                case "₺":
                    currency = Currency.TRY; break;
                case "$":
                    currency = Currency.USD; break;
                case "£":
                    currency = Currency.GBP; break;
                case "€":
                    currency = Currency.EUR; break;
                default:
                    throw new Exception("Para birimi bulunamadı");
                    break;

            }
        }
        else
        {
            throw new Exception("Sepette ürününüz yok!");
        }

        Iyzipay.Options options = new Iyzipay.Options();
        options.ApiKey = "sandbox-ynaf4mn2PtmVxCCIoWFzDU4yQVZZVVkN";
        options.SecretKey = "sandbox-cnwAy4gu5vv5xi7gJEVcdmwouuA2LLgK";
        options.BaseUrl = "https://sandbox-api.iyzipay.com";

        CreatePaymentRequest request = new CreatePaymentRequest();
        request.Locale = Locale.TR.ToString();
        request.ConversationId = Guid.NewGuid().ToString();
        request.Price = total.ToString();//ödeme kısmı
        request.PaidPrice = commission.ToString();//komisyonlu odeme kısmı
        request.Currency = currency.ToString();
        request.Installment = 1;
        request.BasketId = Order.GetNewOrderNumber();
        request.PaymentChannel = PaymentChannel.WEB.ToString();
        request.PaymentGroup = PaymentGroup.PRODUCT.ToString();

        PaymentCard paymentCard = requestDto.PaymentCard;
        request.PaymentCard = paymentCard;

        Buyer buyer = requestDto.Buyer;
        buyer.Id = Guid.NewGuid().ToString();
        request.Buyer = buyer;

        request.ShippingAddress = requestDto.ShippingAddress;
        request.BillingAddress = requestDto.BillingAddress;


        List<BasketItem> basketItems = new List<BasketItem>();
        foreach (var book in requestDto.Books)
        {
            BasketItem item = new BasketItem();
            item.Category1 = "Book";
            item.Category2 = "Book";
            item.Id = book.Id.ToString();
            item.Name = book.Title;
            item.ItemType = BasketItemType.PHYSICAL.ToString();
            item.Price = book.Price.Value.ToString();
            basketItems.Add(item);
        }

        request.BasketItems = basketItems;

        Payment payment = Iyzipay.Model.Payment.Create(request, options);

        if (payment.Status == "success")
        {
            try
            {

                string orderNumber = Order.GetNewOrderNumber();

                List<Order> orders = new();
                foreach (var book in requestDto.Books)
                {
                    Order order = new()
                    {
                        OrderNumber = orderNumber,
                        BookId = book.Id,
                        Price = new Money(book.Price.Value, book.Price.Currency),
                        PaymentDate = DateTime.UtcNow.AddHours(3),
                        PaymentType = "Credit Cart",
                        PaymentNumber = payment.PaymentId,
                        CreatedAt = DateTime.UtcNow.AddHours(3)
                    };
                    orders.Add(order);
                }

                AppDbContext context = new();


                OrderStatus orderStatus = new()
                {
                    OrderNumber = orderNumber,
                    Status = OrderStatusEnum.AwaitingApproval,
                    StatusDate = DateTime.UtcNow.AddHours(3),
                };

                context.Orders.AddRange(orders);
                context.OrderStatuses.Add(orderStatus);


                //eger kullanıcı girişi yapıldıysa bu işlemi yap
                Models.User user = context.Users.Find(requestDto.UserId);

                if (user is not null)
                {
                    var shoppingCarts = context.ShoppingCarts.Where(p => p.UserId == requestDto.UserId).ToList();
                    context.RemoveRange(shoppingCarts);
                }




                context.SaveChanges();



                string response = await MailService.SendEmailAsync(requestDto.Buyer.Email, "Siparişiniz Alındı", $@"

                <h1>Siparişiniz Alındı</h1>
                <p>Sipariş numaranız: {orderNumber}</p>
                <p>Ödeme numaranız: {payment.PaymentId}</p>
                <p>Ödeme tutarınız: {payment.PaidPrice}</p>
                <p>Ödeme tarihiniz: {DateTime.UtcNow.AddHours(3)}</p>
                <p>Ödeme tipiniz: Kredi Kartı</p>
                <p>Ödeme durumunuz: Onay Bekliyor</p>");

            }
            catch (Exception ex)
            {
                //ödeme kırılım ayarı yapmamız lazım ki iyzico ödeme iadesi yapabilsin
                CreateRefundRequest refundRequest = new CreateRefundRequest();
                refundRequest.ConversationId = request.ConversationId;
                refundRequest.Locale=Locale.TR.ToString();
                refundRequest.PaymentTransactionId = "1";
                refundRequest.Price = request.Price;
                refundRequest.Ip = "85.34.78.112";
                refundRequest.Currency=currency.ToString();


                Refund refund = Refund.Create(refundRequest, options);

                return BadRequest(new { Message = "işlem sırasında bir hata aldık ve paranızı iade ettik lütfen daha sonra tekrar deneyiniz yada müsteri temsilcisi ile iletişime geçiniz!" });
            }



            return NoContent();
        }
        else
        {
            return BadRequest(payment.ErrorMessage);
        }
    }
}

