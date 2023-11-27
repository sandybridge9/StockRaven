﻿using Shared.GenericHttpClient.Models;
using Shared.Providers;
using System.Text.Json;

namespace Shared.Wrappers
{
    public class HttpClientWrapper : IHttpClientWrapper
    {
        //public async Task<Dictionary<string, object>> PerformApiCallAsync(string url)
        //{
        //    var usableUrl = ApiKeyProvider.Instance.AlterUrlWithApiAccessKey(url);

        //    using (var client = new HttpClient())
        //    {
        //        var response = await client.GetAsync(usableUrl);

        //        if (!response.IsSuccessStatusCode)
        //        {
        //            await Console.Out.WriteLineAsync($"API call failed: IsSuccessStatusCode false. URL: [{usableUrl}]");

        //            return new Dictionary<string, object>();
        //        }

        //        var responseContent = await response.Content.ReadAsStringAsync();

        //        if (string.IsNullOrWhiteSpace(responseContent))
        //        {
        //            await Console.Out.WriteLineAsync($"API call failed: response.Content is null, empty or whitespace. URL: [{usableUrl}]");

        //            return new Dictionary<string, object>();
        //        }

        //        var json_data = JsonSerializer.Deserialize<Dictionary<string, object>>(responseContent);

        //        return json_data?.Any() == true
        //            ? json_data
        //            : new Dictionary<string, object>();
        //    }
        //}

        public async Task<HttpResponse<T>> PerformApiCallAsync<T>(string url) where T : class
        {
            var usableUrl = ApiKeyProvider.Instance.AlterUrlWithApiAccessKey(url);
            var httpResponse = new HttpResponse<T>();

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(usableUrl);

                if (!response.IsSuccessStatusCode)
                {
                    await Console.Out.WriteLineAsync($"API call failed: IsSuccessStatusCode false. URL: [{usableUrl}]");

                    httpResponse.ResponseType = HttpResponseType.Failure;

                    return httpResponse;
                }

                var responseContent = await response.Content.ReadAsStringAsync();

                if (string.IsNullOrWhiteSpace(responseContent))
                {
                    await Console.Out.WriteLineAsync($"API call failed: response.Content is null, empty or whitespace. URL: [{usableUrl}]");

                    httpResponse.ResponseType = HttpResponseType.Empty;

                    return httpResponse;
                }

                try
                {
                    var jsonOptions = new JsonSerializerOptions();
                    jsonOptions.PropertyNameCaseInsensitive = true;
                    var data = JsonSerializer.Deserialize<T>(responseContent);

                    httpResponse.ResponseType = HttpResponseType.Success;
                    httpResponse.Data = data;

                    return httpResponse;
                }
                catch (JsonException)
                {
                    await Console.Out.WriteLineAsync($"JSON from response data could not be deserialized as {typeof(T)}. URL: [{usableUrl}]");

                    httpResponse.ResponseType = HttpResponseType.Undeserializable;

                    return httpResponse;
                }
            }
        }
    }
}
