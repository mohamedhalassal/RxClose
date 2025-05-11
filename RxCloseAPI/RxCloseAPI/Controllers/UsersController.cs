
namespace RxCloseAPI.Controllers;


[Route("api/[controller]")]
[ApiController]
public class UsersController(IUserService userService) : ControllerBase
{
    private readonly IUserService _userService = userService;

    [HttpGet("")]
    public IActionResult GetAll()
    {
        return Ok(_userService.GetAll());
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var user = _userService.Get(id);

        return user is null ? NotFound() : Ok(user);
    }
}
