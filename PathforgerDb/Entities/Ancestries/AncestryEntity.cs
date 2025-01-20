using PathforgerDb.Enitites.Base;
using PathforgerDb.Enitites.Feats;

namespace PathforgerDb.Enitites.Ancestries;

public class AncestryEntity : BaseEntity
{
    public int AdditionalLanguagesCount { get; set; }
    public string? CustomAdditionalLanguage { get; set; }
    public IList<string>? AdditionalLanguagesValue { get; set; } = [];
    
    public IList<string>? Boosts0 { get; set; } = [];
    public IList<string>? Boosts1 { get; set; } = [];
    public IList<string>? Boosts2 { get; set; } = [];

    public string? Description { get; set; }

    public IList<string>? Flaws0 { get; set; } = [];

    public int Hp { get; set; }

    public Dictionary<string, FeatEntity> Feats { get; set; }

    // Languages (Flattened as list)
    public string LanguagesCustom { get; set; }
    public List<string> LanguagesValue { get; set; }

    // Publication (Flattened fields)
    public string PublicationLicense { get; set; }
    public bool PublicationRemaster { get; set; }
    public string PublicationTitle { get; set; }

    // Reach (Flattened as an int)
    public int Reach { get; set; }

    // Size (Flattened as a string)
    public string Size { get; set; }

    // Speed (Flattened as an int)
    public int Speed { get; set; }

    // Traits (Flattened as fields)
    public string TraitsRarity { get; set; }
    public List<string> TraitsValue { get; set; }

    // Vision (Flattened as a string)
    public string Vision { get; set; }

    // Rules (Flattened as a string list)
    public List<string> RulesKey { get; set; }
    public List<string> RulesLabel { get; set; }
    public bool RulesAlwaysActive { get; set; }
    public bool RulesToggleable { get; set; }
    public List<string> RulesSuboptionsLabel { get; set; }
    public List<string> RulesSuboptionsValue { get; set; }
}