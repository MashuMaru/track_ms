using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tracker.Domain.DTOs;
using Tracker.Domain.Services;
using Tracker.Domain.Validators;

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
    [HttpPost]
    public async Task<IActionResult> CreateUserAsync([FromBody] UserDto userModel)
    {
        var request = await new UserValidator().ValidateAsync(userModel);

        if (!request.IsValid)
            throw new BadHttpRequestException(request.Errors.First().ToString());
        
        var response = await _userService.CreateUserAsync(userModel);
        
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
