namespace Shared.Clients.Models.Domain.MarketStatus
{
    public class Market
    {
        public required string MarketType { get; set; }

        public required string Region { get; set; }

        public required List<string> PrimaryExchanges { get; set; }

        public required string LocalOpen { get; set; }

        public required string LocalClose { get; set; }

        public required string CurrentStatus { get; set; }

        public required string Notes { get; set; }
    }
}
