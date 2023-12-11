using System.Text.Json.Serialization;

namespace Shared.Clients.Models.Records.TimeSeries.DailyTimeSeries
{
    public record DailyDataRecord
    {
        [JsonPropertyName("1. open")]
        public required string Open { get; set; }

        [JsonPropertyName("2. high")]
        public required string High { get; set; }

        [JsonPropertyName("3. low")]
        public required string Low { get; set; }

        [JsonPropertyName("4. close")]
        public required string Close { get; set; }

        [JsonPropertyName("5. volume")]
        public required string Volume { get; set; }
    }
}
