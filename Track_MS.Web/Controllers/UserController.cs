using Microsoft.AspNetCore.Mvc;
using Track_MS.Services.Services;

namespace Track_MS.Web.Controllers;

[ApiController]
[Route("user")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;
    private readonly IUserService _userService;

    public UserController(ILogger<UserController> logger, IUserService userService)
    {
        _logger = logger;
        _userService = userService;
    }

    [HttpGet("identifier")]
    public async Task<ActionResult<string>> GenerateIdentifierAsync()
    {
        return Ok(await _userService.GenerateIdentifierAsync());
    }
}
