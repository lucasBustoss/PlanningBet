using PlanningBet.Core.Models;

namespace PlanningBet.Teams.API.Entities
{
    public class TeamGeneralStats : BaseModel
    {
        public virtual Team Team { get; set; }

        public Guid TeamId { get; set; }

        public decimal PointsPerGameHome { get; set; }

        public decimal PointsPerGameAway { get; set; }

        public decimal PointsPerGameOverall { get; set; }

        public int MatchesPlayedHome { get; set; }

        public decimal MatchesPlayedAway { get; set; }

        public decimal MatchesPlayedOverall { get; set; }

        public int TotalWinsHome { get; set; }

        public int TotalWinsAway { get; set; }

        public int TotalWinsOverall { get; set; }

        public decimal WinsPercentageHome { get; set; }

        public decimal WinsPercentageAway { get; set; }

        public decimal WinsPercentageOverall { get; set; }

        public decimal FirstGoalScoredPercentageHome { get; set; }

        public decimal FirstGoalScoredPercentageAway { get; set; }

        public decimal FirstGoalScoredPercentageOverall { get; set; }

        public decimal CleanSheetPercentageHome { get; set; }

        public decimal CleanSheetPercentageAway { get; set; }

        public decimal CleanSheetPercentageOverall { get; set; }

        public decimal FailedToScorePercentageHome { get; set; }

        public decimal FailedToScorePercentageAway { get; set; }

        public decimal FailedToScorePercentageOverall { get; set; }

        public int BothTeamsToScoredHome { get; set; }

        public int BothTeamsToScoredAway { get; set; }

        public int BothTeamsToScoredOverall { get; set; }

        public int GoalsScoredHome { get; set; }

        public int GoalsScoredAway { get; set; }

        public int GoalsScoredOverall { get; set; }

        public int GoalsConcededHome { get; set; }

        public int GoalsConcededAway { get; set; }

        public int GoalsConcededOverall { get; set; }

        public decimal AvgGoalsScoredHome { get; set; }

        public decimal AvgGoalsScoredAway { get; set; }

        public decimal AvgGoalsScoredOverall { get; set; }

        public decimal AvgGoalsConcededHome { get; set; }

        public decimal AvgGoalsConcededAway { get; set; }

        public decimal AvgGoalsConcededOverall { get; set; }

        public decimal AvgTotalGoalsHome { get; set; }

        public decimal AvgTotalGoalsAway { get; set; }

        public decimal AvgTotalGoalsOverall { get; set; }

        public decimal AvgShotsHome { get; set; }

        public decimal AvgShotsAway { get; set; }

        public decimal AvgShotsOverall { get; set; }

        public decimal AvgShotsOnTargetHome { get; set; }

        public decimal AvgShotsOnTargetAway { get; set; }

        public decimal AvgShotsOnTargetOverall { get; set; }

        public decimal XgForHome { get; set; }

        public decimal XgForAway { get; set; }

        public decimal XgForOverall { get; set; }

        public decimal XgAgainstHome { get; set; }

        public decimal XgAgainstAway { get; set; }

        public decimal XgAgainstOverall { get; set; }
    }
}
