using System.Text.Json.Serialization;

namespace PlanningBet.Stats.API.Models.ApiResponse.Leagues.LeagueStanding
{
    public class LeagueStandingTeamRequest
    {
        [JsonPropertyName("id")]
        public int TeamCode { get; set; }

        [JsonPropertyName("position")]
        public int TeamPosition { get; set; }

        [JsonPropertyName("points")]
        public int TeamPoints { get; set; }

        [JsonPropertyName("matchesPlayed")]
        public int TeamMatchesPlayed { get; set; }

        [JsonPropertyName("seasonGoals")]
        public int TeamGoalsScored { get; set; }

        [JsonPropertyName("seasonConceded_home")]
        public int TeamGoalsConcededHome { private get; set; }

        [JsonPropertyName("seasonConceded_away")]
        public int TeamGoalsConcededAway { private get; set; }

        [JsonPropertyName("seasonWins_overall")]
        public int TeamWins { get; set; }

        [JsonPropertyName("seasonDraws_overall")]
        public int TeamDraws { get; set; }

        [JsonPropertyName("seasonLosses_overall")]
        public int TeamLosses { get; set; }

        public int TeamGoalsConceded
        {
            get
            {
                return TeamGoalsConcededHome + TeamGoalsConcededAway;
            }
        }

        public int TeamGoalsDifference
        {
            get
            {
                return TeamGoalsScored - TeamGoalsConceded;
            }
        }

    }
}
