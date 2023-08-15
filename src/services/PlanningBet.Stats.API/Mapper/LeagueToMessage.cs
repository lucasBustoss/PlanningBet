using PlanningBet.Stats.API.Models.Messages;
using PlanningBet.Stats.API.Models.Model.Leagues;

namespace PlanningBet.Stats.API.Mapper
{
    public static class LeagueToMessage
    {
        public static LeagueMessage ToLeagueMessage(this IEnumerable<League> leagues)
        {
            var leagueMessage = new LeagueMessage();
            leagueMessage.Leagues = leagues;

            return leagueMessage;
        }
    }
}
