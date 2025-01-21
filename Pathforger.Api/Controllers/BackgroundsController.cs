using Microsoft.AspNetCore.Mvc;
using PathforgerApi.Dtos.Backgrounds;
using PathforgerApi.Services;

namespace PathforgerApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BackgroundsController : ControllerBase
{
    private readonly IBackgroundService _backgroundService;

    public BackgroundsController(IBackgroundService backgroundService)
    {
        _backgroundService = backgroundService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<BackgroundDto>>> GetAll()
    {
        var result = await _backgroundService.GetAllBackgroundsAsync();
        return Ok(result); // Possibly some transformation or direct
    }
}