using System.ComponentModel.DataAnnotations.Schema;
using PathforgerDb.Entities.Base;

namespace PathforgerDb.Entities.Equipment;

[Table("Equipment")]
public class EquipmentEntity : BaseEntity
{
    public string? BaseItem { get; set; }
    public int Bulk { get; set; }
    public string? ContainerId { get; set; }
    
    public string? Description { get; set; }

    public int Hardness { get; set; }
    public int HpMax { get; set; }
    public int HpValue { get; set; }
    public int Level { get; set; }
    
    public string? MaterialGrade { get; set; }
    public string? MaterialType { get; set; }

    public string? PriceName { get; set; }
    public string? PriceValue { get; set; }
    
    public int Quantity { get; set; }

    public IList<EquipmentRuleEntity>? EquipmentRules { get; set; } = [];
    
    public string? Size { get; set; }
    public string? EquipmentRarity { get; set; }
    public IList<string> EquipmentTraits { get; set; } = [];

    public string? Usage { get; set; }
}