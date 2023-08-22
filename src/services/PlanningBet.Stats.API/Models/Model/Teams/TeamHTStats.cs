using PlanningBet.Stats.API.Models.ApiResponse.Teams.TeamsResponse;

namespace PlanningBet.Stats.API.Models.Model.Teams
{
    public class TeamHTStats
    {
        public TeamHTStats(TeamStatsResponse stats)
        {
            WinPercentageHTHome = stats.TeamWinPercentageHTHome / 100;
            WinPercentageHTAway = stats.TeamWinPercentageHTAway / 100;
            WinPercentageHTOverall = stats.TeamWinPercentageHTOverall / 100;
            DrawPercentageHTHome = stats.TeamDrawPercentageHTHome / 100;
            DrawPercentageHTAway = stats.TeamDrawPercentageHTAway / 100;
            DrawPercentageHTOverall = stats.TeamDrawPercentageHTOverall / 100;
            LosePercentageHTHome = stats.TeamLosePercentageHTHome / 100;
            LosePercentageHTAway = stats.TeamLosePercentageHTAway / 100;
            LosePercentageHTOverall = stats.TeamLosePercentageHTOverall / 100;
            FailedToScorePercentageHTHome = stats.TeamFailedToScorePercentageHTHome / 100;
            FailedToScorePercentageHTAway = stats.TeamFailedToScorePercentageHTAway / 100;
            FailedToScorePercentageHTOverall = stats.TeamFailedToScorePercentageHTOverall / 100;
            CleanSheetPercentageHTHome = stats.TeamCleanSheetPercentageHTHome / 100;
            CleanSheetPercentageHTAway = stats.TeamCleanSheetPercentageHTAway / 100;
            CleanSheetPercentageHTOverall = stats.TeamCleanSheetPercentageHTOverall / 100;
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

        public decimal WinPercentageHTHome { get; private set; }

        public decimal WinPercentageHTAway { get; private set; }

        public decimal WinPercentageHTOverall { get; private set; }

        public decimal DrawPercentageHTHome { get; private set; }

        public decimal DrawPercentageHTAway { get; private set; }

        public decimal DrawPercentageHTOverall { get; private set; }

        public decimal LosePercentageHTHome { get; private set; }

        public decimal LosePercentageHTAway { get; private set; }

        public decimal LosePercentageHTOverall { get; private set; }

        public decimal FailedToScorePercentageHTHome { get; private set; }

        public decimal FailedToScorePercentageHTAway { get; private set; }

        public decimal FailedToScorePercentageHTOverall { get; private set; }

        public decimal CleanSheetPercentageHTHome { get; private set; }

        public decimal CleanSheetPercentageHTAway { get; private set; }

        public decimal CleanSheetPercentageHTOverall { get; private set; }

        public int GoalsScoredHTHome { get; private set; }

        public int GoalsScoredHTAway { get; private set; }

        public int GoalsScoredHTOverall { get; private set; }

        public int GoalsConcededHTHome { get; private set; }

        public int GoalsConcededHTAway { get; private set; }

        public int GoalsConcededHTOverall { get; private set; }

        public decimal AvgGoalsScoredHTHome { get; private set; }

        public decimal AvgGoalsScoredHTAway { get; private set; }

        public decimal AvgGoalsScoredHTOverall { get; private set; }

        public decimal AvgGoalsConcededHTHome { get; private set; }

        public decimal AvgGoalsConcededHTAway { get; private set; }

        public decimal AvgGoalsConcededHTOverall { get; private set; }
    }
}
