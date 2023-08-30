using System.Text.Json.Serialization;

namespace PlanningBet.Stats.API.Models.ApiResponse.Fixtures
{
    public class FixtureResponse
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

        [JsonPropertyName("homeGoalCount")]
        public int TeamHomeGoals { get; set; }

        [JsonPropertyName("awayID")]
        public int TeamAwayId { get; set; }

        [JsonPropertyName("awayGoalCount")]
        public int TeamAwayGoals { get; set; }

        [JsonPropertyName("odds_ft_1")]
        public decimal OddsMatchOddsHome { get; set; }

        [JsonPropertyName("odds_ft_2")]
        public decimal OddsMatchOddsAway { get; set; }

        [JsonPropertyName("odds_ft_x")]
        public decimal OddsMatchOddsDraw { get; set; }

        [JsonPropertyName("odds_ft_over25")]
        public decimal OddsOver25 { get; set; }

        [JsonPropertyName("odds_ft_under25")]
        public decimal OddsUnder25 { get; set; }
    }
}
