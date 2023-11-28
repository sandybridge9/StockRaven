namespace Shared.GenericHttpClient.Clients
{
    public interface IGenericClient<T> where T : class
    {
        /// <summary>
        /// Gets data from the Url asynchronously.
        /// </summary>
        /// <param name="url">Url to use for getting data.</param>
        /// <returns>Data of selected type.</returns>
        public Task<T?> GetDataFromUrlAsync(string url);
    }
}
