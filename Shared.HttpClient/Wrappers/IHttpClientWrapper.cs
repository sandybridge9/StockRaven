﻿using Shared.GenericHttpClient.Models;

namespace Shared.Wrappers
{
    public interface IHttpClientWrapper
    {
        /// <summary>
        /// Performs a call using HTTP client to the provided URL
        /// </summary>
        /// <param name="url">URL to be used in an HTTP client call.</param>
        /// <returns></returns>
        public Task<HttpResponse<T>> PerformApiCallAsync<T>(string url) where T : class;
    }
}
