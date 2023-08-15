using System.Text.Json.Serialization;

namespace PlanningBet.Stats.API.Models.ApiResponse.Leagues.LeagueStatsInfo
{
    public class LeagueStatsInfoRequest
    {
        [JsonPropertyName("iso")]
        public string IsoCode { get; set; }

        [JsonPropertyName("country")]
        public string CountryName { get; set; }

        [JsonPropertyName("name")]
        public string LeagueName { get; set; }

        [JsonPropertyName("image")]
        public string LeagueImage { get; set; }
    }
}
