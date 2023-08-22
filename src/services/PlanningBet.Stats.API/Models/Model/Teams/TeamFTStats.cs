using PlanningBet.Stats.API.Models.ApiResponse.Teams.TeamsResponse;

namespace PlanningBet.Stats.API.Models.Model.Teams
{
    public class TeamFTStats
    {
        public TeamFTStats(TeamStatsResponse stats)
        {
            WinPercentageFTHome = stats.TeamWinPercentageFTHome / 100;
            WinPercentageFTAway = stats.TeamWinPercentageFTAway / 100;
            WinPercentageFTOverall = stats.TeamWinPercentageFTOverall / 100;
            DrawPercentageFTHome = stats.TeamDrawPercentageFTHome / 100;
            DrawPercentageFTAway = stats.TeamDrawPercentageFTAway / 100;
            DrawPercentageFTOverall = stats.TeamDrawPercentageFTOverall / 100;
            LosePercentageFTHome = stats.TeamLosePercentageFTHome / 100;
            LosePercentageFTAway = stats.TeamLosePercentageFTAway / 100;
            LosePercentageFTOverall = stats.TeamLosePercentageFTOverall / 100;
            FailedToScorePercentageFTHome = stats.TeamFailedToScorePercentageFTHome / 100;
            FailedToScorePercentageFTAway = stats.TeamFailedToScorePercentageFTAway / 100;
            FailedToScorePercentageFTOverall = stats.TeamFailedToScorePercentageFTOverall / 100;
            CleanSheetPercentageFTHome = stats.TeamCleanSheetPercentageFTHome / 100;
            CleanSheetPercentageFTAway = stats.TeamCleanSheetPercentageFTAway / 100;
            CleanSheetPercentageFTOverall = stats.TeamCleanSheetPercentageFTOverall / 100;
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
        public decimal WinPercentageFTHome { get; private set; }

        public decimal WinPercentageFTAway { get; private set; }

        public decimal WinPercentageFTOverall { get; private set; }

        public decimal DrawPercentageFTHome { get; private set; }

        public decimal DrawPercentageFTAway { get; private set; }

        public decimal DrawPercentageFTOverall { get; private set; }

        public decimal LosePercentageFTHome { get; private set; }

        public decimal LosePercentageFTAway { get; private set; }

        public decimal LosePercentageFTOverall { get; private set; }

        public decimal FailedToScorePercentageFTHome { get; private set; }

        public decimal FailedToScorePercentageFTAway { get; private set; }

        public decimal FailedToScorePercentageFTOverall { get; private set; }

        public decimal CleanSheetPercentageFTHome { get; private set; }

        public decimal CleanSheetPercentageFTAway { get; private set; }

        public decimal CleanSheetPercentageFTOverall { get; private set; }

        public int GoalsScoredFTHome { get; private set; }

        public int GoalsScoredFTAway { get; private set; }

        public int GoalsScoredFTOverall { get; private set; }

        public int GoalsConcededFTHome { get; private set; }

        public int GoalsConcededFTAway { get; private set; }

        public int GoalsConcededFTOverall { get; private set; }

        public decimal AvgGoalsScoredFTHome { get; private set; }

        public decimal AvgGoalsScoredFTAway { get; private set; }

        public decimal AvgGoalsScoredFTOverall { get; private set; }

        public decimal AvgGoalsConcededFTHome { get; private set; }

        public decimal AvgGoalsConcededFTAway { get; private set; }

        public decimal AvgGoalsConcededFTOverall { get; private set; }
    }
}
