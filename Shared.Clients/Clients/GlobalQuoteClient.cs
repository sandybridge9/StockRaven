using Shared.Clients.Mappers;
using Shared.Clients.Models.Domain.GlobalQuote;
using Shared.Clients.Models.Records.GlobalQuote;
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

        public async Task<GlobalQuote?> GetGlobalQuoteAsync()
        {
            var globalQuoteRecord = await genericClient
                .GetDataFromUrlAsync<GlobalQuoteRecord>(GlobalQuoteUrlTemplates.GlobalQuote);

            if (globalQuoteRecord != null)
            {
                return GlobalQuoteMapper.MapGlobalQuote(globalQuoteRecord);
            }

            return default;
        }
    }
}
