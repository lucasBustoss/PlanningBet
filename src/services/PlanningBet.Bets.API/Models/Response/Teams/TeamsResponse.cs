using System.Text.Json.Serialization;

namespace PlanningBet.Bets.API.Models.Response.Teams
{
    public class TeamsResponse
    {
        [JsonPropertyName("data")]
        public List<Team> Teams { get; set; }
    }
}
