using System.Text.Json.Serialization;

namespace PlanningBet.Stats.API.Models.ApiResponse.Leagues.LeagueStanding
{
    public class LeagueStandingRequest
    {
        [JsonPropertyName("all_matches_table_overall")]
        public List<LeagueStandingTeamRequest> TableOverall { get; set; }

        [JsonPropertyName("all_matches_table_home")]
        public List<LeagueStandingTeamRequest> TableHome { get; set; }

        [JsonPropertyName("all_matches_table_away")]
        public List<LeagueStandingTeamRequest> TableAway { get; set; }
    }
}
