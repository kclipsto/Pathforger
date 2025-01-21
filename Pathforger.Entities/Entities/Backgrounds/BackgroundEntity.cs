using System.ComponentModel.DataAnnotations.Schema;
using PathforgerDb.Entities.Base;
using PathforgerDb.Entities.Feats;

namespace PathforgerDb.Entities.Backgrounds;

[Table("Backgrounds")]
public class BackgroundEntity : BaseEntity
{
    public IList<string>? Boosts0 { get; set; } = [];
    public IList<string>? Boosts1 { get; set; } = []; 
    
    public string? Description { get; set; }
    public IList<FeatEntity>? Feats { get; set; } = [];
    
    public string? TrainedSkillsCustom { get; set; }
    public IList<string>? TrainedSkillsLore { get; set; } = new List<string>();
    public IList<string>? TrainedSkillsValue { get; set; } = new List<string>();
    
    public string? TraitsRarity { get; set; }
    public IList<string>? TraitsValue { get; set; } = new List<string>();
    public IList<string>? BackgroundRules { get; set; } = new List<string>();
}
