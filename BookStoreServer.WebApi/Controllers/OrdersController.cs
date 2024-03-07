using BookStoreServer.WebApi.Context;
using BookStoreServer.WebApi.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreServer.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public sealed class OrdersController : ControllerBase
{
    private readonly AppDbContext _context;

    public OrdersController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("{userId}")]
    public IActionResult GetAllByUserId(string userId)
    {

        List<OrderListDto> orders = new List<OrderListDto>();   

        return NoContent();
    }
}
