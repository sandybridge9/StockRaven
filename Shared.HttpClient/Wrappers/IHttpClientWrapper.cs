using Shared.GenericHttpClient.Models;

namespace Shared.GenericHttpClient.Wrappers
{
    public interface IHttpClientWrapper
    {
        /// <summary>
        /// Performs a call using HTTP client to the provided URL.
        /// </summary>
        /// <param name="urlTemplate">URL template to be used in an HTTP client call.</param>
        /// <returns>HttpResponse containing response type and data.</returns>
        public Task<HttpResponse<T>> PerformApiCallAsync<T>(string urlTemplate) where T : class;
    }
}
