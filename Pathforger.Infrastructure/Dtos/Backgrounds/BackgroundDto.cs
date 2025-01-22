using System.Text.Json.Serialization;

namespace PathforgerApi.Dtos.Backgrounds;

using System.Text.Json.Serialization;

public class BackgroundDto
{
    [JsonPropertyName("_id")]
    public string? Id { get; set; }

    [JsonPropertyName("img")]
    public string? Img { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("system")]
    public BackgroundSystemDto? System { get; set; }
}

// The 'system' property in your JSON
public class BackgroundSystemDto
{
    [JsonPropertyName("boosts")]
    public BoostsDto? Boosts { get; set; }

    [JsonPropertyName("description")]
    public DescriptionDto? Description { get; set; }

    [JsonPropertyName("items")]
    public Dictionary<string, BackgroundFeatDto> Feats { get; set; } = [];

    [JsonPropertyName("publication")]
    public PublicationDto? Publication { get; set; }

    [JsonPropertyName("rules")]
    public IList<RuleDto>? Rules { get; set; }

    [JsonPropertyName("trainedSkills")]
    public TrainedSkillsDto? TrainedSkills { get; set; }

    [JsonPropertyName("traits")]
    public TraitsDto? Traits { get; set; }
}

public class BackgroundFeatDto
{
    [JsonPropertyName("img")]
    public string? Img { get; set; }

    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }
}

public class BoostsDto
{
    // The JSON has "0" and "1" as keys; we can map them to "Zero" and "One" in C#.
    [JsonPropertyName("0")]
    public BoostValueDto? Zero { get; set; }

    [JsonPropertyName("1")]
    public BoostValueDto? One { get; set; }
}

public class BoostValueDto
{
    [JsonPropertyName("value")]
    public IList<string>? Value { get; set; }
}

public class DescriptionDto
{
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public class PublicationDto
{
    [JsonPropertyName("license")]
    public string? License { get; set; }

    [JsonPropertyName("remaster")]
    public bool Remaster { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

public class RuleDto
{
    [JsonPropertyName("allowDuplicate")]
    public bool AllowDuplicate { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("preselectChoices")]
    public Dictionary<string, string>? PreselectChoices { get; set; }

    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }
}

public class TrainedSkillsDto
{
    [JsonPropertyName("custom")]
    public string? Custom { get; set; }

    [JsonPropertyName("lore")]
    public IList<string>? Lore { get; set; }

    [JsonPropertyName("value")]
    public IList<string>? Value { get; set; } 
}

public class TraitsDto
{
    [JsonPropertyName("rarity")]
    public string? Rarity { get; set; }

    [JsonPropertyName("value")]
    public IList<string>? Value { get; set; }
}
