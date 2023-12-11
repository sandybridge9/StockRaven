using System.Text.Json.Serialization;

namespace Shared.Clients.Models.Records.DailyTimeSeries
{
    public record DailyTimeSeriesMetadataRecord
    {
        [JsonPropertyName("1. Information")]
        public required string Information { get; set; }

        [JsonPropertyName("2. Symbol")]
        public required string Symbol { get; set; }

        [JsonPropertyName("3. Last Refreshed")]
        public required string LastRefreshed { get; set; }

        [JsonPropertyName("4. Output Size")]
        public required string OutputSize { get; set; }

        [JsonPropertyName("5. Time Zone")]
        public required string TimeZone { get; set; }
    }
}
