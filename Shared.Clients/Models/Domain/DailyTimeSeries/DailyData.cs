namespace Shared.Clients.Models.Domain.DailyAdjustedTimeSeries
{
    public class DailyData
    {
        public required decimal Open { get; set; }

        public required decimal High { get; set; }

        public required decimal Low { get; set; }

        public required decimal Close { get; set; }

        public required int Volume { get; set; }
    }
}
