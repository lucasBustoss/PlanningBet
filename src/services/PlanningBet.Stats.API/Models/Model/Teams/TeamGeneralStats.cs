using PlanningBet.Stats.API.Models.ApiResponse.Teams.TeamsResponse;

namespace PlanningBet.Stats.API.Models.Model.Teams
{
    public class TeamGeneralStats
    {
        public TeamGeneralStats(TeamStatsResponse stats)
        {
            PointsPerGameHome = stats.TeamPointsPerGameHome;
            PointsPerGameAway = stats.TeamPointsPerGameAway;
            PointsPerGameOverall = stats.TeamPointsPerGameOverall;
            MatchesPlayedHome = stats.TeamMatchesPlayedHome;
            MatchesPlayedAway = stats.TeamMatchesPlayedAway;
            MatchesPlayedOverall = stats.TeamMatchesPlayedOverall;
            TotalWinsHome = stats.TeamTotalWinsHome;
            TotalWinsAway = stats.TeamTotalWinsAway;
            TotalWinsOverall = stats.TeamTotalWinsOverall;
            WinsPercentageHome = stats.TeamWinsPercentageHome / 100;
            WinsPercentageAway = stats.TeamWinsPercentageAway / 100;
            WinsPercentageOverall = stats.TeamWinsPercentageOverall / 100;
            FirstGoalScoredPercentageHome = stats.TeamFirstGoalScoredPercentageHome / 100;
            FirstGoalScoredPercentageAway = stats.TeamFirstGoalScoredPercentageAway / 100;
            FirstGoalScoredPercentageOverall = stats.TeamFirstGoalScoredPercentageOverall / 100;
            CleanSheetPercentageHome = stats.TeamCleanSheetPercentageHome / 100;
            CleanSheetPercentageAway = stats.TeamCleanSheetPercentageAway / 100;
            CleanSheetPercentageOverall = stats.TeamCleanSheetPercentageOverall / 100;
            FailedToScorePercentageHome = stats.TeamFailedToScorePercentageHome / 100;
            FailedToScorePercentageAway = stats.TeamFailedToScorePercentageAway / 100;
            FailedToScorePercentageOverall = stats.TeamFailedToScorePercentageOverall / 100;
            BothTeamsToScoredHome = stats.TeamBothTeamsToScoredHome;
            BothTeamsToScoredAway = stats.TeamBothTeamsToScoredAway;
            BothTeamsToScoredOverall = stats.TeamBothTeamsToScoredOverall;
            GoalsScoredHome = stats.TeamGoalsScoredHome;
            GoalsScoredAway = stats.TeamGoalsScoredAway;
            GoalsScoredOverall = stats.TeamGoalsScoredOverall;
            GoalsConcededHome = stats.TeamGoalsConcededHome;
            GoalsConcededAway = stats.TeamGoalsConcededAway;
            GoalsConcededOverall = stats.TeamGoalsConcededOverall;
            AvgGoalsScoredHome = stats.TeamAvgGoalsScoredHome;
            AvgGoalsScoredAway = stats.TeamAvgGoalsScoredAway;
            AvgGoalsScoredOverall = stats.TeamAvgGoalsScoredOverall;
            AvgGoalsConcededHome = stats.TeamAvgGoalsConcededHome;
            AvgGoalsConcededAway = stats.TeamAvgGoalsConcededAway;
            AvgGoalsConcededOverall = stats.TeamAvgGoalsConcededOverall;
            AvgTotalGoalsHome = stats.TeamAvgTotalGoalsHome;
            AvgTotalGoalsAway = stats.TeamAvgTotalGoalsAway;
            AvgTotalGoalsOverall = stats.TeamAvgTotalGoalsOverall;
            AvgShotsHome = stats.TeamAvgShotsHome;
            AvgShotsAway = stats.TeamAvgShotsAway;
            AvgShotsOverall = stats.TeamAvgShotsOverall;
            AvgShotsOnTargetHome = stats.TeamAvgShotsOnTargetHome;
            AvgShotsOnTargetAway = stats.TeamAvgShotsOnTargetAway;
            AvgShotsOnTargetOverall = stats.TeamAvgShotsOnTargetOverall;
            XgForHome = stats.TeamXgForHome;
            XgForAway = stats.TeamXgForAway;
            XgForOverall = stats.TeamXgForOverall;
            XgAgainstHome = stats.TeamXgAgainstHome;
            XgAgainstAway = stats.TeamXgAgainstAway;
            XgAgainstOverall = stats.TeamXgAgainstOverall;
        }

        public decimal PointsPerGameHome { get; private set; }

        public decimal PointsPerGameAway { get; private set; }

        public decimal PointsPerGameOverall { get; private set; }

        public int MatchesPlayedHome { get; private set; }

        public decimal MatchesPlayedAway { get; private set; }

        public decimal MatchesPlayedOverall { get; private set; }

        public int TotalWinsHome { get; private set; }

        public int TotalWinsAway { get; private set; }

        public int TotalWinsOverall { get; private set; }

        public decimal WinsPercentageHome { get; private set; }

        public decimal WinsPercentageAway { get; private set; }

        public decimal WinsPercentageOverall { get; private set; }

        public decimal FirstGoalScoredPercentageHome { get; private set; }

        public decimal FirstGoalScoredPercentageAway { get; private set; }

        public decimal FirstGoalScoredPercentageOverall { get; private set; }

        public decimal CleanSheetPercentageHome { get; private set; }

        public decimal CleanSheetPercentageAway { get; private set; }

        public decimal CleanSheetPercentageOverall { get; private set; }

        public decimal FailedToScorePercentageHome { get; private set; }

        public decimal FailedToScorePercentageAway { get; private set; }

        public decimal FailedToScorePercentageOverall { get; private set; }

        public int BothTeamsToScoredHome { get; private set; }

        public int BothTeamsToScoredAway { get; private set; }

        public int BothTeamsToScoredOverall { get; private set; }

        public int GoalsScoredHome { get; private set; }

        public int GoalsScoredAway { get; private set; }

        public int GoalsScoredOverall { get; private set; }

        public int GoalsConcededHome { get; private set; }

        public int GoalsConcededAway { get; private set; }

        public int GoalsConcededOverall { get; private set; }

        public decimal AvgGoalsScoredHome { get; private set; }

        public decimal AvgGoalsScoredAway { get; private set; }

        public decimal AvgGoalsScoredOverall { get; private set; }

        public decimal AvgGoalsConcededHome { get; private set; }

        public decimal AvgGoalsConcededAway { get; private set; }

        public decimal AvgGoalsConcededOverall { get; private set; }

        public decimal AvgTotalGoalsHome { get; private set; }

        public decimal AvgTotalGoalsAway { get; private set; }

        public decimal AvgTotalGoalsOverall { get; private set; }

        public decimal AvgShotsHome { get; private set; }

        public decimal AvgShotsAway { get; private set; }

        public decimal AvgShotsOverall { get; private set; }

        public decimal AvgShotsOnTargetHome { get; private set; }

        public decimal AvgShotsOnTargetAway { get; private set; }

        public decimal AvgShotsOnTargetOverall { get; private set; }

        public decimal XgForHome { get; private set; }

        public decimal XgForAway { get; private set; }

        public decimal XgForOverall { get; private set; }

        public decimal XgAgainstHome { get; private set; }

        public decimal XgAgainstAway { get; private set; }

        public decimal XgAgainstOverall { get; private set; }
    }
}
