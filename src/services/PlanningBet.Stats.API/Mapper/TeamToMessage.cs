using PlanningBet.Stats.API.Models.Messages;
using PlanningBet.Stats.API.Models.Model.Leagues;
using PlanningBet.Stats.API.Models.Model.Teams;

namespace PlanningBet.Stats.API.Mapper
{
    public static class TeamToMessage
    {
        public static TeamMessage ToTeamMessage(this IEnumerable<Team> teams)
        {
            var teamMessage = new TeamMessage();
            teamMessage.Teams = teams;

            return teamMessage;
        }
    }
}
