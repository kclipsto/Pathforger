using System.ComponentModel.DataAnnotations.Schema;
using Pathforger.Entities.Entities.Base;

namespace Pathforger.Entities.Entities.Actions;

[Table("BasicActions")]
public class BasicActionEntity : BaseEntity
{
    public string? FolderId { get; set; }
    public string? ActionType { get; set; } 
    public int? Actions { get; set; } 
    public string? Category { get; set; } 
    public string? Description { get; set; } 
    public string? Rarity { get; set; } 
    public IList<string>? Traits { get; set; } = []; 
    public IList<string>? Rules { get; set; } = [];
}