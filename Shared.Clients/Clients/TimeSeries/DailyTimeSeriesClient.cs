using Shared.Clients.Mappers.TimeSeries;
using Shared.Clients.Models.Domain.TimeSeries.DailyTimeSeries;
using Shared.Clients.Models.Records.TimeSeries.DailyTimeSeries;
using Shared.Clients.Resources.UrlTemplates;
using Shared.GenericHttpClient.Clients;

namespace Shared.Clients.Clients.TimeSeries
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
                .GetDataFromUrlAsync<DailyTimeSeriesRecord>(TimeSeriesUrlTemplates.DailyTimeSeries);

            if (dailyTimeSeriesRecord != null)
            {
                return DailyTimeSeriesMapper.MapDailyTimeSeries(dailyTimeSeriesRecord);
            }

            return default;
        }
    }
}
