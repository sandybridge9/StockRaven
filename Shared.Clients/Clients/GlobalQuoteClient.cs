using Shared.Clients.Models.GlobalQuote;
using Shared.Clients.Models.MarketStatus;
using Shared.GenericHttpClient.Clients;
using Shared.Resources.Queries;

namespace Shared.Resources
{
    public class GlobalQuoteClient
    {
        private readonly IGenericClient genericClient;

        public GlobalQuoteClient(IGenericClient genericClient)
        { 
            this.genericClient = genericClient;
        }

        public async Task<GlobalQuoteRecord?> GetGlobalQuoteAsync()
        {
            return await genericClient.GetDataFromUrlAsync<GlobalQuoteRecord>(GlobalQuoteUrlTemplates.GlobalQuote);
        }
    }
}
