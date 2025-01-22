using Microsoft.EntityFrameworkCore;
using Pathforger.Entities.Entities.Backgrounds;
using PathforgerCore.Interfaces;
using PathforgerDb;

namespace Pathforger.Infrastructure.Repositories;

public class EFBackgroundRepository : IBackgroundRepository
{
    private readonly PathforgerDbContext _context;

    public EFBackgroundRepository(PathforgerDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<BackgroundEntity>> GetAllAsync()
    {
        return await _context.Backgrounds.ToListAsync();
    }

    // Implement other methods from IBackgroundRepository as needed
    // e.g., GetByIdAsync, CreateAsync, UpdateAsync, DeleteAsync...
}