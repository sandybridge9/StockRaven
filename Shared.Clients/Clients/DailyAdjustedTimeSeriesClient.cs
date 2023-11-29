using Shared.Clients.Mappers;
using Shared.Clients.Models.Domain.DailyAdjustedTimeSeries;
using Shared.Clients.Models.Records.DailyAdjustedTimeSeries;
using Shared.GenericHttpClient.Clients;
using Shared.Resources.Queries;

namespace Shared.Resources
{
    public class DailyAdjustedTimeSeriesClient
    {
        private readonly IGenericClient genericClient;

        public DailyAdjustedTimeSeriesClient(IGenericClient genericClient)
        { 
            this.genericClient = genericClient;
        }

        public async Task<DailyAdjustedTimeSeries?> GetDailyAdjustedTimeSeriesAsync()
        {
            var dailyAdjustedTimeSeriesRecord = await genericClient
                .GetDataFromUrlAsync<DailyAdjustedTimeSeriesRecord>(GlobalQuoteUrlTemplates.GlobalQuote);

            if (dailyAdjustedTimeSeriesRecord != null)
            {
                //return GlobalQuoteMapper.MapGlobalQuote(globalQuoteRecord);
            }

            return default;
        }
    }
}
