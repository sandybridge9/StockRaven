using Shared.Clients.Mappers;
using Shared.Clients.Models.Domain.MarketStatus;
using Shared.Clients.Models.Records.MarketStatus;
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

        public async Task<GlobalMarketStatus?> GetGlobalMarketStatusAsync()
        {
            var globalMarketStatusRecord = await genericClient
                .GetDataFromUrlAsync<GlobalMarketStatusRecord>(MarketStatusUrlTemplates.MarketStatus);

            if(globalMarketStatusRecord != null)
            {
                return GlobalMarketStatusMapper.MapGlobalMarketStatus(globalMarketStatusRecord);
            }

            return default;
        }
    }
}
