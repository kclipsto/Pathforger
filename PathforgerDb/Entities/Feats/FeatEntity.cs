using PathforgerDb.Enitites.Base;

namespace PathforgerDb.Enitites.Feats;

public class FeatEntity : BaseEntity
{
    public string? Uuid { get; set; }
    
    public string? ActionType { get; set; }
    public string? Actions { get; set; }
    public string? Category { get; set; }
    public string? Description { get; set; }
    public IList<string>? Prerequisites { get; set; } = [];
    public string? PublicationLicense { get; set; }
    public bool PublicationRemaster { get; set; }
    public string? PublicationTitle { get; set; }
    public string? TraitRarity { get; set; }
    public List<string>? Traits { get; set; }
}