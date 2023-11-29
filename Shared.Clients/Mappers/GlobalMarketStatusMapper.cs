using Shared.Clients.Models.Domain.MarketStatus;
using Shared.Clients.Models.Records.MarketStatus;

namespace Shared.Clients.Mappers
{
    public static class GlobalMarketStatusMapper
    {
        public static GlobalMarketStatus MapGlobalMarketStatus(GlobalMarketStatusRecord globalMarketStatusRecord)
        {
            var markets = new List<Market>();

            foreach(var marketRecord in globalMarketStatusRecord.MarketRecords)
            {
                markets.Add(new Market
                {
                    MarketType = marketRecord.MarketType,
                    Region = marketRecord.Region,
                    PrimaryExchanges = marketRecord.PrimaryExchanges.Split(", ").ToList(),
                    LocalOpen = marketRecord.LocalOpen,
                    LocalClose = marketRecord.LocalClose,
                    CurrentStatus = marketRecord.CurrentStatus,
                    Notes = marketRecord.Notes,
                });
            }

            return new GlobalMarketStatus
            {
                Markets = markets
            };
        }
    }
}
