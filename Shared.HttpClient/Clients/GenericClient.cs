using Shared.GenericHttpClient.Models;
using Shared.Wrappers;

namespace Shared.GenericHttpClient.Clients
{
    public class GenericClient : IGenericClient
    {
        private readonly IHttpClientWrapper httpClientWrapper;

        public GenericClient(IHttpClientWrapper httpClientWrapper)
        {
            this.httpClientWrapper = httpClientWrapper;
        }

        public async Task<T?> GetDataFromUrlAsync<T>(string url) where T : class
        {
            var httpResponse = await httpClientWrapper.PerformApiCallAsync<T>(url);

            if (httpResponse.ResponseType == HttpResponseType.Success
                && httpResponse.Data is not null)
            {
                return httpResponse.Data;
            }

            return default;
        }
    }
}
