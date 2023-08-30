using System.Text.Json.Serialization;

namespace PlanningBet.Bets.API.Models.Response.Teams
{
    public class Team
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("cleanName")]
        public string CleanName { get; set; }
    }
}
