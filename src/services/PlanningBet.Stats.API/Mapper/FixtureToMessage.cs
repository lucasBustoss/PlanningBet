using PlanningBet.Stats.API.Models.Messages;
using PlanningBet.Stats.API.Models.Model.Leagues.Matches;

namespace PlanningBet.Stats.API.Mapper
{
    public static class FixtureToMessage
    {
        public static FixtureMessage ToFixtureMessage(this IEnumerable<Fixture> fixtures)
        {
            var fixtureMessage = new FixtureMessage();
            fixtureMessage.Fixtures = fixtures;

            return fixtureMessage;
        }
    }
}
