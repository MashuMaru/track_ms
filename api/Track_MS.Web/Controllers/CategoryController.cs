using Microsoft.AspNetCore.Mvc;
using Track_MS.Services.Services;

namespace Track_MS.Web.Controllers;

[ApiController]
[Route("category")]
public class CategoryController : ControllerBase
{
    private readonly ILogger<CategoryController> _logger;
    private readonly ICategoryService _categoryService;

    public CategoryController(ILogger<CategoryController> logger, ICategoryService categoryService)
    {
        _logger = logger;
        _categoryService = categoryService;
    }

    [HttpGet("identifier")]
    public async Task<ActionResult<string>> CreateNewCategoryAsync()
    {
        var response = await _categoryService.GenerateIdentifierAsync();

        if (!response.IsSuccessful)
            return BadRequest(response.Message);

        return Ok(response.Data);
    }
}
