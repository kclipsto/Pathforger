using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PathforgerDb.Entities.Feats;

[Table("Feats")]
public class FeatEntity
{
    [Key]
    public string? Uuid { get; set; }
    public FeatValueEntity? FeatValue { get; set; }
}