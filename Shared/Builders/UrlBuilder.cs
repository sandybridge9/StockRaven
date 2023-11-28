using Shared.Providers;

namespace Shared.Logic.NewFolder
{
    public static class UrlBuilder
    {
        private const string ApiKeyReplaceableString = "__APIKEY__";
        private const string SymbolReplaceableString = "__SYMBOL__";

        public static string BuildUrl(string urlTemplate)
        {
            return urlTemplate
                .Replace(ApiKeyReplaceableString, ApiKeyProvider.Instance.GetApiAccessKey())
                .Replace(SymbolReplaceableString, "IBM");
        }
    }
}
