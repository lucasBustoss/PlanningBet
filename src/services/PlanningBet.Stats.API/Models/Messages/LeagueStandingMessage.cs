using PlanningBet.Core.Integration;
using PlanningBet.Stats.API.Models.Model.Leagues.Standing;

namespace PlanningBet.Stats.API.Models.Messages
{
    public class LeagueStandingMessage : BaseMessage
    {
        public IEnumerable<LeagueStanding> Standings { get; set; }
    }
}
