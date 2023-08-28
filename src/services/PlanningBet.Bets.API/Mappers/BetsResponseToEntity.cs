using PlanningBet.Bets.API.Models.Entity;
using PlanningBet.Bets.API.Models.Response.ListClearedOrders.Bets;
using PlanningBet.Bets.API.Models.Response.Teams;
using PlanningBet.Bets.API.Utils;

namespace PlanningBet.Bets.API.Mappers
{
    public static class BetsResponseToEntity
    {
        public static List<BetEntity> ToEntity(this List<BetsResponse> betsResponses, List<Team> teams)
        {
            List<BetEntity> bets = new List<BetEntity>();

            foreach (var betResponse in betsResponses)
            {
                var betTeams = betResponse.MatchDescription.EventDescription.Split(" x ");
                var betHomeTeam = Converts.ConvertBetToTeamName(betTeams[0]);
                var betAwayTeam = Converts.ConvertBetToTeamName(betTeams[1]);
                var betPickTeam = Converts.ConvertBetToTeamName(betResponse.MatchDescription.PickDescription);

                var homeTeam = teams.Where(t => t.Name == betHomeTeam || t.CleanName == betHomeTeam).FirstOrDefault();
                var awayTeam = teams.Where(t => t.Name == betAwayTeam || t.CleanName == betAwayTeam).FirstOrDefault();
                Team pickTeam;

                if (betPickTeam == betHomeTeam)
                    pickTeam = homeTeam;
                else
                    pickTeam = awayTeam;

                if (homeTeam != null && awayTeam != null && pickTeam != null)
                {
                    var bet = new BetEntity(betResponse, homeTeam.Id, awayTeam.Id, pickTeam.Id);
                    bets.Add(bet);
                }
            }

            return bets;
        }
    }
}
