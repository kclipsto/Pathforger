namespace PathforgerDb.Enitites.Spells;

public class SpellEntity
{
    public string Id { get; set; }
    public string Image { get; set; }
    public string Name { get; set; }
    public string Area { get; set; }
    public string Cost { get; set; }
    public bool Counteraction { get; set; }
    
    // Defense
    public string DefenseSave { get; set; }
    public bool DefenseBasic { get; set; }
    
    // Description
    public string Description { get; set; }
    
    // Duration
    public bool DurationSustained { get; set; }
    public string DurationValue { get; set; }
    
    // Level
    public int Level { get; set; }
    
    // Publication
    public string PublicationLicense { get; set; }
    public bool PublicationRemaster { get; set; }
    public string PublicationTitle { get; set; }
    
    // Range
    public string Range { get; set; }
    
    // Requirements
    public string Requirements { get; set; }
    
    // Target
    public string Target { get; set; }
    
    // Time
    public string Time { get; set; }
    
    // Traits
    public string Rarity { get; set; }
    public List<string> Traditions { get; set; }
    public List<string> Traits { get; set; }
}
