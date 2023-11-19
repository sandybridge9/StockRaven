using Shared.Models;
using Shared.Wrappers;

namespace Shared.Resources
{
    public class MarketStatusClient
    {
        private readonly IHttpClientWrapper httpClientWrapper;

        public MarketStatusClient(IHttpClientWrapper httpClientWrapper)
        { 
            this.httpClientWrapper = httpClientWrapper;
        }

        public async Task<IList<MarketStatus>> GetMarketStatus()
        {
            const string url = "https://www.alphavantage.co/query?function=MARKET_STATUS&apikey=__APIKEY__";

            var data = await httpClientWrapper.PerformApiCallAsync(url);

            foreach (var row in data)
            {
                await Console.Out.WriteLineAsync(row.ToString());
            }

            return new List<MarketStatus>();
        }
    }
}
