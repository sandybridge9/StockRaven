using Shared.GenericHttpClient.Models;
using Shared.Wrappers;

namespace Shared.GenericHttpClient.Clients
{
    public class GenericClient<T> : IGenericClient<T> where T : class
    {
        private readonly IHttpClientWrapper httpClientWrapper;

        public GenericClient(IHttpClientWrapper httpClientWrapper)
        {
            this.httpClientWrapper = httpClientWrapper;
        }

        public async Task<T?> GetDataFromUrlAsync(string url)
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
