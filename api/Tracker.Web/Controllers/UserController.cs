using Microsoft.AspNetCore.Mvc;
using Tracker.Domain.DTOs;
using Tracker.Domain.Services;

namespace Tracker.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreateUserAsync([FromBody] UserDto userModel)
    {
        var response = await _userService.CreateUserAsync(userModel);

        if (!response.IsSuccessful)
            return BadRequest(response.Message);

        return Ok(response.Message);
    }

    [HttpPost("{id:int}")]
    public async Task<IActionResult> GetUserByIdAsync(int id)
    {
        var response = await _userService.GetUserByIdAsync(id);

        if (!response.IsSuccessful)
            return BadRequest(response.Message);

        return Ok(response.Data);
    }
}
