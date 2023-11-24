
using BookStoreServer.WebApi.Context;
using BookStoreServer.WebApi.Dtos;
using BookStoreServer.WebApi.Models;
using GSF.FuzzyStrings;
using Microsoft.AspNetCore.Mvc;
using static BookStoreServer.WebApi.Controllers.BooksController;

namespace BookStoreServer.WebApi.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public sealed class CategoriesController : ControllerBase
{

    [HttpPost]
    public IActionResult Create(CreateCategoryDto request)
    {
        AppDbContext context = new();
        var checkNameIsUnique = context.Categories.Any(p => p.Name == request.Name);

        if (checkNameIsUnique)
        {
            return BadRequest("Kategori adı daha önce kullanılmıştır.");
        }


        Category category = new()
        {
            Name = request.Name,
            IsActive = true,
            IsDeleted = false
        };

        context.Categories.Add(category);
        context.SaveChanges();
        return NoContent();
    }


    [HttpGet("{id}")]
    public IActionResult RemoveById(int id)
    {


        AppDbContext Context = new AppDbContext();
        Category category = Context.Categories.Find(id);

        if (category == null)
        {
            return NotFound();
        }


        category.IsDeleted = true;
        category.IsActive = false;
        Context.SaveChanges();
        return NoContent();


    }

    [HttpPost]
    public IActionResult Update(UpdateCategoryDto request)
    {
        AppDbContext context = new();
        Category category = context.Categories.Find(request.Id);
        if (category == null)
        {
            return NotFound();
        }
        category.Name = request.Name;
        context.SaveChanges();
        return NoContent();



    }


    [HttpGet]
    public IActionResult GetAll()
    {
        AppDbContext context = new();

        var categories = context.Categories
            .Where(p => p.IsActive == true && p.IsDeleted == false)
            .OrderBy(p => p.Name)
            .ToList();
        return Ok(categories);
    }
}
