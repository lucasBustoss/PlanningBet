using PlanningBet.Stats.API.Models.ApiResponse.Teams.TeamsResponse;

namespace PlanningBet.Stats.API.Models.Model.Teams
{
    public class TeamFTStats
    {
        public TeamFTStats(TeamStatsResponse stats)
        {
            WinPercentageFTHome = stats.TeamWinPercentageFTHome;
            WinPercentageFTAway = stats.TeamWinPercentageFTAway;
            WinPercentageFTOverall = stats.TeamWinPercentageFTOverall;
            DrawPercentageFTHome = stats.TeamDrawPercentageFTHome;
            DrawPercentageFTAway = stats.TeamDrawPercentageFTAway;
            DrawPercentageFTOverall = stats.TeamDrawPercentageFTOverall;
            LosePercentageFTHome = stats.TeamLosePercentageFTHome;
            LosePercentageFTAway = stats.TeamLosePercentageFTAway;
            LosePercentageFTOverall = stats.TeamLosePercentageFTOverall;
            FailedToScorePercentageFTHome = stats.TeamFailedToScorePercentageFTHome;
            FailedToScorePercentageFTAway = stats.TeamFailedToScorePercentageFTAway;
            FailedToScorePercentageFTOverall = stats.TeamFailedToScorePercentageFTOverall;
            CleanSheetPercentageFTHome = stats.TeamCleanSheetPercentageFTHome;
            CleanSheetPercentageFTAway = stats.TeamCleanSheetPercentageFTAway;
            CleanSheetPercentageFTOverall = stats.TeamCleanSheetPercentageFTOverall;
            GoalsScoredFTHome = stats.TeamGoalsScoredFTHome;
            GoalsScoredFTAway = stats.TeamGoalsScoredFTAway;
            GoalsScoredFTOverall = stats.TeamGoalsScoredFTOverall;
            GoalsConcededFTHome = stats.TeamGoalsConcededFTHome;
            GoalsConcededFTAway = stats.TeamGoalsConcededFTAway;
            GoalsConcededFTOverall = stats.TeamGoalsConcededFTOverall;
            AvgGoalsScoredFTHome = stats.TeamAvgGoalsScoredFTHome;
            AvgGoalsScoredFTAway = stats.TeamAvgGoalsScoredFTAway;
            AvgGoalsScoredFTOverall = stats.TeamAvgGoalsScoredFTOverall;
            AvgGoalsConcededFTHome = stats.TeamAvgGoalsConcededFTHome;
            AvgGoalsConcededFTAway = stats.TeamAvgGoalsConcededFTAway;
            AvgGoalsConcededFTOverall = stats.TeamAvgGoalsConcededFTOverall;
        }
        public decimal WinPercentageFTHome { get; set; }

        public decimal WinPercentageFTAway { get; set; }

        public decimal WinPercentageFTOverall { get; set; }

        public decimal DrawPercentageFTHome { get; set; }

        public decimal DrawPercentageFTAway { get; set; }

        public decimal DrawPercentageFTOverall { get; set; }

        public decimal LosePercentageFTHome { get; set; }

        public decimal LosePercentageFTAway { get; set; }

        public decimal LosePercentageFTOverall { get; set; }

        public decimal FailedToScorePercentageFTHome { get; set; }

        public decimal FailedToScorePercentageFTAway { get; set; }

        public decimal FailedToScorePercentageFTOverall { get; set; }

        public decimal CleanSheetPercentageFTHome { get; set; }

        public decimal CleanSheetPercentageFTAway { get; set; }

        public decimal CleanSheetPercentageFTOverall { get; set; }

        public int GoalsScoredFTHome { get; set; }

        public int GoalsScoredFTAway { get; set; }

        public int GoalsScoredFTOverall { get; set; }

        public int GoalsConcededFTHome { get; set; }

        public int GoalsConcededFTAway { get; set; }

        public int GoalsConcededFTOverall { get; set; }

        public decimal AvgGoalsScoredFTHome { get; set; }

        public decimal AvgGoalsScoredFTAway { get; set; }

        public decimal AvgGoalsScoredFTOverall { get; set; }

        public decimal AvgGoalsConcededFTHome { get; set; }

        public decimal AvgGoalsConcededFTAway { get; set; }

        public decimal AvgGoalsConcededFTOverall { get; set; }
    }
}
