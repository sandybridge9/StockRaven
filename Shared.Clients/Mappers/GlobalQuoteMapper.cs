using System.Globalization;
using Shared.Clients.Models.Domain.GlobalQuote;
using Shared.Clients.Models.Records.GlobalQuote;

namespace Shared.Clients.Mappers
{
    public static class GlobalQuoteMapper
    {
        public static GlobalQuote MapGlobalQuote(GlobalQuoteRecord globalQuoteRecord) =>
            new GlobalQuote
            {
                Symbol = globalQuoteRecord.QuoteRecord.Symbol,
                Open = decimal.Parse(globalQuoteRecord.QuoteRecord.Open, CultureInfo.InvariantCulture),
                High = decimal.Parse(globalQuoteRecord.QuoteRecord.High, CultureInfo.InvariantCulture),
                Low = decimal.Parse(globalQuoteRecord.QuoteRecord.Low, CultureInfo.InvariantCulture),
                Price = decimal.Parse(globalQuoteRecord.QuoteRecord.Price, CultureInfo.InvariantCulture),
                Volume = int.Parse(globalQuoteRecord.QuoteRecord.Volume),
                LatestTradingDay = DateTime.Parse(globalQuoteRecord.QuoteRecord.LatestTradingDay),
                PreviousClose = decimal.Parse(globalQuoteRecord.QuoteRecord.PreviousClose, CultureInfo.InvariantCulture),
                Change = decimal.Parse(globalQuoteRecord.QuoteRecord.Change, CultureInfo.InvariantCulture),
                ChangePercent = decimal.Parse(globalQuoteRecord.QuoteRecord.ChangePercent.Replace('%', ' '), CultureInfo.InvariantCulture)
            };
    }
}
