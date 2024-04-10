using Shared.GenericHttpClient.Clients;
using Shared.GenericHttpClient.Wrappers;
using Shared.Logic.ApiKey;

namespace StockRaven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoStuff();
        }

        static async void DoStuff()
        {
            var polygonApiKey = ApiKeyProvider.Instance.GetApiAccessKey(SupportedApiName.Polygon);

            Console.WriteLine(polygonApiKey);

            var httpClientWrapper = new HttpClientWrapper();
            var genericClient = new GenericClient(httpClientWrapper);

            var result = await genericClient.GetDataFromUrlAsync<object>("https://api.polygon.io/v2/aggs/ticker/AAPL/range/1/day/2024-04-01/2024-04-10?adjusted=true&sort=asc&limit=120&apiKey=Q7p8iAjwNNHCsRP7kpnPAXdkRxNnSRQ_");

            Console.WriteLine(result);
        }

        //private static void GlobalMarketStatusClientTest()
        //{
        //    var httpClientWrapper = new HttpClientWrapper();
        //    var genericClient = new GenericClient(httpClientWrapper);

        //    //seems to be working fine
        //    var globalMarketStatusClient = new GlobalMarketStatusClient(genericClient);
        //    var globalMarketStatus = globalMarketStatusClient.GetGlobalMarketStatusAsync().GetAwaiter().GetResult();

        //    if (globalMarketStatus != null)
        //    {
        //        foreach (var market in globalMarketStatus.Markets)
        //        {
        //            if (market != null)
        //            {
        //                Console.Out.WriteLine($"{market.MarketType}, {string.Join(", ", market.PrimaryExchanges)}, {market.Region}, {market.CurrentStatus}, {market.LocalOpen}, {market.LocalClose}");
        //            }
        //        }
        //    }
        //}

        //private static void GlobalQuoteClientTest()
        //{
        //    var httpClientWrapper = new HttpClientWrapper();
        //    var genericClient = new GenericClient(httpClientWrapper);

        //    //seems to be working fine
        //    var globalQuoteClient = new GlobalQuoteClient(genericClient);
        //    var globalQuote = globalQuoteClient.GetGlobalQuoteAsync().GetAwaiter().GetResult();

        //    if (globalQuote != null)
        //    {
        //        Console.Out.WriteLine($"{globalQuote.Symbol}, {globalQuote.Open}, {globalQuote.High}, {globalQuote.Low}, {globalQuote.Price}, {globalQuote.Volume}, {globalQuote.LatestTradingDay}, {globalQuote.PreviousClose}, {globalQuote.Change}, {globalQuote.ChangePercent}");
        //    }
        //}

        //private static void DailyTimeSeriesClientTest()
        //{
        //    var httpClientWrapper = new HttpClientWrapper();
        //    var genericClient = new GenericClient(httpClientWrapper);

        //    //seems to be working fine
        //    var dailyTimeSeriesClient = new DailyTimeSeriesClient(genericClient);
        //    var dailyTimeSeries = dailyTimeSeriesClient.GetDailyTimeSeriesAsync().GetAwaiter().GetResult();

        //    if (dailyTimeSeries != null)
        //    {
        //        Console.WriteLine(dailyTimeSeries);
        //    }
        //}

        //private static void IntradayTimeSeriesClientTest()
        //{
        //    var httpClientWrapper = new HttpClientWrapper();
        //    var genericClient = new GenericClient(httpClientWrapper);

        //    //seems to be working fine
        //    var intradayTimeSeriesClient = new IntradayTimeSeriesClient(genericClient);
        //    var intradayTimeSeries = intradayTimeSeriesClient.GetIntradayTimeSeriesAsync().GetAwaiter().GetResult();

        //    if (intradayTimeSeries != null)
        //    {
        //        Console.WriteLine(intradayTimeSeries);
        //    }
        //}
    }
}