using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace RxCloseAPI.Controllers;


[Route("api/[controller]")]
[ApiController]
public class UsersController(IUserService userService) : ControllerBase
{
    private readonly IUserService _userService = userService;

    [HttpGet("")]
    public IActionResult GetAll()
    {
        var users = _userService.GetAll();

        var response = users.Adapt<IEnumerable<UserResponse>>();

        return Ok(response);
    }

    [HttpGet("{id}")]
    public IActionResult Get([FromRoute]int id)
    {
        var user = _userService.Get(id);

        if (user is null)
            return NotFound();

        var response = user.Adapt<UserResponse>();

        return Ok(response);
    }

    [HttpPost("")]
    public IActionResult Add([FromBody] CreatUserRequest request)
    {
        var newUser = _userService.Add(request.Adapt<User>());

        return CreatedAtAction(nameof(Get), new { id = newUser.Id }, newUser);
    }

    [HttpPut("{id}")]

    public IActionResult Update([FromRoute] int id, [FromBody] CreatUserRequest request)
    {
        var isUpdated = _userService.Update(id,request.Adapt<User>());

        if (!isUpdated)
            return NotFound();

        return NoContent();
    }

    [HttpDelete("{id}")]

    public IActionResult Delete([FromRoute] int id)
    {
        var isDeleted = _userService.Delete(id);

        if (!isDeleted)
            return NotFound();

        return NoContent();
    }
}
