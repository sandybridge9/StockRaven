using Shared.Clients.Models.MarketStatus;
using Shared.GenericHttpClient.Models;
using Shared.Resources.Queries;
using Shared.Wrappers;

namespace Shared.Resources
{
    public class GlobalMarketStatusClient
    {
        private readonly IHttpClientWrapper httpClientWrapper;

        public GlobalMarketStatusClient(IHttpClientWrapper httpClientWrapper)
        { 
            this.httpClientWrapper = httpClientWrapper;
        }

        public async Task<IList<GlobalMarketStatusRecord>> GetMarketStatus()
        {
            var httpResponse = await httpClientWrapper.PerformApiCallAsync<GlobalMarketStatusRecord>(MarketStatusUrls.MarketStatus);

            if(httpResponse.ResponseType == HttpResponseType.Success
                && httpResponse.Data is not null)
            {
                await Console.Out.WriteLineAsync(httpResponse.Data.Endpoint);

                foreach (var market in httpResponse.Data.Markets)
                {
                    await Console.Out.WriteLineAsync($"{market}");
                }

            }

            return new List<GlobalMarketStatusRecord>();
        }
    }
}
