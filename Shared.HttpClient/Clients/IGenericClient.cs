namespace Shared.GenericHttpClient.Clients
{
    public interface IGenericClient
    {
        /// <summary>
        /// Gets data from the Url asynchronously.
        /// </summary>
        /// <param name="url">Url to use for getting data.</param>
        /// <returns>Data of selected type.</returns>
        public Task<T?> GetDataFromUrlAsync<T>(string url) where T : class;
    }
}
