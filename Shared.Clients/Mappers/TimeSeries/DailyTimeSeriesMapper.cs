using Shared.Clients.Models.Domain.TimeSeries.DailyTimeSeries;
using Shared.Clients.Models.Records.TimeSeries.DailyTimeSeries;
using System.Globalization;

namespace Shared.Clients.Mappers.TimeSeries
{
    public static class DailyTimeSeriesMapper
    {
        public static DailyTimeSeries MapDailyTimeSeries(DailyTimeSeriesRecord dailyTimeSeriesRecord)
        {
            var metadata = new DailyTimeSeriesMetadata
            {
                Symbol = dailyTimeSeriesRecord.MetadataRecord.Symbol,
                LastRefreshed = DateTime.Parse(dailyTimeSeriesRecord.MetadataRecord.LastRefreshed),
                TimeZone = dailyTimeSeriesRecord.MetadataRecord.TimeZone,
            };

            var dailyData = new Dictionary<DateTime, DailyData>();

            foreach (var dailyDataRecord in dailyTimeSeriesRecord.DailyDataRecords)
            {
                dailyData.Add(
                    dailyDataRecord.Key,
                    new DailyData
                    {
                        Open = decimal.Parse(dailyDataRecord.Value.Open, CultureInfo.InvariantCulture),
                        High = decimal.Parse(dailyDataRecord.Value.High, CultureInfo.InvariantCulture),
                        Low = decimal.Parse(dailyDataRecord.Value.Low, CultureInfo.InvariantCulture),
                        Close = decimal.Parse(dailyDataRecord.Value.Close, CultureInfo.InvariantCulture),
                        Volume = int.Parse(dailyDataRecord.Value.Volume),
                    });
            }

            return new DailyTimeSeries
            {
                Metadata = metadata,
                DailyData = dailyData
            };
        }
    }
}
