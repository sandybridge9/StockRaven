using System.Text.Json.Serialization;

namespace Shared.Clients.Models.MarketStatus
{
    public class GlobalMarketStatus
    {
        [JsonPropertyName("endpoint")]
        public required string Endpoint { get; set; }

        [JsonPropertyName("markets")]
        public required MarketRecord[] Markets { get; set; }
    }
}
