using Microsoft.EntityFrameworkCore;
using Pathforger.Entities.Entities.Actions;
using Pathforger.Entities.Entities.Ancestries;
using Pathforger.Entities.Entities.Backgrounds;
using Pathforger.Entities.Entities.Classes;
using Pathforger.Entities.Entities.Conditions;
using Pathforger.Entities.Entities.Equipment;
using Pathforger.Entities.Entities.Feats;
using Pathforger.Entities.Entities.Spells;

namespace PathforgerDb;

public class PathforgerDbContext : DbContext
{
    public DbSet<ClassEntity> Classes { get; set; }
    public DbSet<BackgroundEntity> Backgrounds { get; set; }
    public DbSet<AncestryEntity> Ancestries { get; set; }
    public DbSet<ConditionEntity> Conditions { get; set; }
    public DbSet<EquipmentEntity> Equipment { get; set; }
    public DbSet<FeatEntity> Feats { get; set; }
    public DbSet<FeatValueEntity> FeatValues { get; set; }
    public DbSet<SpellEntity> Spells { get; set; }
    public DbSet<BasicActionEntity> BasicActions { get; set; }
    public DbSet<SkillActionEntity> SkillActions { get; set; }
    public DbSet<DamageTypeEntity> DamageType { get; set; }
    public DbSet<RuneEntity> Runes { get; set; }
    
    public PathforgerDbContext(DbContextOptions<PathforgerDbContext> options)
        : base(options)
    {
    }
    
    // This parameterless constructor is for design time only
    public PathforgerDbContext()
    {
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            // Fallback or local dev config
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFCoreExampleDB;Trusted_Connection=True;");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Set up composite key and relationship for BackgroundFeatEntity here
        modelBuilder.Entity<BackgroundFeatEntity>()
            .HasKey(bf => new { bf.BackgroundId, bf.Key });

        modelBuilder.Entity<BackgroundFeatEntity>()
            .HasOne(bf => bf.Background)
            .WithMany(b => b.Feats)
            .HasForeignKey(bf => bf.BackgroundId);
    }
}