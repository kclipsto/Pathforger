using Pathforger.Entities.Entities.Backgrounds;

namespace PathforgerDb.Services;

public interface IBackgroundService
{
    Task<IEnumerable<BackgroundEntity>> GetAllBackgroundsAsync();
}