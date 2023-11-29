namespace Shared.Clients.Models.Domain.GlobalQuote
{
    public class GlobalQuote
    {
        public required string Symbol { get; set; }

        public required decimal Open { get; set; }

        public required decimal High { get; set; }

        public required decimal Low { get; set; }

        public required decimal Price { get; set; }

        public required int Volume { get; set; }

        public required DateTime LatestTradingDay { get; set; }

        public required decimal PreviousClose { get; set; }

        public required decimal Change { get; set; }

        public required decimal ChangePercent { get; set; }
    }
}
