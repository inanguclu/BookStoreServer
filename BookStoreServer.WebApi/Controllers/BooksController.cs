using BookStoreServer.WebApi.Dtos;
using BookStoreServer.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreServer.WebApi.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class BooksController : ControllerBase
{
    private static List<Book> books = new();
   
    public BooksController()
    {
        books=new();
        for (int i = 0; i < 100; i++)
        {
            var book = new Book()
            {
                Id = i + 1,
                Title = "kitap " + (i + 1),
                Author = "yazar " + (i + 1),
                Summary = "",
                CoverImageUrl = "https://m.media-amazon.com/images/I/71Qde+ZerdL._AC_UF1000,1000_QL80_.jpg",
                IsActive = true,
                ISBN = "9642225522455",
                Price = 5 * (i + 1),
                Quantity = i + 1
            };
            books.Add(book);
        }
    }

    [HttpGet("{pageNumber}/{pageSize}")]
    public IActionResult GetAll(int pageNumber, int pageSize)
    {
        ResponseDto<List<Book>> response = new();
        response.Data = books
            .Skip((pageNumber-1)*pageSize)
            .Take(pageSize)
            .ToList();  
        response.PageNumber = pageNumber;
        response.PageSize = pageSize;
        response.TotalPageCount=(int)Math.Ceiling(books.Count/(double)pageSize);
        response.IsFirstPage=pageNumber==1;
        response.IsLastPage=pageNumber==response.TotalPageCount;
        
        return Ok(response);
    }
}
