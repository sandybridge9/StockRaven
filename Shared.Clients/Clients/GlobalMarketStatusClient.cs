using Shared.Clients.Models.MarketStatus;
using Shared.GenericHttpClient.Clients;
using Shared.Resources.Queries;

namespace Shared.Resources
{
    public class GlobalMarketStatusClient
    {
        private readonly IGenericClient genericClient;

        public GlobalMarketStatusClient(IGenericClient genericClient)
        { 
            this.genericClient = genericClient;
        }

        public async Task<GlobalMarketStatusRecord?> GetGlobalMarketStatusAsync()
        {
            return await genericClient.GetDataFromUrlAsync<GlobalMarketStatusRecord>(MarketStatusUrlTemplates.MarketStatus);
        }
    }
}
