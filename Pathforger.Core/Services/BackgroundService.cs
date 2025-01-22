namespace Pathforger.Core.Services;

public class BackgroundService : IBackgroundService
{
    private readonly IBackgroundRepository _repository;
    private readonly IMapper _mapper; // If using AutoMapper

    public BackgroundService(IBackgroundRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<BackgroundDto>> GetAllBackgroundsAsync()
    {
        var entities = await _repository.GetAllAsync();
        return _mapper.Map<IEnumerable<BackgroundDto>>(entities);
    }
}