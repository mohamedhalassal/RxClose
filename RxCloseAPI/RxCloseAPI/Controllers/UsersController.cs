 
namespace RxCloseAPI.Controllers;


[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly List<User> _user = [];

    [HttpGet("GetAll")]
    public IActionResult GetAll()
    {
        return Ok(_user);
    }
}
