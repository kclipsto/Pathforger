using PathforgerDb.Entities.Backgrounds;

namespace PathforgerDb.Interfaces;

public interface IBackgroundRepository
{
    Task<IEnumerable<BackgroundEntity>> GetAllAsync();
}