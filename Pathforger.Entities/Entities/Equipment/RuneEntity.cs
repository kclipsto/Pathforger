using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PathforgerDb.Entities.Equipment;
[Table("Runes")]
public class RuneEntity
{
    [Key]
    public string? Key { get; set; }
    public IList<string>? Predicate { get; set; } = [];
    public string? Selector { get; set; }
    public int Value { get; set; }
}