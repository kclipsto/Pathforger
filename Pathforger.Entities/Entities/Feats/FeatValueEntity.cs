using System.ComponentModel.DataAnnotations.Schema;
using Pathforger.Entities.Entities.Base;

namespace Pathforger.Entities.Entities.Feats;

[Table("FeatValues")]
public class FeatValueEntity : BaseEntity
{
    public string? Img { get; set; }
    public string? Name { get; set; }
    public string? Type { get; set; }
    public string? PublicationLicense { get; set; }
    public bool PublicationRemaster { get; set; }
    public string? PublicationTitle { get; set; }
    public string? FeatType { get; set; }
    public int Level { get; set; }
    public string? ActionType { get; set; }
    public string? Actions { get; set; }
    public string? Category { get; set; }
    public string? Description { get; set; }
    public IList<string>? Prerequisites { get; set; } = [];
    public string? Rarity { get; set; }
    public IList<string>? Traits { get; set; }
    public IList<string>? Rules { get; set; } = [];
}