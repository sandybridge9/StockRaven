using System.Text.Json.Serialization;

namespace Shared.Clients.Models.Records.GlobalQuote
{
    public record GlobalQuoteRecord
    {
        [JsonPropertyName("Global Quote")]
        public required QuoteRecord QuoteRecord { get; set; }
    }
}