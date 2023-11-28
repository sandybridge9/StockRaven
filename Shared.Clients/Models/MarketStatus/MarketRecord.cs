using System.Text.Json.Serialization;

namespace Shared.Clients.Models.MarketStatus
{
    public record MarketRecord
    {
        [JsonPropertyName("market_type")]
        public required string MarketType { get; set; }

        [JsonPropertyName("region")]
        public required string Region { get; set; }

        [JsonPropertyName("primary_exchanges")]
        public required string PrimaryExchanges { get; set; }

        [JsonPropertyName("local_open")]
        public required string LocalOpen { get; set; }

        [JsonPropertyName("local_close")]
        public required string LocalClose { get; set; }

        [JsonPropertyName("current_status")]
        public required string CurrentStatus { get; set; }

        [JsonPropertyName("notes")]
        public required string Notes { get; set; }
    }
}
