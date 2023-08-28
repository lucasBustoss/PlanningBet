using System.Text.Json.Serialization;
using PlanningBet.Bets.API.Models.Response.ListClearedOrders.Bets;

namespace PlanningBet.Bets.API.Models.Response.ListClearedOrders
{
    public class ListClearedOrdersResponse
    {
        [JsonPropertyName("clearedOrders")]
        public List<BetsResponse> Orders { get; set; }
    }
}
