using System.ComponentModel.DataAnnotations.Schema;
using Pathforger.Entities.Entities.Base;

namespace Pathforger.Entities.Entities.Equipment;

[Table("EquipmentRules")]
public class EquipmentRuleEntity : BaseEntity
{
    public IList<DamageTypeEntity>? DamageTypes { get; set; }
    public IList<RuneEntity>? Runes { get; set; }
}