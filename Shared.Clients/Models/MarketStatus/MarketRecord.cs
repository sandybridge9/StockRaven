using System.Text.Json.Serialization;

namespace Shared.Clients.Models.MarketStatus
{
    public record MarketRecord
    {
        [JsonConstructor]
        public MarketRecord(
            string marketType,
            string region,
            string primaryExchanges,
            string localOpen,
            string localClose,
            string currentStatus,
            string notes)
        {
            MarketType = marketType;
            Region = region;
            PrimaryExchanges = primaryExchanges;
            LocalOpen = localOpen;
            LocalClose = localClose;
            CurrentStatus = currentStatus;
            Notes = notes;
        }

        public string MarketType { get; set; }

        public string Region { get; set; }

        public string PrimaryExchanges { get; set; }

        public string LocalOpen { get; set; }

        public string LocalClose { get; set; }

        public string CurrentStatus { get; set; }

        public string Notes { get; set; }
    }
}
