using System.Text.Json;
using AutoMapper;
using Pathforger.Entities.Entities.Backgrounds;
using PathforgerApi.Dtos.Backgrounds;
using PathforgerDb;

namespace Pathforger.Infrastructure.Data.Backgrounds;

public class DataSeeder
{
    public static async Task SeedBackgroundsAsync(PathforgerDbContext context, IMapper mapper)
    {
        // 1. Check if data already seeded
        if (context.Backgrounds.Any())
            return;

        // 2. Get all JSON files from the folder
        var filePaths = Directory.GetFiles(@"C:\Users\Kaiser Clipston\source\repos\pf2e\packs\backgrounds\", "*.json");

        // 3. Prepare a list to collect entities
        var allBackgroundEntities = new List<BackgroundEntity>();

        // 4. Loop over each file
        foreach (var filePath in filePaths)
        {
            var jsonContent = await File.ReadAllTextAsync(filePath);

            // 5. Deserialize
            // If each JSON file is structured for a single background, 
            // we'll read one Dto at a time
            var dto = JsonSerializer.Deserialize<BackgroundDto>(jsonContent);
            if (dto == null) continue;

            // 6. Convert to entity (using AutoMapper or manual mapping)
            var backgroundEntity = mapper.Map<BackgroundEntity>(dto);

            // 7. Collect the entity
            allBackgroundEntities.Add(backgroundEntity);
        }

        // 8. Save to DB
        context.Backgrounds.AddRange(allBackgroundEntities);
        await context.SaveChangesAsync();
    }
}