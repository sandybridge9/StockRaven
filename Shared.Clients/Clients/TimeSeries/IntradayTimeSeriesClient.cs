using Shared.Clients.Mappers.TimeSeries;
using Shared.Clients.Models.Domain.TimeSeries.IntradayTimeSeries;
using Shared.Clients.Models.Records.TimeSeries.IntradayTimeSeries;
using Shared.Clients.Resources.UrlTemplates;
using Shared.GenericHttpClient.Clients;

namespace Shared.Clients.Clients.TimeSeries
{
    public class IntradayTimeSeriesClient
    {
        private readonly IGenericClient genericClient;

        public IntradayTimeSeriesClient(IGenericClient genericClient)
        {
            this.genericClient = genericClient;
        }

        public async Task<IntradayTimeSeries?> GetIntradayTimeSeriesAsync()
        {
            var intradayTimeSeriesRecord = await genericClient
                .GetDataFromUrlAsync<IntradayTimeSeriesRecord>(TimeSeriesUrlTemplates.IntradayTimeSeries);

            if (intradayTimeSeriesRecord != null)
            {
                return IntradayTimeSeriesMapper.MapIntradayTimeSeries(intradayTimeSeriesRecord);
            }

            return default;
        }
    }
}
