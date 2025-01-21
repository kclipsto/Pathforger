using PathforgerDb.Entities.Backgrounds;
using PathforgerDb.Interfaces;

namespace PathforgerApi.Services;

public class BackgroundService : IBackgroundService
{
    private readonly IBackgroundRepository _repo;

    public BackgroundService(IBackgroundRepository repo)
    {
        _repo = repo;
    }

    public async Task<IEnumerable<BackgroundEntity>> GetAllBackgroundsAsync()
    {
        // Orchestrate logic, call repository, etc.
        return await _repo.GetAllAsync();
    }
}