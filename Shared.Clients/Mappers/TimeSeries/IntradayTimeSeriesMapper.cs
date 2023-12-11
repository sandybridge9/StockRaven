using Shared.Clients.Models.Domain.TimeSeries.IntradayTimeSeries;
using Shared.Clients.Models.Records.TimeSeries.IntradayTimeSeries;
using System.Globalization;

namespace Shared.Clients.Mappers.TimeSeries
{
    public static class IntradayTimeSeriesMapper
    {
        public static IntradayTimeSeries MapIntradayTimeSeries(IntradayTimeSeriesRecord intradayTimeSeriesRecord)
        {
            var metadata = new IntradayTimeSeriesMetadata
            {
                Symbol = intradayTimeSeriesRecord.MetadataRecord.Symbol,
                LastRefreshed = DateTime.Parse(intradayTimeSeriesRecord.MetadataRecord.LastRefreshed),
                Interval = intradayTimeSeriesRecord.MetadataRecord.Interval,
                TimeZone = intradayTimeSeriesRecord.MetadataRecord.TimeZone,
            };

            var intradayData = new Dictionary<DateTime, IntradayData>();

            foreach (var intradayDataRecord in intradayTimeSeriesRecord.IntradayDataRecords)
            {
                intradayData.Add(
                    DateTime.Parse(intradayDataRecord.Key),
                    new IntradayData
                    {
                        Open = decimal.Parse(intradayDataRecord.Value.Open, CultureInfo.InvariantCulture),
                        High = decimal.Parse(intradayDataRecord.Value.High, CultureInfo.InvariantCulture),
                        Low = decimal.Parse(intradayDataRecord.Value.Low, CultureInfo.InvariantCulture),
                        Close = decimal.Parse(intradayDataRecord.Value.Close, CultureInfo.InvariantCulture),
                        Volume = int.Parse(intradayDataRecord.Value.Volume),
                    });
            }

            return new IntradayTimeSeries
            {
                Metadata = metadata,
                IntradayData = intradayData
            };
        }
    }
}
