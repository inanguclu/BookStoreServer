using BookStoreServer.WebApi.Context;
using BookStoreServer.WebApi.Dtos;
using BookStoreServer.WebApi.Models;
using GSF.FuzzyStrings;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace BookStoreServer.WebApi.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public sealed class BooksController : ControllerBase
{

    [HttpPost]
    public IActionResult GetAll(RequestDto request)
    {
        AppDbContext context = new();

        List<Book> books = new();

        if (request.CategoryId == null)
        {
            books = context.Books
            .Where(p => p.IsActive == true && p.IsDeleted == false)
            .Where(p => p.Title.ToLower().Contains(request.Search.ToLower()) || p.ISBN.Contains(request.Search))
            .OrderByDescending(p => p.CreateAt)
            .Take(request.PageSize)
            .ToList();
        }
        else
        {
            books = context.BookCategories
                .Where(p => p.CategoryId == request.CategoryId)
                .Include(p => p.Book)
                .Select(s => s.Book)
                .Where(p => p.IsActive == true && p.IsDeleted == false)
                .Where(p => p.Title.ToLower().Contains(request.Search.ToLower()) || p.ISBN.Contains(request.Search))
                .OrderByDescending(p => p.CreateAt)
                .Take(request.PageSize)
                .ToList();

        }
        List<BookDto> requestDto = new();
        foreach (var book in books) 
        {
            var bookDto = new BookDto()
            {
                Title = book.Title,
                ISBN = book.ISBN,
                Id = book.Id,
                Author = book.Author,
                Categories =
                context.BookCategories
                .Where(p => p.BookId == book.Id)
                .Include(p => p.Category)
                .Select(s => s.Category.Name)
                .ToList(),
                CoverImageUrl = book.CoverImageUrl,
                CreateAt = book.CreateAt,
                IsActive = book.IsActive,
                IsDeleted = book.IsDeleted,
                Price = book.Price,
                Quantity = book.Quantity,
                Summary = book.Summary,
            };
            requestDto.Add(bookDto);

        }
        return Ok(requestDto);

    }




}
