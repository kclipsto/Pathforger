using PathforgerDb.Enitites.Classes;

namespace PathforgerDb.Enitites.Conditions;

public class ConditionEntity
{
    public string Id { get; set; }
    public string Image { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string DurationUnit { get; set; }
    public int DurationValue { get; set; }
    public string Group { get; set; }
    public IList<string> Overrides { get; set; } = [];

    public string PublicationLicense { get; set; }
    public bool PublicationRemaster { get; set; }
    public string PublicationTitle { get; set; }
    
    public IList<string> Rules { get; set; } = [];
    public IList<string> Traits { get; set; } = [];
   
    public bool ConditionIsValued { get; set; }
    public string ConditionValue { get; set; }
     
    public IList<string> ReferenceChildren { get; set; } = [];
    public IList<string> ReferenceImmunityFrom { get; set; } = [];
    public IList<string> ReferenceOverriddenBy { get; set; } = [];
    public IList<string> ReferenceOverrides { get; set; } = [];
}