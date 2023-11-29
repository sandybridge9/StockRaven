namespace Shared.Clients.Models.Domain.DailyAdjustedTimeSeries
{
    public class DailyAdjustedData
    {
        public required decimal Open { get; set; }

        public required decimal High { get; set; }

        public required decimal Low { get; set; }

        public required decimal Close { get; set; }

        public required decimal AdjustedClose { get; set; }

        public required int Volume { get; set; }

        public required decimal DividentAmount { get; set; }

        public required decimal SplitCoefficient { get; set; }
    }
}
