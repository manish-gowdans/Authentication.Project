using Authentication.Service.Components.User.Register;
using Microsoft.AspNetCore.Mvc;

namespace Authentication.Project.Controllers.User.Register;

[ApiController]
[Route("register")]
public class RegisterController(IRegisterService registerService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> RegisterUser([FromBody] RegisterRequest request)
    {
        await registerService.RegisterUsers(request.UserName, request.Password);
        return Ok();
    }

    public class RegisterRequest
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int PhoneNumber { get; set; }
    }
}
