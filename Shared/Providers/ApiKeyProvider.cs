namespace Shared.Providers
{
    public sealed class ApiKeyProvider
    {
        private ApiKeyProvider() { }

        static ApiKeyProvider() { }

        private static ApiKeyProvider instance;

        private static object syncRoot = new object();

        public static ApiKeyProvider Instance
        {
            get
            {
                if(instance == null)
                {
                    lock(syncRoot)
                    {
                        if(instance == null)
                        {
                            instance = new ApiKeyProvider();
                        }
                    }
                }

                return instance;
            }
        }

        private const string ApiKeyLocationFolder = @"D:\Projects\Locations\ApiKeyLocation.txt";

        private const string ApiKeyReplaceableString = "__APIKEY__";

        private string apiAccessKey = "";

        public string AlterUrlWithApiAccessKey(string url)
        {
            return url.Replace(ApiKeyReplaceableString, GetApiAccessKey());
        }

        private string GetApiAccessKey()
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