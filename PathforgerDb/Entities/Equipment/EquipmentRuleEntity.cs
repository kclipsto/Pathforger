using System.ComponentModel.DataAnnotations.Schema;

namespace PathforgerDb.Entities.Equipment;

[Table("EquipmentRules")]
public class EquipmentRuleEntity
{
    public IList<DamageTypeEntity>? DamageTypes { get; set; }
    public IList<RuneEntity>? Runes { get; set; }
}