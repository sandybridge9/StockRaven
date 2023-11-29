using System.Text.Json.Serialization;

namespace Shared.Clients.Models.Records.DailyAdjustedTimeSeries
{
    public record DailyAdjustedDataRecord
    {
        [JsonPropertyName("1. open")]
        public required string Open { get; set; }

        [JsonPropertyName("2. high")]
        public required string High { get; set; }

        [JsonPropertyName("3. low")]
        public required string Low { get; set; }

        [JsonPropertyName("4. close")]
        public required string Close { get; set; }

        [JsonPropertyName("5. adjusted close")]
        public required string AdjustedClose { get; set; }

        [JsonPropertyName("6. volume")]
        public required string Volume { get; set; }

        [JsonPropertyName("7. dividend amount")]
        public required string DividentAmount { get; set; }

        [JsonPropertyName("8. split coefficient")]
        public required string SplitCoefficient { get; set; }
    }
}
