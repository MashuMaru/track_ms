using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tracker.Domain.DTOs;
using Tracker.Domain.Services;

namespace Tracker.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [AllowAnonymous]
    [HttpPost("create")]
    public async Task<IActionResult> CreateUserAsync([FromBody] UserDto userModel)
    {
        throw new Exception("yooo, bad request.");
        var response = await _userService.CreateUserAsync(userModel);

        if (!response.IsSuccessful)
            return BadRequest(response.Message);

        return Ok(response.Message);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetUserByIdAsync(int id)
    {
        throw new BadHttpRequestException("this is an error validation.");
        var response = await _userService.GetUserByIdAsync(id);

        if (!response.IsSuccessful)
            return BadRequest(response.Message);

        return Ok(response.Data);
    }
}
