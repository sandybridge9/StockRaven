using Shared.Models;
using Shared.Providers;
using System.Text.Json;

namespace Shared.Resources
{
    public class MarketStatusClient
    {
        public async static Task<IList<MarketStatus>> GetMarketStatus()
        {
            var apiKey = ApiKeyProvider.Instance.GetApiAccessKey();

            string queryUrl = $@"https://www.alphavantage.co/query?function=MARKET_STATUS&apikey={apiKey}";

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(queryUrl);

                if (!response.IsSuccessStatusCode)
                {
                    await Console.Out.WriteLineAsync("API call failed: IsSuccessStatusCode false");

                    return new List<MarketStatus>();
                }

                var responseContent = await response.Content.ReadAsStringAsync();

                if (string.IsNullOrWhiteSpace(responseContent))
                {
                    await Console.Out.WriteLineAsync("API call failed: response.Content is null, empty or whitespace");

                    return new List<MarketStatus>();
                }

                var json_data = JsonSerializer.Deserialize<Dictionary<string, object>>(responseContent);

                if (json_data?.Any() != true)
                {
                    await Console.Out.WriteLineAsync("API call failed: response.Content couldn't be deserialized.");

                    return new List<MarketStatus>();
                }

                foreach (var data in json_data)
                {
                    await Console.Out.WriteLineAsync(data.ToString());
                }

                return new List<MarketStatus>();
            }
        }
    }
}
