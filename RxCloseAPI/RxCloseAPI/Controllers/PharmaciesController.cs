using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using RxCloseAPI.Conntracts.Pharmacies;

namespace RxCloseAPI.Controllers;


[Route("api/[controller]")]
[ApiController]
public class PharmaciesController(IPharmecyService userService) : ControllerBase
{
    private readonly IPharmecyService _userService = userService;
     
    [HttpGet("")]
    [Authorize]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var users =await _userService.GetAllAsync(cancellationToken);

        var response = users.Adapt<IEnumerable<PharmacyResponse>>();

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get([FromRoute] int id, CancellationToken cancellationToken)
    {
        var user =await _userService.GetAsync(id, cancellationToken);

        if (user is null)
            return NotFound();

        var response = user.Adapt<PharmacyResponse>();

        return Ok(response);
    }

    [HttpPost("")]
    public async Task<IActionResult> Add([FromBody] PharmacyRequest request,
        CancellationToken cancellationToken)
    {
        var newUser =await _userService.AddAsync(request.Adapt<Pharmecy>(), cancellationToken);

        return CreatedAtAction(nameof(Get), new { id = newUser.Id }, newUser);
    }

    [HttpPut("{id}")]

    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] PharmacyRequest request
        , CancellationToken cancellationToken)
    {
        var isUpdated = await _userService.UpdateAsync(id, request.Adapt<Pharmecy>(), cancellationToken);

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
