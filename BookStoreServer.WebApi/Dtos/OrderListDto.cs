using BookStoreServer.WebApi.Models;
using BookStoreServer.WebApi.ValueObjects;

namespace BookStoreServer.WebApi.Dtos;

public sealed record OrderListDto(
    int Id,
    string OrderNumber,
    Book Book,
    int Quantity,
    Money Price,
    DateTime CreatedAt,
    DateTime PaymentDate,
    string PaymentType,
    string PaymentNumber,
    List<OrderStatus> orderStatuses,
    string Comment=null,
    short? Raiting=null
    );