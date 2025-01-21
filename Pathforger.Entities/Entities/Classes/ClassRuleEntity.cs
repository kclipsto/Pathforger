using System.ComponentModel.DataAnnotations.Schema;
using PathforgerDb.Entities.Base;

namespace PathforgerDb.Entities.Classes;

[Table("ClassRules")]
public class ClassRuleEntity : BaseEntity
{
    public string? Mode { get; set; }
    public string? Path { get; set; }
    public int Value { get; set; }
}