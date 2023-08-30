using System.Text.Json.Serialization;
using PlanningBet.Bets.API.Models.Response.ListClearedOrders.Bets;

namespace PlanningBet.Bets.API.Models.Response.ListClearedOrders
{
    public class ListClearedOrdersResponse<T>
    {
        [JsonPropertyName("clearedOrders")]
        public List<T> Orders { get; set; }
    }
}
