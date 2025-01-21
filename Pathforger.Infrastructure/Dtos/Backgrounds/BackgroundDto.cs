using System.Text.Json.Serialization;

namespace PathforgerApi.Dtos.Backgrounds;

public class BackgroundDto
{
    [JsonPropertyName("_id")]
    public string Id { get; set; }

    public string Img { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    
    public BackgroundSystemDto System { get; set; }
}

// The 'system' property in your JSON
public class BackgroundSystemDto
{
    public BoostsDto Boosts { get; set; }
    public DescriptionDto Description { get; set; }
    public Dictionary<string, object> Items { get; set; } // or a custom ItemsDto if needed

    public PublicationDto Publication { get; set; }
    public List<RuleDto> Rules { get; set; } = new List<RuleDto>();
    public TrainedSkillsDto TrainedSkills { get; set; }
    public TraitsDto Traits { get; set; }
}

public class BoostsDto
{
    public BoostValueDto Zero { get; set; } // "0"
    public BoostValueDto One { get; set; }  // "1"
}

public class BoostValueDto
{
    public List<string> Value { get; set; } = new();
}

public class DescriptionDto
{
    public string Value { get; set; }
}

public class PublicationDto
{
    public string License { get; set; }
    public bool Remaster { get; set; }
    public string Title { get; set; }
}

public class RuleDto
{
    public bool AllowDuplicate { get; set; }
    public string Key { get; set; }
    public Dictionary<string, string> PreselectChoices { get; set; } 
    public string Uuid { get; set; }
}

public class TrainedSkillsDto
{
    public string Custom { get; set; }
    public List<string> Lore { get; set; } = new();
    public List<string> Value { get; set; } = new();
}

public class TraitsDto
{
    public string Rarity { get; set; }
    public List<string> Value { get; set; } = new();
}