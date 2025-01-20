namespace PathforgerDb.Enitites.Equipment;

public class EquipmentEntity
{
    public string? Id { get; set; }
    public string? Image { get; set; }
    public string? Name { get; set; }
    public string? Type { get; set; }
    
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
    
    public Dictionary<string, int>? Price { get; set; }
    
    public string? PublicationLicense { get; set; }
    public bool PublicationRemaster { get; set; }
    public string? PublicationTitle { get; set; }
    
    public int Quantity { get; set; }
    
    public IList<EquipmentRuleEntity>? EquipmentRules { get; set; } 
    
    public string? Size { get; set; }
    public string? EquipmentRarity { get; set; }
    public IList<string> EquipmentTraits { get; set; } = [];

    public string? Usage { get; set; }
}

public class DamageTypeEntity
{
    public string BaseType { get; set; }
    public string Category { get; set; }
    public string DamageType { get; set; }
    public int DamageDice { get; set; }
    public string DamageDie { get; set; }
    public string Group { get; set; }
    public string Img { get; set; }
    public string Key { get; set; }
    public string Label { get; set; }
    public IList<string> Predicate { get; set; } = [];
    public string Slug { get; set; }
    public IList<string> Traits { get; set; } = [];
}

public class EquipmentRuleEntity
{
    public IList<DamageTypeEntity>? DamageTypes { get; set; }
    public IList<RuneEntity>? Runes { get; set; }
}

public class RuneEntity
{
    public string Key { get; set; }
    public IList<string>? Predicate { get; set; } = [];
    public string Selector { get; set; }
    public int Value { get; set; }
}