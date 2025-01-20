using PathforgerDb.Enitites.Base;

namespace PathforgerDb.Enitites.Classes;

public class ClassEntity : BaseEntity
{
    public IList<int>? AncestryFeatLevels { get; set; } = [];
    public IList<int>? ClassFeatLevels { get; set; } = [];
    public IList<int>? SkillFeatLevels { get; set; } = [];
    public IList<int>? SkillIncreaseLevels { get; set; } = [];
    public IList<int>? GeneralFeatLevels { get; set; } = [];
    
    //Items
    public Dictionary<string, ClassFeatEntity>? ClassFeats { get; set; } = [];
    //Rules
    public IList<ClassRuleEntity> ClassRules { get; set; } = [];
    
    public bool AdvancedAttack { get; set; }
    public bool MartialAttack { get; set; }
    public bool SimpleAttack { get; set; }
    public bool UnarmedAttack { get; set; }
    public OtherAttackEntity? OtherAttack { get; set; }
    
    public bool HeavyDefense { get; set; }
    public bool MediumDefense { get; set; }
    public bool LightDefense { get; set; }
    public bool UnarmoredDefense { get; set; }

    public string? Description { get; set; } 
    
    public int Hp { get; set; }
    public string? KeyAbility { get; set; }  
    public int Perception { get; set; }
    public int SavingThrowsFortitude { get; set; }
    public int SavingThrowsReflex { get; set; }
    public int SavingThrowsWill { get; set; }
    public bool CanSpellcast { get; set; }

    public int AdditionalTrainedSkills { get; set; }
    public IList<string> TrainedSkillsValue { get; set; } = [];
    
    public string? TraitsRarity { get; set; }
    public IList<string> TraitsValue { get; set; } = [];
    
    public string? PublicationLicense { get; set; }
    public bool? PublicationRemaster { get; set; }
    public string? PublicationTitle { get; set; }
}

public class ClassRuleEntity
{
    public string? Key { get; set; }
    public string? Mode { get; set; }
    public string? Path { get; set; }
    public int Value { get; set; }
}

public class OtherAttackEntity
{
    public string? AttackName { get; set; }
    public bool CanAttack { get; set; }
}