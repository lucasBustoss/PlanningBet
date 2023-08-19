using System.Text.Json.Serialization;

namespace PlanningBet.Stats.API.Models.ApiResponse.Leagues.LeagueMatches
{
    public class LeagueMatchesResponse
    {
        [JsonPropertyName("id")]
        public int MatchId { get; set; }

        [JsonPropertyName("roundID")]
        public int RoundId { get; set; }

        [JsonPropertyName("date_unix")]
        public long Timestamp { get; set; }

        [JsonPropertyName("competition_id")]
        public int CompetitionId { get; set; }

        [JsonPropertyName("status")]
        public string MatchStatus { get; set; }

        [JsonPropertyName("homeID")]
        public int TeamHomeId { get; set; }

        [JsonPropertyName("home_name")]
        public string TeamHomeName { get; set; }

        [JsonPropertyName("home_image")]
        public string TeamHomeLogo { get; set; }

        [JsonPropertyName("homeGoalCount")]
        public int TeamHomeGoals { get; set; }

        [JsonPropertyName("awayID")]
        public int TeamAwayId { get; set; }

        [JsonPropertyName("away_name")]
        public string TeamAwayName { get; set; }

        [JsonPropertyName("away_image")]
        public string TeamAwayLogo { get; set; }

        [JsonPropertyName("awayGoalCount")]
        public int TeamAwayGoals { get; set; }
    }
}
