using Authentication.Service.Components.User.Token;
using Microsoft.AspNetCore.Mvc;

namespace Authentication.Project.Controllers.User;

[ApiController]
[Route("login")]
public class LoginController(ITokenService tokenService) : ControllerBase
{

    [HttpPost("users")]
    public IActionResult LoginUser([FromBody] LoginRequest loginRequest)
    {
        var response = tokenService.GenerateToken(loginRequest.UserName, "User");
        return Ok(new { token = response });
    }

    public class LoginRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
