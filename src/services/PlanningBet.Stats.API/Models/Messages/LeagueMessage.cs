using PlanningBet.Core.Integration;
using PlanningBet.Stats.API.Models.Model.Leagues;

namespace PlanningBet.Stats.API.Models.Messages
{
    public class LeagueMessage : BaseMessage
    {
        public IEnumerable<League> Leagues { get; set; }
    }
}
