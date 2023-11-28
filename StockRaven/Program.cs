using Shared.Clients.Models.MarketStatus;
using Shared.GenericHttpClient.Clients;
using Shared.Resources;
using Shared.Wrappers;

namespace StockRaven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var htw = new HttpClientWrapper();
            var gc = new GenericClient<GlobalMarketStatusRecord>(htw);
            var gmsc = new GlobalMarketStatusClient(gc);

            var result = gmsc.GetGlobalMarketStatus().GetAwaiter().GetResult();

            if(result != null)
            {
                Console.Out.WriteLine(result.Endpoint);

                foreach (var market in result.Markets)
                {
                    if (market != null)
                    {
                        Console.Out.WriteLine($"{market.MarketType}, {market.PrimaryExchanges}, {market.Region}, {market.CurrentStatus}, {market.LocalOpen}, {market.LocalClose}");
                    }
                }
            }
        }
    }
}