using BookStoreServer.WebApi.Context;
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

namespace BookStoreServer.WebApi.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public sealed class ShoppingCartsController : ControllerBase
{
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

            string orderNumber = Order.GetNewOrderNumber();

            List<Order> orders = new();
            foreach (var book in requestDto.Books)
            {
                Order order = new()
                {
                    OrderNumber = orderNumber,
                    BookId = book.Id,
                    Price = new Money(book.Price.Value, book.Price.Currency),
                    PaymentDate = DateTime.Now,
                    PaymentType = "Credit Cart",
                    PaymentNumber = payment.PaymentId,
                    CreatedAt = DateTime.Now
                };
                orders.Add(order);
            }

            AppDbContext context = new();


            OrderStatus orderStatus = new()
            {
                OrderNumber = orderNumber,
                Status = OrderStatusEnum.AwaitingApproval,
                StatusDate = DateTime.Now,
            };
            
            context.OrderStatuses.Add(orderStatus);
            context.Orders.AddRange(orders);
            context.SaveChanges();



            string response = await MailService.SendEmailAsync(requestDto.Buyer.Email, "Siparişiniz Alındı", $@"

                <h1>Siparişiniz Alındı</h1>
                <p>Sipariş numaranız: {orderNumber}</p>
                <p>Ödeme numaranız: {payment.PaymentId}</p>
                <p>Ödeme tutarınız: {payment.PaidPrice}</p>
                <p>Ödeme tarihiniz: {DateTime.Now}</p>
                <p>Ödeme tipiniz: Kredi Kartı</p>
                <p>Ödeme durumunuz: Onay Bekliyor</p>");

            return NoContent();
        }
        else
        {
            return BadRequest(payment.ErrorMessage);
        }
    }
}

