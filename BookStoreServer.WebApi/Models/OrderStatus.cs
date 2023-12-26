

namespace BookStoreServer.WebApi.Models;

public sealed class OrderStatus
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public OrderStatusEnum Status { get; set; }
    public DateTime StatusDate { get; set; }
}