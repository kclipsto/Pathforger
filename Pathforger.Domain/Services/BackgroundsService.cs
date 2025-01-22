using Pathforger.Entities.Entities.Backgrounds;
using PathforgerCore.Interfaces;

namespace PathforgerDb.Services;

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