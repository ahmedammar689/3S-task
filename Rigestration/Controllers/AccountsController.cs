using Application1.Dtos;
using Domain1.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Rigestration.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AccountsController : ControllerBase
{
    private readonly UserManager<AppUser> _userManager;
    public AccountsController(UserManager<AppUser> userManager )
    {
        _userManager = userManager;
        
    }

    [HttpPost("Register")]
    public async Task<ActionResult<UserDto>> Register(RegisterDto model)
    {
    

        var user = new AppUser
        {
           FirstName = model.FirstName,
           MiddleName = model.MiddleName,
           LastName = model.LastName,
           BirthDate = model.BirthDate,
           MobileNumber = model.MobileNumber,

            Email = model.Email,
            UserName = model.Email.Split('@')[0],
          

        };

        var result = await _userManager.CreateAsync(user, model.Password);
        if (!result.Succeeded) return BadRequest(result.Errors);

        

        var userDto = new UserDto
        {
            FirstName = user.FirstName,
            MiddleName = user.MiddleName,
            LastName = user.LastName,
            Email = user.Email,
      
            Token = "This will be a token"
        };

        return Ok(userDto);

    }




}
