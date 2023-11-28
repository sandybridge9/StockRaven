using Shared.Clients.Models.MarketStatus;
using Shared.GenericHttpClient.Clients;
using Shared.GenericHttpClient.Models;
using Shared.Resources.Queries;
using Shared.Wrappers;

namespace Shared.Resources
{
    public class GlobalMarketStatusClient
    {
        private readonly IGenericClient<GlobalMarketStatus> genericClient;

        public GlobalMarketStatusClient(IGenericClient<GlobalMarketStatus> genericClient)
        { 
            this.genericClient = genericClient;
        }

        public async Task<IList<GlobalMarketStatus>> GetMarketStatus()
        {
            var httpResponse = await httpClientWrapper.PerformApiCallAsync<GlobalMarketStatus>(MarketStatusUrls.MarketStatus);

            if(httpResponse.ResponseType == HttpResponseType.Success
                && httpResponse.Data is not null)
            {
                await Console.Out.WriteLineAsync(httpResponse.Data.Endpoint);

                foreach (var market in httpResponse.Data.Markets)
                {
                    if(market != null)
                    {
                        await Console.Out.WriteLineAsync($"{market.MarketType}, {market.PrimaryExchanges}, {market.Region}, {market.CurrentStatus}, {market.LocalClose}, {market.LocalOpen}");
                    }
                }

            }

            return new List<GlobalMarketStatus>();
        }
    }
}
