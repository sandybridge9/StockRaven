using Shared.Clients.Mappers;
using Shared.Clients.Models.Domain.DailyAdjustedTimeSeries;
using Shared.Clients.Models.Records.DailyTimeSeries;
using Shared.GenericHttpClient.Clients;
using Shared.Resources.Queries;

namespace Shared.Resources
{
    public class DailyTimeSeriesClient
    {
        private readonly IGenericClient genericClient;

        public DailyTimeSeriesClient(IGenericClient genericClient)
        { 
            this.genericClient = genericClient;
        }

        public async Task<DailyTimeSeries?> GetDailyTimeSeriesAsync()
        {
            var dailyTimeSeriesRecord = await genericClient
                .GetDataFromUrlAsync<DailyTimeSeriesRecord>(DailyTimeSeriesUrlTemplates.DailyTimeSeries);

            if (dailyTimeSeriesRecord != null)
            {
                return DailyTimeSeriesMapper.MapDailyTimeSeries(dailyTimeSeriesRecord);
            }

            return default;
        }
    }
}
