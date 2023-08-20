using System.Text.Json.Serialization;

namespace PlanningBet.Bets.API.Models.Response.ListClearedOrders
{
    public class BetsResponse
    {
        [JsonPropertyName("eventTypeId")]
        public string EventTypeId { get; set; }

        [JsonPropertyName("eventId")]
        public string EventId { get; set; }

        [JsonPropertyName("marketId")]
        public string MarketId { get; set; }
    }
}
