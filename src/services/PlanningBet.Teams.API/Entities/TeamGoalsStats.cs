using PlanningBet.Core.Models;

namespace PlanningBet.Teams.API.Entities
{
    public class TeamGoalsStats : BaseModel
    {
        public virtual Team Team { get; set; }

        public Guid TeamId { get; set; }

        public int FirstGoalScoredOverall { get; set; }

        public int FirstGoalScoredHome { get; set; }

        public int FirstGoalScoredAway { get; set; }

        public int GoalsScoredMin0To15Overall { get; set; }

        public int GoalsScoredMin16To30Overall { get; set; }

        public int GoalsScoredMin31To45Overall { get; set; }

        public int GoalsConcededMin0To15Overall { get; set; }

        public int GoalsConcededMin16To30Overall { get; set; }

        public int GoalsConcededMin31To45Overall { get; set; }

        public int GoalsScoredMin0To15Home { get; set; }

        public int GoalsScoredMin16To30Home { get; set; }

        public int GoalsScoredMin31To45Home { get; set; }

        public int GoalsConcededMin0To15Home { get; set; }

        public int GoalsConcededMin16To30Home { get; set; }

        public int GoalsConcededMin31To45Home { get; set; }

        public int GoalsScoredMin0To15Away { get; set; }

        public int GoalsScoredMin16To30Away { get; set; }

        public int GoalsScoredMin31To45Away { get; set; }

        public int GoalsConcededMin0To15Away { get; set; }

        public int GoalsConcededMin16To30Away { get; set; }

        public int GoalsConcededMin31To45Away { get; set; }
    }
}
