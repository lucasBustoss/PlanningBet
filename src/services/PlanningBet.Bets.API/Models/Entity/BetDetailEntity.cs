using PlanningBet.Bets.API.Enums;
using PlanningBet.Bets.API.Mappers;
using PlanningBet.Bets.API.Models.Response.ListClearedOrders;

namespace PlanningBet.Bets.API.Models.Entity
{
    public class BetDetailEntity
    {
        public BetDetailEntity(ItemDescriptionResponse itemDescriptionResponse)
        {
            HomeTeamId = 1;
            AwayTeamId = 2;
            MarketDescription = itemDescriptionResponse.MarketDescription;
            MarketType = MarketTypeToEnum.ConvertToMarketType(itemDescriptionResponse.MarketType);
            PickTeamId = 1;
        }

        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }
        public string MarketDescription { get; set; }
        public MarketType MarketType { get; set; }
        public int PickTeamId { get; set; }
    }
}
