namespace PathforgerDb.Entities.Base;

public class BaseEntity
{
    public string? Id { get; set; }
    public string? Img { get; set; }
    public string? Name { get; set; }
    public string? Type { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    
    public string? PublicationLicense { get; set; }
    public bool PublicationRemaster { get; set; }
    public string? PublicationTitle { get; set; }
}