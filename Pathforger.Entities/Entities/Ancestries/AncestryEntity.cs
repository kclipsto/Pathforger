using System.ComponentModel.DataAnnotations.Schema;
using PathforgerDb.Entities.Base;
using PathforgerDb.Entities.Feats;

namespace PathforgerDb.Entities.Ancestries;

[Table("Ancestries")]
public class AncestryEntity : BaseEntity
{
    public int AdditionalLanguagesCount { get; set; }
    public string? CustomAdditionalLanguage { get; set; }
    public IList<string>? AdditionalLanguages { get; set; } = [];
    
    public IList<string>? BoostsStrength { get; set; } = [];
    public IList<string>? BoostsDexterity { get; set; } = [];
    public IList<string>? BoostsConstitution { get; set; } = [];

    public string? Description { get; set; }

    public IList<string>? Flaws { get; set; } = [];

    public int Hp { get; set; }
    
    // Items
    public IList<FeatEntity>? Feats { get; set; }
    
    // Rules
    public IList<string>? AncestryRules { get; set; } = [];

    public string? CustomLanguage { get; set; }
    public IList<string>? Languages { get; set; } = [];
    
    public int Reach { get; set; }
    public string? Size { get; set; }
    public int Speed { get; set; }
    public string? Vision { get; set; }

    public string? Rarity { get; set; }
    public IList<string>? Traits { get; set; } = [];
}