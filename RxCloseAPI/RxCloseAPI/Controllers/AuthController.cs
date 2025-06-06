using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace RxCloseAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController(IAuthService authService) : ControllerBase
    {
        private readonly IAuthService _authService = authService;

        [HttpPost("")]
        public async Task<IActionResult> LoginAsync(LoginRequest request,CancellationToken cancellationToken)
        {
          var authResult = await _authService.GetTokenAsync(request.Email, request.Password);
            return authResult is null ? BadRequest("Invalid email or Password") : Ok(authResult);
        }
        
    }
}
