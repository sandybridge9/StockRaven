namespace Shared.Clients.Models.Domain.DailyAdjustedTimeSeries
{
    public class DailyAdjustedTimeSeriesMetadata
    {
        public required string Symbol { get; set; }

        public required DateTime LastRefreshed { get; set; }

        public required string TimeZone { get; set; }
    }
}
