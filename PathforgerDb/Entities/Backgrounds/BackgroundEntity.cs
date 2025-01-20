using PathforgerDb.Enitites.Base;
using PathforgerDb.Enitites.Feats;

namespace PathforgerDb.Enitites.Backgrounds;

public class BackgroundEntity : BaseEntity
{
    public IList<string>? Boosts0 { get; set; } = [];
    public IList<string>? Boosts1 { get; set; } = [];
    
    public string? Description { get; set; }
    public IList<FeatEntity> Feats { get; set; } = [];
    
    public string? PublicationLicense { get; set; }
    public bool PublicationRemaster { get; set; }
    public string? PublicationTitle { get; set; }
    
    public string? TrainedSkillsCustom { get; set; }
    public IList<string>? TrainedSkillsLore { get; set; }
    public IList<string>? TrainedSkillsValue { get; set; }
    
    public string? TraitsRarity { get; set; }
    public IList<string>? TraitsValue { get; set; }
}
