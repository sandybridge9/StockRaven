using Shared.Clients.Models.MarketStatus;
using Shared.GenericHttpClient.Clients;
using Shared.Resources.Queries;

namespace Shared.Resources
{
    public class GlobalMarketStatusClient
    {
        private readonly IGenericClient<GlobalMarketStatusRecord> genericClient;

        public GlobalMarketStatusClient(IGenericClient<GlobalMarketStatusRecord> genericClient)
        { 
            this.genericClient = genericClient;
        }

        public async Task<GlobalMarketStatusRecord?> GetGlobalMarketStatus()
        {
            return await genericClient.GetDataFromUrlAsync(MarketStatusUrlTemplates.MarketStatus);
        }
    }
}
