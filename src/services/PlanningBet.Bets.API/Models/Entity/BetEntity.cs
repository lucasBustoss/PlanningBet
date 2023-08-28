using PlanningBet.Bets.API.Models.Response.ListClearedOrders.Bets;

namespace PlanningBet.Bets.API.Models.Entity
{
    public class BetEntity
    {
        public BetEntity(BetsResponse betResponse, Guid homeTeamId, Guid awayTeamId, Guid pickTeamId)
        {
            EventId = betResponse.EventId;
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

            BetDetail = new BetDetailEntity(betResponse.MatchDescription, homeTeamId, awayTeamId, pickTeamId);
        }

        public string EventId { get; set; }
        public string MarketId { get; set; }
        public int SelectionId { get; set; }
        public string BetId { get; set; }
        public DateTime PlacedDate { get; set; }
        public string Side { get; set; }
        public string Result { get; set; }
        public decimal OddRequest { get; set; }
        public DateTime SettledDate { get; set; }
        public decimal OddMatched { get; set; }
        public decimal PriceSettled { get; set; }
        public decimal Profit { get; set; }
        public BetDetailEntity BetDetail { get; set; }
    }
}
