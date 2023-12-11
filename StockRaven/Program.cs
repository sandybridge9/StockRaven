using Shared.GenericHttpClient.Clients;
using Shared.Resources;
using Shared.Wrappers;

namespace StockRaven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoStuff();
        }

        static void DoStuff()
        {
            //GlobalMarketStatusClientTest();

            //GlobalQuoteClientTest();

            DailyTimeSeriesClientTest();

            //JsonDeserializationTests();
        }

        private static void GlobalMarketStatusClientTest()
        {
            var httpClientWrapper = new HttpClientWrapper();
            var genericClient = new GenericClient(httpClientWrapper);

            //seems to be working fine
            var globalMarketStatusClient = new GlobalMarketStatusClient(genericClient);
            var globalMarketStatus = globalMarketStatusClient.GetGlobalMarketStatusAsync().GetAwaiter().GetResult();

            if (globalMarketStatus != null)
            {
                foreach (var market in globalMarketStatus.Markets)
                {
                    if (market != null)
                    {
                        Console.Out.WriteLine($"{market.MarketType}, {string.Join(", ", market.PrimaryExchanges)}, {market.Region}, {market.CurrentStatus}, {market.LocalOpen}, {market.LocalClose}");
                    }
                }
            }
        }

        private static void GlobalQuoteClientTest()
        {
            var httpClientWrapper = new HttpClientWrapper();
            var genericClient = new GenericClient(httpClientWrapper);

            //seems to be working fine
            var globalQuoteClient = new GlobalQuoteClient(genericClient);
            var globalQuote = globalQuoteClient.GetGlobalQuoteAsync().GetAwaiter().GetResult();

            if (globalQuote != null)
            {
                Console.Out.WriteLine($"{globalQuote.Symbol}, {globalQuote.Open}, {globalQuote.High}, {globalQuote.Low}, {globalQuote.Price}, {globalQuote.Volume}, {globalQuote.LatestTradingDay}, {globalQuote.PreviousClose}, {globalQuote.Change}, {globalQuote.ChangePercent}");
            }
        }

        private static void DailyTimeSeriesClientTest()
        {
            var httpClientWrapper = new HttpClientWrapper();
            var genericClient = new GenericClient(httpClientWrapper);

            //seems to be working fine
            var dailyTimeSeriesClient = new DailyTimeSeriesClient(genericClient);
            var dailyTimeSeries = dailyTimeSeriesClient.GetDailyTimeSeriesAsync().GetAwaiter().GetResult();

            if (dailyTimeSeries != null)
            {
                Console.WriteLine(dailyTimeSeries);
            }
        }
    }
}