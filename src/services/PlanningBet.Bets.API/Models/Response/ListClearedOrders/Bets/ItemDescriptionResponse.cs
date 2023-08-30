using System.Text.Json.Serialization;

namespace PlanningBet.Bets.API.Models.Response.ListClearedOrders.Bets
{
    public class ItemDescriptionResponse
    {
        [JsonPropertyName("eventDesc")]
        public string EventDescription { get; set; }

        [JsonPropertyName("marketDesc")]
        public string MarketDescription { get; set; }

        [JsonPropertyName("marketType")]
        public string MarketType { get; set; }

        [JsonPropertyName("runnerDesc")]
        public string PickDescription { get; set; }
    }
}
