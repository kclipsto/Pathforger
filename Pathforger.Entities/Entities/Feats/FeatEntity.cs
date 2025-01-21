using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pathforger.Entities.Entities.Feats;

[Table("Feats")]
public class FeatEntity
{
    [Key]
    public string? Uuid { get; set; }
    public FeatValueEntity? FeatValue { get; set; }
}