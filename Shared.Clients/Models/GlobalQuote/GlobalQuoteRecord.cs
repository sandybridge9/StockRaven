using System.Text.Json.Serialization;

namespace Shared.Clients.Models.GlobalQuote
{
    public record GlobalQuoteRecord
    {
        [JsonPropertyName("Global Quote")]
        public required QuoteRecord QuoteRecord { get; set; }
    }
}
