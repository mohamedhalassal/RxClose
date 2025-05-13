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
    public IActionResult Get([FromRoute]int id)
    {
        var user = _userService.Get(id);

        return user is null ? NotFound() : Ok(user);
    }

    [HttpPost("")]
    public IActionResult Add([FromBody] User request)
    {
        var newUser = _userService.Add(request);

        return CreatedAtAction(nameof(Get), new { id = newUser.Id }, newUser);
    }

    [HttpPut("{id}")]

    public IActionResult Update([FromRoute] int id, [FromBody] User request)
    {
        var isUpdated = _userService.Update(id, request);

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
