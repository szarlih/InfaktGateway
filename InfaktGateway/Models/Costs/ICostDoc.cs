using System.Text.Json.Serialization;

namespace InfaktGateway.Models.Costs
{
    public interface ICostDoc
    {
        [JsonPropertyName("uuid")]
        string Uuid { get; set; }

        [JsonPropertyName("net_price")]
        int NetPrice { get; set; }

        [JsonPropertyName("gross_price")]
        int GrossPrice { get; set; }

        [JsonPropertyName("tax_price")]
        int TaxPrice { get; set; }

        [JsonPropertyName("currency")]
        string Currency { get; set; }

        [JsonPropertyName("accounted_at")]
        string AccountedAt { get; set; }

        [JsonPropertyName("issue_date")]
        string IssueDate { get; set; }

        [JsonPropertyName("received_date")]
        string ReceivedDate { get; set; }

        [JsonPropertyName("due_date")]
        string DueDate { get; set; }

        [JsonPropertyName("seller_name")]
        string SellerName { get; set; }

        [JsonPropertyName("description")]
        string Description { get; set; }

        [JsonPropertyName("created_at")]
        string CreatedAt { get; set; }

        [JsonPropertyName("number")]
        string Number { get; set; }

        [JsonPropertyName("added_by")]
        string AddedBy { get; set; }

        [JsonPropertyName("category")]
        string Category { get; set; }

        [JsonPropertyName("kind")]
        string Kind { get; set; }

        [JsonPropertyName("statuses")]
        List<ICostStatus> Statuses { get; set; }

        [JsonPropertyName("notes")]
        List<INote> Notes { get; set; }
    }
}
