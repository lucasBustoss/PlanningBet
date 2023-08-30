using PlanningBet.Bets.API.Enums;
using PlanningBet.Bets.API.Mappers;
using PlanningBet.Bets.API.Models.Response.ListClearedOrders.Bets;
using PlanningBet.Core.Models;

namespace PlanningBet.Bets.API.Models.Entity
{
    public class BetEntity : BaseModel
    {
        public BetEntity(BetsResponse betResponse, Guid eventId, Guid pickTeamId) : this(pickTeamId)
        {
            EventId = eventId;
            EventCode = betResponse.EventId;
            MarketId = betResponse.MarketId;
            SelectionId = betResponse.SelectionId;
            BetId = betResponse.BetId;
            PlacedDate = betResponse.PlacedDate;
            Side = betResponse.Side;
            OddRequest = betResponse.PriceRequested;
            SettledDate = betResponse.SettledDate;
            OddMatched = betResponse.PriceMatched;
            PriceSettled = betResponse.SizeSettled;
            Profit = betResponse.Profit;
            MarketDescription = betResponse.MatchDescription.MarketDescription;
            MarketType = MarketTypeToEnum.ConvertToMarketType(betResponse.MatchDescription.MarketType);
        }

        public BetEntity(Guid pickTeamId)
        {
            PickTeamId = pickTeamId;
        }

        public Guid EventId { get; set; }
        public string EventCode { get; set; }
        public string MarketId { get; set; }
        public int SelectionId { get; set; }
        public string BetId { get; set; }
        public DateTime PlacedDate { get; set; }
        public string Side { get; set; }
        public decimal OddRequest { get; set; }
        public DateTime SettledDate { get; set; }
        public decimal OddMatched { get; set; }
        public decimal PriceSettled { get; set; }
        public decimal Profit { get; set; }
        public string MarketDescription { get; set; }
        public MarketType MarketType { get; set; }
        public Guid PickTeamId { get; set; }
    }
}
