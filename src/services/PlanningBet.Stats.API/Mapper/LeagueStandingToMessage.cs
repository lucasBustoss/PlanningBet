using PlanningBet.Stats.API.Models.Messages;
using PlanningBet.Stats.API.Models.Model.Leagues.Standing;

namespace PlanningBet.Stats.API.Mapper
{
    public static class LeagueStandingToMessage
    {
        public static LeagueStandingMessage ToLeagueStandingMessage(this IEnumerable<LeagueStanding> standings)
        {
            var leagueStandingMessage = new LeagueStandingMessage();
            leagueStandingMessage.Standings = standings;

            return leagueStandingMessage;
        }
    }
}
