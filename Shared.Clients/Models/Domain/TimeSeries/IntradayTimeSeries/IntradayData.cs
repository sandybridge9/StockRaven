namespace Shared.Clients.Models.Domain.TimeSeries.IntradayTimeSeries
{
    public class IntradayData
    {
        public required decimal Open { get; set; }

        public required decimal High { get; set; }

        public required decimal Low { get; set; }

        public required decimal Close { get; set; }

        public required int Volume { get; set; }
    }
}
