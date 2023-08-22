using PlanningBet.Bets.API.Models.Entity;
using PlanningBet.Bets.API.Models.Response.ListClearedOrders;

namespace PlanningBet.Bets.API.Mappers
{
    public static class BetsResponseToEntity
    {
        public static List<BetEntity> ToEntity(this List<BetsResponse> betsResponses)
        {
            List<BetEntity> bets = new List<BetEntity>();

            foreach (var betResponse in betsResponses)
            {
                var bet = new BetEntity(betResponse);
                bets.Add(bet);
            }

            return bets;
        }
    }
}
