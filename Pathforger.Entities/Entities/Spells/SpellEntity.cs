using System.ComponentModel.DataAnnotations.Schema;
using PathforgerDb.Entities.Base;

namespace PathforgerDb.Entities.Spells;

[Table("Spells")]
public class SpellEntity : BaseEntity
{
    public string? Area { get; set; }
    public string? Cost { get; set; }
    public bool Counteraction { get; set; }
    public string? DefenseSave { get; set; }
    public bool DefenseBasic { get; set; }
    public string? Description { get; set; }
    public bool DurationSustained { get; set; }
    public string? DurationValue { get; set; }
    public int Level { get; set; }
    public string? Range { get; set; }
    public string? Requirements { get; set; }
    public string? Target { get; set; }
    public string? Time { get; set; }
    public string? Rarity { get; set; }
    public List<string>? Traditions { get; set; }
    public List<string>? Traits { get; set; }
}
