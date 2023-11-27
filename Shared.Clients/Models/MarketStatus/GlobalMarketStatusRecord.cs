using System.Text.Json.Serialization;

namespace Shared.Clients.Models.MarketStatus
{
    public class GlobalMarketStatusRecord
    {
        [JsonConstructor]
        public GlobalMarketStatusRecord(
            string endpoint,
            MarketRecord[] markets)
        {
            Endpoint = endpoint;
            Markets = markets;
        }

        public string Endpoint { get; set; }

        //public IList<MarketRecord> Markets { get; set; }

        public MarketRecord[] Markets { get; set; }
    }
}
