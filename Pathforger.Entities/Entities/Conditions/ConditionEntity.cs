using System.ComponentModel.DataAnnotations.Schema;
using Pathforger.Entities.Entities.Base;

namespace Pathforger.Entities.Entities.Conditions;
 
[Table("Conditions")]
public class ConditionEntity : BaseEntity
{
    public string? Description { get; set; }
    public string? DurationUnit { get; set; }
    public int DurationValue { get; set; }
    public string? Group { get; set; }
    public IList<string>? Overrides { get; set; } = [];
    public IList<string>? Rules { get; set; } = [];
    public IList<string>? Traits { get; set; } = [];
   
    public bool ConditionIsValued { get; set; }
    public string? ConditionValue { get; set; }
     
    public IList<string>? ReferenceChildren { get; set; } = [];
    public IList<string>? ReferenceImmunityFrom { get; set; } = [];
    public IList<string>? ReferenceOverriddenBy { get; set; } = [];
    public IList<string>? ReferenceOverrides { get; set; } = [];
}