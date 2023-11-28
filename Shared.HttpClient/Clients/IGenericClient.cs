namespace Shared.GenericHttpClient.Clients
{
    public interface IGenericClient<T> where T : class
    {
        public Task<T?> GetDataFromUrlAsync(string url);
    }
}
