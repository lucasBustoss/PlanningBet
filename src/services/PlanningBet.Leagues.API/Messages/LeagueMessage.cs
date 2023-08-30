using PlanningBet.Leagues.API.Entities;

namespace PlanningBet.Leagues.API.Messages
{
    public class LeagueMessage
    {
        public IEnumerable<League> Leagues { get; set; }
    }
}
