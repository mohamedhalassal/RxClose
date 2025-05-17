using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace RxCloseAPI.Controllers;


[Route("api/[controller]")]
[ApiController]
public class UsersController(IUserService userService) : ControllerBase
{
    private readonly IUserService _userService = userService;
     
    [HttpGet("")]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var users =await _userService.GetAllAsync(cancellationToken);

        var response = users.Adapt<IEnumerable<UserResponse>>();

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get([FromRoute] int id, CancellationToken cancellationToken)
    {
        var user =await _userService.GetAsync(id, cancellationToken);

        if (user is null)
            return NotFound();

        var response = user.Adapt<UserResponse>();

        return Ok(response);
    }

    [HttpPost("")]
    public async Task<IActionResult> Add([FromBody] UserRequest request,
        CancellationToken cancellationToken)
    {
        var newUser =await _userService.AddAsync(request.Adapt<User>(), cancellationToken);

        return CreatedAtAction(nameof(Get), new { id = newUser.Id }, newUser);
    }

    [HttpPut("{id}")]

    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UserRequest request
        , CancellationToken cancellationToken)
    {
        var isUpdated = await _userService.UpdateAsync(id, request.Adapt<User>(), cancellationToken);

        if (!isUpdated)
            return NotFound();

        return NoContent(); 
    }

    [HttpDelete("{id}")]

    public async Task<IActionResult> Delete([FromRoute] int id, CancellationToken cancellationToken)
    {
        var isDeleted =await _userService.DeleteAsync(id, cancellationToken);

        if (!isDeleted)
            return NotFound();

        return NoContent();
    }
}
