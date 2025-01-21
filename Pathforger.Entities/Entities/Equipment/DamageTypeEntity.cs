using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PathforgerDb.Entities.Equipment;

[Table("DamageTypes")]
public class DamageTypeEntity
{
    [Key]
    public string? Key { get; set; }
    public string? BaseType { get; set; }
    public string? Category { get; set; }
    public string? DamageType { get; set; }
    public int DamageDice { get; set; }
    public string? DamageDie { get; set; }
    public string? Group { get; set; }
    public string? Label { get; set; }
    public IList<string>? Predicate { get; set; } = [];
    public string? Slug { get; set; }
    public IList<string>? Traits { get; set; } = [];
}