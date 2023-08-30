using PlanningBet.Core.Integration;
using PlanningBet.Stats.API.Models.Model.Leagues.Matches;

namespace PlanningBet.Stats.API.Models.Messages
{
    public class FixtureMessage : BaseMessage
    {
        public IEnumerable<Fixture> Fixtures { get; set; }
    }
}
