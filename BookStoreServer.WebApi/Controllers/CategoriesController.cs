
using GSF.FuzzyStrings;
using Microsoft.AspNetCore.Mvc;
using static BookStoreServer.WebApi.Controllers.BooksController;

namespace BookStoreServer.WebApi.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
       
        var categories= SeedData.Categories;
        return Ok(SeedData.Categories);
    }
}
