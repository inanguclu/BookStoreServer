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
using Microsoft.EntityFrameworkCore;

namespace BookStoreServer.WebApi.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]


public sealed class ShoppingCartsController : ControllerBase
{
    private readonly AppDbContext _context;

    public ShoppingCartsController(AppDbContext context)
    {
        _context = context;
    }

    //dil destegi için hata mesajlarını ayarlayacagız

    [HttpGet("{bookId}/{quantity}")]
    public IActionResult CheckBookQuantityIsAvailable(int bookId,int quantity)
    {
        Book book = _context.Books.Find(bookId);
        if (book.Quantity < quantity)
        {
            throw new Exception("Stokta bu kadar adet kitap yok!");
        }


        return NoContent();
    }

    [HttpGet("{bookId}/{quantity}")]
    public IActionResult ChangeBookQuantityInShoppingCart(int bookId,int quantity )
    {
        ShoppingCart cart = _context.ShoppingCarts.Where(p => p.BookId == bookId).FirstOrDefault();

        if (cart is null)
        {
            throw new Exception("Kitap sepette bulunamadı");

        }

        Book book = _context.Books.Find(bookId);


        if (quantity <= 0)
        {
            book.Quantity += 1;
            _context.Remove(cart);
            _context.Update(book);
        }
        else
        {
            cart.Quantity = quantity;


            if (book.Quantity < cart.Quantity)
            {
                throw new Exception("Stokta bu kadar adet kitap yok!");
            }
            _context.Update(cart);
        }

        _context.SaveChanges();
        return NoContent();
    }

    [HttpPost]
    public IActionResult Add(AddShoppingCartDto request)
    {

        Book book = _context.Books.Find(request.BookId);

        if (book is null)
        {
            throw new Exception("Kitap bulunamadı!");
        }

        if (book.Quantity < request.Quantity)
        {
            throw new Exception("Kitap stokta kalmadı!");
        }

        ShoppingCart cart =
            _context.ShoppingCarts
            .Where(p => p.BookId == request.BookId)
            .FirstOrDefault();

        if (cart is not null)
        {
            cart.Quantity += 1;

            _context.Update(cart);
        }
        else
        {
            cart = new()
            {
                BookId = request.BookId,
                Price = request.Price,
                Quantity = 1,
                UserId = request.UserId,
            };

            _context.Add(cart);

        }

        _context.SaveChanges();
        return NoContent();

    }



    [HttpGet("{id}")]
    public IActionResult RemoveById(int id)
    {
        var shoppingCart = _context.ShoppingCarts.Where(p => p.Id == id).FirstOrDefault();
        if (shoppingCart != null)
        {
            _context.Remove(shoppingCart);
            _context.SaveChanges();
        }

        return NoContent();
    }



    [HttpGet("{userId}")]
    public IActionResult GetAll(int userId)
    {
        List<ShoppingCartResponseDto> books = _context.ShoppingCarts.AsNoTracking().Include(p => p.Book).Select(s => new ShoppingCartResponseDto()
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
        _context.AddRange(shoppingCarts);
        _context.SaveChanges();
        return NoContent();
    }


    [HttpPost]
    public async Task<IActionResult> Payment(PaymentDto requestDto)
    {

        foreach (var item in requestDto.Books)
        {
            Book checkBook = _context.Books.Find(item.Id);
            if (checkBook.Quantity < item.Quantity)
            {
                throw new Exception($"{item.Title}Kitap stokta kalmadı!");
            }
        }

        decimal total = 0;
        decimal commission = 0;
        foreach (var book in requestDto.Books)
        {
            total += book.Price.Value;
        }
        commission = total;



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


        //burda hata var bakılacak
        //if (payment.Status == "success")
        //{
            try
            {

                string orderNumber = Order.GetNewOrderNumber();

                List<Order> orders = new();
                foreach (var book in requestDto.Books)
                {
                    Book changeBookQuantity = _context.Books.Find(book.Id);
                    changeBookQuantity.Quantity-=book.Quantity;
                    _context.Update(changeBookQuantity);
                    Order order = new()
                    {
                        OrderNumber = orderNumber,
                        BookId = book.Id,
                        Quantity = book.Quantity,
                        Price = new Money(book.Price.Value, book.Price.Currency),
                        PaymentDate = DateTime.UtcNow.AddHours(3),
                        PaymentType = "Credit Cart",
                        PaymentNumber = payment.PaymentId,
                        CreatedAt = DateTime.UtcNow.AddHours(3),
                        UserId=requestDto.UserId
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
                refundRequest.Locale = Locale.TR.ToString();
                refundRequest.PaymentTransactionId = "1";
                refundRequest.Price = request.Price;
                refundRequest.Ip = "85.34.78.112";
                refundRequest.Currency = currency.ToString();


                Refund refund = Refund.Create(refundRequest, options);

                return BadRequest(new { Message = "işlem sırasında bir hata aldık ve paranızı iade ettik lütfen daha sonra tekrar deneyiniz yada müsteri temsilcisi ile iletişime geçiniz!" });
            }



            return NoContent();
        //}
        //else
        //{
        //    return BadRequest(payment.ErrorMessage);
        //}
    }
}

