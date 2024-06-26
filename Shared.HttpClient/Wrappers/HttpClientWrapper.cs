﻿using System.Text.Json;
using Shared.GenericHttpClient.Models;
using Shared.Logic.Builders;

namespace Shared.GenericHttpClient.Wrappers
{
    public class HttpClientWrapper : IHttpClientWrapper
    {
        public async Task<HttpResponse<T>> PerformApiCallAsync<T>(string urlTemplate) where T : class
        {
            var usableUrl = UrlBuilder.BuildUrl(urlTemplate);

            var httpResponse = new HttpResponse<T>();

            using var client = new HttpClient();

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
                var data = JsonSerializer.Deserialize<T>(responseContent);

                httpResponse.ResponseType = HttpResponseType.Success;
                httpResponse.Data = data;

                return httpResponse;
            }
            catch (JsonException jsonException)
            {
                await Console.Out.WriteLineAsync($"JSON from response data could not be deserialized as {typeof(T)}. URL: [{usableUrl}] \n {jsonException}");

                httpResponse.ResponseType = HttpResponseType.Undeserializable;

                return httpResponse;
            }
        }
    }
}
