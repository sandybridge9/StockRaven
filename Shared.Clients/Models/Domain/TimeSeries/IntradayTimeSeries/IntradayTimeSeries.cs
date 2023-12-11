namespace Shared.Clients.Models.Domain.TimeSeries.IntradayTimeSeries
{
    public class IntradayTimeSeries
    {
        public required IntradayTimeSeriesMetadata Metadata { get; set; }

        public required Dictionary<DateTime, IntradayData> IntradayData { get; set; }
    }
}
