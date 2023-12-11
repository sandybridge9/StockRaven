using System.Text.Json.Serialization;

namespace Shared.Clients.Models.Records.DailyTimeSeries
{
    public record DailyTimeSeriesRecord
    {
        [JsonPropertyName("Meta Data")]
        public required DailyTimeSeriesMetadataRecord MetadataRecord { get; set; }

        [JsonPropertyName("Time Series (Daily)")]
        public required Dictionary<DateTime, DailyDataRecord> DailyDataRecords { get; set; }
    }
}
