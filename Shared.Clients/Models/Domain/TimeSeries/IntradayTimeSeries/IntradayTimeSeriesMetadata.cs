namespace Shared.Clients.Models.Domain.TimeSeries.IntradayTimeSeries
{
    public class IntradayTimeSeriesMetadata
    {
        public required string Symbol { get; set; }

        public required DateTime LastRefreshed { get; set; }

        public required string Interval { get; set; }

        public required string TimeZone { get; set; }
    }
}
