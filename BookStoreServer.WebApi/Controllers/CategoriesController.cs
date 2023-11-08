
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
        string searchTerm = "hallılar";
        var categories= SeedData.Categories;
        var closeMatches=categories.Where(c=>c.Name.ApproximatelyEquals(searchTerm,
            FuzzyStringComparisonOptions.UseJaccardDistance,FuzzyStringComparisonTolerance.Normal)).ToList();   
        
        return Ok(SeedData.Categories);
    }
}
