namespace Shared.Logic.ApiKey
{
    public sealed class ApiKeyProvider
    {
        private ApiKeyProvider() { }

        private static ApiKeyProvider instance;

        private static readonly object SyncRoot = new();

        public static ApiKeyProvider Instance
        {
            get
            {
               lock (SyncRoot)
               {
                   instance ??= new ApiKeyProvider();
               }

               return instance;
            }
        }

        // TODO: store location folder in appSettings
        private const string ApiKeyFolder = @"D:\Projects\ApiKeys";

        private readonly Dictionary<SupportedApiName, string> apiKeys = new();

        public string GetApiAccessKey(SupportedApiName apiName)
        {
            if (apiKeys.TryGetValue(apiName, out var apiKey))
            {
                return apiKey;
            }

            switch (apiName)
            {
                case SupportedApiName.Polygon:
                    var polygonApiKey = File.ReadAllText($"{ApiKeyFolder}\\PolygonIO_API_Key.txt");

                    apiKeys.Add(apiName, polygonApiKey);

                    return polygonApiKey;
                default:
                    throw new ArgumentException($"API Key getting not implemented for {apiName}");
            }
        }
    }
}