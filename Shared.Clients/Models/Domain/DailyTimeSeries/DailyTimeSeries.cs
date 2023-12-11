namespace Shared.Clients.Models.Domain.DailyAdjustedTimeSeries
{
    public class DailyTimeSeries
    {
        public required DailyTimeSeriesMetadata Metadata { get; set; }

        public required Dictionary<DateTime, DailyData> DailyData { get; set; }
    }
}
