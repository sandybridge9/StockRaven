using Shared.Models;
using Shared.Resources.Queries;
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
            var data = await httpClientWrapper.PerformApiCallAsync(MarketStatusQueries.MarketStatusUrl);

            foreach (var row in data)
            {
                await Console.Out.WriteLineAsync(row.ToString());
            }

            return new List<MarketStatus>();
        }
    }
}
