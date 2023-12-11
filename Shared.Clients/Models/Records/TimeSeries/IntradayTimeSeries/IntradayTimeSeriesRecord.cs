using System.Text.Json.Serialization;

namespace Shared.Clients.Models.Records.TimeSeries.IntradayTimeSeries
{
    public record IntradayTimeSeriesRecord
    {
        [JsonPropertyName("Meta Data")]
        public required IntradayTimeSeriesMetadataRecord MetadataRecord { get; set; }

        [JsonPropertyName("Time Series (5min)")]
        public required Dictionary<string, IntradayDataRecord> IntradayDataRecords { get; set; }
    }
}
