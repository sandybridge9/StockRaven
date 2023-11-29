namespace Shared.Clients.Models.Domain.DailyAdjustedTimeSeries
{
    public class DailyAdjustedTimeSeries
    {
        public required DailyAdjustedTimeSeriesMetadata Metadata { get; set; }

        public required List<DailyAdjustedData> DailyTimeSeries { get; set; }
    }
}
