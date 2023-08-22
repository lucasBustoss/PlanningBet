using PlanningBet.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlanningBet.Teams.API.Entities
{
    public class TeamFTStats : BaseModel
    {
        public virtual Team Team { get; set; }
        
        public Guid TeamId { get; set; }

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
