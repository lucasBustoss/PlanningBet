using System.Text.Json.Serialization;

namespace PlanningBet.Bets.API.Models.Response.ListClearedOrders.Events
{
    public class EventsResponse
    {
        [JsonPropertyName("eventId")]
        public string EventId { get; set; }

        [JsonPropertyName("itemDescription")]
        public EventItemDescription MatchDescription { get; set; }

        [JsonPropertyName("settledDate")]
        public DateTime Date { get; set; }

        [JsonPropertyName("betCount")]
        public int BetCount { get; set; }

        [JsonPropertyName("commission")]
        public decimal Commission { get; set; }

        [JsonPropertyName("profit")]
        public decimal Profit { get; set; }

    }
}
