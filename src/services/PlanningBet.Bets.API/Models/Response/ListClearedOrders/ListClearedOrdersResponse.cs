using System.Text.Json.Serialization;

namespace PlanningBet.Bets.API.Models.Response.ListClearedOrders
{
    public class ListClearedOrdersResponse
    {
        [JsonPropertyName("clearedOrders")]
        public List<BetsResponse> Bets { get; set; }
    }
}
