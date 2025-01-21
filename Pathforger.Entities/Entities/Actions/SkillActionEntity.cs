using System.ComponentModel.DataAnnotations.Schema;

namespace PathforgerDb.Entities.Actions;

[Table("SkillActions")]
public class SkillActionEntity : BasicActionEntity
{
    public string? Skill { get; set; } 
    public string? CheckType { get; set; } 
    public int? DC { get; set; } 
    public string? CriticalSuccessEffect { get; set; } 
    public string? SuccessEffect { get; set; }
    public string? FailureEffect { get; set; } 
    public string? CriticalFailureEffect { get; set; }
}