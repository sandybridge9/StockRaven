namespace Shared.Providers
{
    public sealed class ApiKeyProvider
    {
        private ApiKeyProvider() { }

        static ApiKeyProvider() { }

        private static ApiKeyProvider instance = new ApiKeyProvider();

        public static ApiKeyProvider Instance
        {
            get
            {
                return instance;
            }
        }

        private const string ApiKeyLocationFolder = @"D:\Projects\Locations\ApiKeyLocation.txt";

        private string apiAccessKey = "";

        public string GetApiAccessKey()
        {
            if(!string.IsNullOrEmpty(apiAccessKey))
            {
                return apiAccessKey;
            }

            apiAccessKey = File.ReadAllText(File.ReadAllText(ApiKeyLocationFolder));

            return apiAccessKey;
        }
    }
}