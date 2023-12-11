namespace Shared.Clients.Resources.UrlTemplates
{
    public static class TimeSeriesUrlTemplates
    {
        public const string DailyTimeSeries = "https://www.alphavantage.co/query?function=TIME_SERIES_DAILY&symbol=__SYMBOL__&apikey=__APIKEY__";
        
        public const string IntradayTimeSeries = "https://www.alphavantage.co/query?function=TIME_SERIES_INTRADAY&symbol=__SYMBOL__&interval=__INTERVAL__&apikey=__APIKEY__";
    }
}
