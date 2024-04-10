using Shared.GenericHttpClient.Models;
using Shared.GenericHttpClient.Wrappers;

namespace Shared.GenericHttpClient.Clients
{
    public class GenericClient(IHttpClientWrapper httpClientWrapper) : IGenericClient
    {
        public async Task<T?> GetDataFromUrlAsync<T>(string url) where T : class
        {
            var httpResponse = await httpClientWrapper.PerformApiCallAsync<T>(url);

            return httpResponse is { ResponseType: HttpResponseType.Success, Data: not null }
                ? httpResponse.Data
                : default;
        }
    }
}
