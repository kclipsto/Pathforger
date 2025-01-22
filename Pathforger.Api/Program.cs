using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pathforger.Infrastructure.Data.Backgrounds;
using Pathforger.Infrastructure.Repositories;
using PathforgerCore.Interfaces;
using PathforgerDb;
using PathforgerDb.Services;
using BackgroundService = PathforgerDb.Services.BackgroundService;

var builder = WebApplication.CreateBuilder(args);
// 1. Register services
builder.Services.AddDbContext<PathforgerDbContext>(options =>
    options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFCoreExampleDB;Trusted_Connection=True;"));

builder.Services.AddAutoMapper(typeof(Program).Assembly);

// Repositories, domain services, etc.
builder.Services.AddScoped<IBackgroundRepository, EFBackgroundRepository>();
builder.Services.AddScoped<IBackgroundService, BackgroundService>();

builder.Services.AddControllers();

var app = builder.Build();

// 2. Seeding
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<PathforgerDbContext>();
    var mapper = scope.ServiceProvider.GetRequiredService<IMapper>();
    dbContext.Database.EnsureCreated();

    // seed backgrounds
    await DataSeeder.SeedBackgroundsAsync(dbContext, mapper);
}

// 3. Run the app
app.MapControllers();
app.Run();
