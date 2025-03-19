using System.Text.Json.Serialization;

namespace InfaktGateway.Models.Costs;

public interface ICostStatus
{
    [JsonPropertyName("symbol")]
    string Symbol { get; set; }

    [JsonPropertyName("name")]
    string Name { get; set; }

    [JsonPropertyName("group")]
    string Group { get; set; }
}
