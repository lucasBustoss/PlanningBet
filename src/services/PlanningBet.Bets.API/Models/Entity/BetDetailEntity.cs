using PlanningBet.Bets.API.Enums;
using PlanningBet.Bets.API.Mappers;
using PlanningBet.Bets.API.Models.Response.ListClearedOrders.Bets;

namespace PlanningBet.Bets.API.Models.Entity
{
    public class BetDetailEntity
    {
        public BetDetailEntity(ItemDescriptionResponse itemDescriptionResponse, Guid homeTeamId, Guid awayTeamId, Guid pickTeamId)
        {
            HomeTeamId = homeTeamId;
            AwayTeamId = awayTeamId;
            MarketDescription = itemDescriptionResponse.MarketDescription;
            MarketType = MarketTypeToEnum.ConvertToMarketType(itemDescriptionResponse.MarketType);
            PickTeamId = pickTeamId;
        }

        public Guid HomeTeamId { get; set; }
        public Guid AwayTeamId { get; set; }
        public string MarketDescription { get; set; }
        public MarketType MarketType { get; set; }
        public Guid PickTeamId { get; set; }
    }
}
