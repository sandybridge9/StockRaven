namespace Shared.Clients.Models.Domain.TimeSeries.DailyTimeSeries
{
    public class DailyTimeSeriesMetadata
    {
        public required string Symbol { get; set; }

        public required DateTime LastRefreshed { get; set; }

        public required string TimeZone { get; set; }
    }
}
