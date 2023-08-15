using System.Text.Json.Serialization;

namespace PlanningBet.Stats.API.Models.ApiResponse.Teams.TeamsResponse
{
    public class TeamResponse
    {
        [JsonPropertyName("id")]
        public int TeamId { get; set; }

        [JsonPropertyName("name")]
        public string TeamName { get; set; }

        [JsonPropertyName("cleanName")]
        public string TeamCleanName { get; set; }

        [JsonPropertyName("country")]
        public string TeamCountry { get; set; }

        [JsonPropertyName("image")]
        public string TeamImageUrl { get; set; }

        [JsonPropertyName("competition_id")]
        public int TeamCompetitionId { get; set; }

        [JsonPropertyName("season")]
        public string TeamSeason { get; set; }

        [JsonPropertyName("season_format")]
        public string TeamCompetitionType { get; set; }

        [JsonPropertyName("stats")]
        public TeamStatsResponse TeamStats { get; set; }
    }
}
