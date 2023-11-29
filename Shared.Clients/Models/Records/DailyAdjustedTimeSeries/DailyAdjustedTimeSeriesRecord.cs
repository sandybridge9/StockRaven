using System.Text.Json.Serialization;

namespace Shared.Clients.Models.Records.DailyAdjustedTimeSeries
{
    public record DailyAdjustedTimeSeriesRecord
    {
        [JsonPropertyName("Meta Data")]
        public required DailyAdjustedTimeSeriesMetadataRecord MetadataRecords { get; set; }

        [JsonPropertyName("Time Series (Daily)")]
        public required Dictionary<string, DailyAdjustedDataRecord> DailyAdjustedDataRecords { get; set; }
    }

    class CustomDateTimeConverter : IsoDateTimeConverter
    {
        public CustomDateTimeConverter()
        {
            base.DateTimeFormat = "yyyy-mm-dd";
        }
    }
}
