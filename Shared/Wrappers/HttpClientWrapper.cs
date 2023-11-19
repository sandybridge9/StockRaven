using Shared.Providers;
using System.Text.Json;

namespace Shared.Wrappers
{
    public class HttpClientWrapper : IHttpClientWrapper
    {
        private const string ApiKeyReplaceableString = "__APIKEY__";

        public async Task<Dictionary<string, object>> PerformApiCallAsync(string url)
        {
            var apiKey = ApiKeyProvider.Instance.GetApiAccessKey();
            var query = url.Replace(ApiKeyReplaceableString, apiKey);

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(query);

                if (!response.IsSuccessStatusCode)
                {
                    await Console.Out.WriteLineAsync($"API call failed: IsSuccessStatusCode false. URL: [{url}]");

                    return new Dictionary<string, object>();
                }

                var responseContent = await response.Content.ReadAsStringAsync();

                if (string.IsNullOrWhiteSpace(responseContent))
                {
                    await Console.Out.WriteLineAsync($"API call failed: response.Content is null, empty or whitespace. URL: [{url}]");

                    return new Dictionary<string, object>();
                }

                var json_data = JsonSerializer.Deserialize<Dictionary<string, object>>(responseContent);

                return json_data?.Any() == true
                    ? json_data
                    : new Dictionary<string, object>();
            }
        }
    }
}
