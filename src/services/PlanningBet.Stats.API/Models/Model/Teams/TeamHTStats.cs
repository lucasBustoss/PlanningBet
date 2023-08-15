using PlanningBet.Stats.API.Models.ApiResponse.Teams.TeamsResponse;

namespace PlanningBet.Stats.API.Models.Model.Teams
{
    public class TeamHTStats
    {
        public TeamHTStats(TeamStatsResponse stats)
        {
            WinPercentageHTHome = stats.TeamWinPercentageHTHome;
            WinPercentageHTAway = stats.TeamWinPercentageHTAway;
            WinPercentageHTOverall = stats.TeamWinPercentageHTOverall;
            DrawPercentageHTHome = stats.TeamDrawPercentageHTHome;
            DrawPercentageHTAway = stats.TeamDrawPercentageHTAway;
            DrawPercentageHTOverall = stats.TeamDrawPercentageHTOverall;
            LosePercentageHTHome = stats.TeamLosePercentageHTHome;
            LosePercentageHTAway = stats.TeamLosePercentageHTAway;
            LosePercentageHTOverall = stats.TeamLosePercentageHTOverall;
            FailedToScorePercentageHTHome = stats.TeamFailedToScorePercentageHTHome;
            FailedToScorePercentageHTAway = stats.TeamFailedToScorePercentageHTAway;
            FailedToScorePercentageHTOverall = stats.TeamFailedToScorePercentageHTOverall;
            CleanSheetPercentageHTHome = stats.TeamCleanSheetPercentageHTHome;
            CleanSheetPercentageHTAway = stats.TeamCleanSheetPercentageHTAway;
            CleanSheetPercentageHTOverall = stats.TeamCleanSheetPercentageHTOverall;
            GoalsScoredHTHome = stats.TeamGoalsScoredHTHome;
            GoalsScoredHTAway = stats.TeamGoalsScoredHTAway;
            GoalsScoredHTOverall = stats.TeamGoalsScoredHTOverall;
            GoalsConcededHTHome = stats.TeamGoalsConcededHTHome;
            GoalsConcededHTAway = stats.TeamGoalsConcededHTAway;
            GoalsConcededHTOverall = stats.TeamGoalsConcededHTOverall;
            AvgGoalsScoredHTHome = stats.TeamAvgGoalsScoredHTHome;
            AvgGoalsScoredHTAway = stats.TeamAvgGoalsScoredHTAway;
            AvgGoalsScoredHTOverall = stats.TeamAvgGoalsScoredHTOverall;
            AvgGoalsConcededHTHome = stats.TeamAvgGoalsConcededHTHome;
            AvgGoalsConcededHTAway = stats.TeamAvgGoalsConcededHTAway;
            AvgGoalsConcededHTOverall = stats.TeamAvgGoalsConcededHTOverall;
        }

        public decimal WinPercentageHTHome { get; set; }

        public decimal WinPercentageHTAway { get; set; }

        public decimal WinPercentageHTOverall { get; set; }

        public decimal DrawPercentageHTHome { get; set; }

        public decimal DrawPercentageHTAway { get; set; }

        public decimal DrawPercentageHTOverall { get; set; }

        public decimal LosePercentageHTHome { get; set; }

        public decimal LosePercentageHTAway { get; set; }

        public decimal LosePercentageHTOverall { get; set; }

        public decimal FailedToScorePercentageHTHome { get; set; }

        public decimal FailedToScorePercentageHTAway { get; set; }

        public decimal FailedToScorePercentageHTOverall { get; set; }

        public decimal CleanSheetPercentageHTHome { get; set; }

        public decimal CleanSheetPercentageHTAway { get; set; }

        public decimal CleanSheetPercentageHTOverall { get; set; }

        public int GoalsScoredHTHome { get; set; }

        public int GoalsScoredHTAway { get; set; }

        public int GoalsScoredHTOverall { get; set; }

        public int GoalsConcededHTHome { get; set; }

        public int GoalsConcededHTAway { get; set; }

        public int GoalsConcededHTOverall { get; set; }

        public decimal AvgGoalsScoredHTHome { get; set; }

        public decimal AvgGoalsScoredHTAway { get; set; }

        public decimal AvgGoalsScoredHTOverall { get; set; }

        public decimal AvgGoalsConcededHTHome { get; set; }

        public decimal AvgGoalsConcededHTAway { get; set; }

        public decimal AvgGoalsConcededHTOverall { get; set; }
    }
}
