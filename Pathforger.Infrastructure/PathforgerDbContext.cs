using Microsoft.EntityFrameworkCore;
using PathforgerDb.Entities.Actions;
using PathforgerDb.Entities.Ancestries;
using PathforgerDb.Entities.Backgrounds;
using PathforgerDb.Entities.Classes;
using PathforgerDb.Entities.Conditions;
using PathforgerDb.Entities.Equipment;
using PathforgerDb.Entities.Feats;
using PathforgerDb.Entities.Spells;

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
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFCoreExampleDB;Trusted_Connection=True;");
    }
}