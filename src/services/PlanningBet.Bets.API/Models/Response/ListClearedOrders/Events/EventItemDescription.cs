using System.Text.Json.Serialization;

namespace PlanningBet.Bets.API.Models.Response.ListClearedOrders.Events
{
    public class EventItemDescription
    {
        [JsonPropertyName("eventDesc")]
        public string EventDescription { get; set; }
    }
}
