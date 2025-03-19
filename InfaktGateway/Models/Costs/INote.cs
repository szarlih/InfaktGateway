using System.Text.Json.Serialization;

namespace InfaktGateway.Models.Costs;

public interface INote
{
    [JsonPropertyName("kind")]
    string Kind { get; set; }

    [JsonPropertyName("content")]
    string Content { get; set; }

    [JsonPropertyName("created_by")]
    string CreatedBy { get; set; }

    [JsonPropertyName("created_at")]
    string CreatedAt { get; set; }
}
