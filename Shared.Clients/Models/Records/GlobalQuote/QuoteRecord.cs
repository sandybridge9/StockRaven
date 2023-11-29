using System.Text.Json.Serialization;

namespace Shared.Clients.Models.Records.GlobalQuote
{
    public record QuoteRecord
    {
        [JsonPropertyName("01. symbol")]
        public required string Symbol { get; set; }

        [JsonPropertyName("02. open")]
        public required string Open { get; set; }

        [JsonPropertyName("03. high")]
        public required string High { get; set; }

        [JsonPropertyName("04. low")]
        public required string Low { get; set; }

        [JsonPropertyName("05. price")]
        public required string Price { get; set; }

        [JsonPropertyName("06. volume")]
        public required string Volume { get; set; }

        [JsonPropertyName("07. latest trading day")]
        public required string LatestTradingDay { get; set; }

        [JsonPropertyName("08. previous close")]
        public required string PreviousClose { get; set; }

        [JsonPropertyName("09. change")]
        public required string Change { get; set; }

        [JsonPropertyName("10. change percent")]
        public required string ChangePercent { get; set; }
    }
}
