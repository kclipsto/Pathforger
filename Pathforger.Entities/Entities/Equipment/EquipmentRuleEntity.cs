using System.ComponentModel.DataAnnotations.Schema;
using PathforgerDb.Entities.Base;

namespace PathforgerDb.Entities.Equipment;

[Table("EquipmentRules")]
public class EquipmentRuleEntity : BaseEntity
{
    public IList<DamageTypeEntity>? DamageTypes { get; set; }
    public IList<RuneEntity>? Runes { get; set; }
}