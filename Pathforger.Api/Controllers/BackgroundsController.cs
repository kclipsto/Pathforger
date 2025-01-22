using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PathforgerApi.Dtos.Backgrounds;
using PathforgerDb.Services;

namespace Pathforger.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BackgroundsController : ControllerBase
{
    private readonly IBackgroundService _backgroundService;
    private readonly IMapper _mapper;

    public BackgroundsController(IBackgroundService backgroundService, IMapper mapper)
    {
        _backgroundService = backgroundService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<BackgroundDto>>> GetAll()
    {
        var backgrounds = await _backgroundService.GetAllBackgroundsAsync();
        // map entity to dto if needed
        var dtos = _mapper.Map<List<BackgroundDto>>(backgrounds);
        return Ok(dtos);
    }
}