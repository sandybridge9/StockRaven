﻿using System.Text.Json.Serialization;

namespace Shared.Clients.Models.MarketStatus
{
    public record GlobalMarketStatusRecord
    {
        [JsonPropertyName("endpoint")]
        public required string Endpoint { get; set; }

        [JsonPropertyName("markets")]
        public required List<MarketRecord> Markets { get; set; }
    }
}
