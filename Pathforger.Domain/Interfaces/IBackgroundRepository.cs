using Pathforger.Entities.Entities.Backgrounds;

namespace PathforgerCore.Interfaces;

public interface IBackgroundRepository
{
    Task<IEnumerable<BackgroundEntity>> GetAllAsync();
}