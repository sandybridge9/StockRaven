using System.Text.Json.Serialization;

namespace Shared.Clients.Models.GlobalQuote
{
    public record QuoteRecord
    {
        [JsonPropertyName("01. symbol")]
        public required string Symbol { get; set; }

        [JsonPropertyName("02. open")]
        public required decimal Open { get; set; }

        [JsonPropertyName("03. high")]
        public required decimal High { get; set; }

        [JsonPropertyName("04. low")]
        public required decimal Low { get; set; }

        [JsonPropertyName("05. price")]
        public required decimal Price { get; set; }

        [JsonPropertyName("06. volume")]
        public required int Volume { get; set; }

        [JsonPropertyName("07. latest trading day")]
        public required DateTime LatestTradingDay { get; set; }

        [JsonPropertyName("08. previous close")]
        public required decimal PreviousClose { get; set; }

        [JsonPropertyName("09. change")]
        public required decimal Change { get; set; }

        [JsonPropertyName("10. change percent")]
        public required string ChangePercent { get; set; }
    }
}
