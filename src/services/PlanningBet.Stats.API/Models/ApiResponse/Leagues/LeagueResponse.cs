using System.Text.Json.Serialization;

namespace PlanningBet.Stats.API.Models.ApiResponse.Leagues
{
    public class LeagueResponse
    {
        [JsonPropertyName("id")]
        public int LeagueId { get; set; }

        [JsonPropertyName("name")]
        public string LeagueFullName { get; set; }

        [JsonPropertyName("country")]
        public string LeagueCountry { get; set; }

        [JsonPropertyName("league_name")]
        public string LeagueName { get; set; }

        [JsonPropertyName("image")]
        public string LeagueImage { get; set; }

        [JsonPropertyName("season")]
        public IEnumerable<LeagueSeason> Seasons { get; set; }
    }

    public class LeagueSeason
    {
        [JsonPropertyName("id")]
        public int LeagueSeasonId { get; set; }

        [JsonPropertyName("year")]
        public int LeagueSeasonYear { get; set; }
    }

}
