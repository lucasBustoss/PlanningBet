using PlanningBet.Core.Integration;
using PlanningBet.Stats.API.Models.Model.Teams;

namespace PlanningBet.Stats.API.Models.Messages
{
    public class TeamMessage : BaseMessage
    {
        public IEnumerable<Team> Teams { get; set; }
    }
}
