using System.ComponentModel.DataAnnotations.Schema;
using Pathforger.Entities.Entities.Base;
using Pathforger.Entities.Entities.Feats;

namespace Pathforger.Entities.Entities.Classes;

[Table("Classes")]
public class ClassEntity : BaseEntity
{
    public IList<int>? AncestryFeatLevels { get; set; } = [];
    public IList<int>? ClassFeatLevels { get; set; } = [];
    public IList<int>? SkillFeatLevels { get; set; } = [];
    public IList<int>? SkillIncreaseLevels { get; set; } = [];
    public IList<int>? GeneralFeatLevels { get; set; } = [];
    
    //Items
    public IList<FeatEntity>? ClassFeats { get; set; } = [];
    //Rules
    public IList<ClassRuleEntity> ClassRules { get; set; } = [];
    
    public bool AdvancedAttack { get; set; }
    public bool MartialAttack { get; set; }
    public bool SimpleAttack { get; set; }
    public bool UnarmedAttack { get; set; }
    
    public string? OtherAttackName { get; set; }
    public bool CanAttack { get; set; }
    
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
}