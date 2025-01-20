using System.ComponentModel.DataAnnotations.Schema;

namespace PathforgerDb.Entities.Equipment;

[Table("Runes")]
public class RuneEntity
{
    public string? Key { get; set; }
    public IList<string>? Predicate { get; set; } = [];
    public string? Selector { get; set; }
    public int Value { get; set; }
}