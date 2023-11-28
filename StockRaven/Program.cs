using Shared.Resources;
using Shared.Wrappers;

namespace StockRaven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var htw = new HttpClientWrapper();
            var gmsc = new GlobalMarketStatusClient(htw);

            var result = gmsc.GetMarketStatus().GetAwaiter().GetResult();
        }
    }
}