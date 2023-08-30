using PlanningBet.Bets.API.Models.Response.ListClearedOrders.Events;
using PlanningBet.Core.Models;

namespace PlanningBet.Bets.API.Models.Entity
{
    public class EventEntity : BaseModel
    {
        public EventEntity(EventsResponse eventResponse, Guid homeTeamId, Guid awayTeamId) : this(homeTeamId, awayTeamId)
        {
            EventCode = eventResponse.EventId;
            Date = eventResponse.Date;
            BetCount = eventResponse.BetCount;
            Commission = eventResponse.Commission;
            Profit = eventResponse.Profit;
        }

        public EventEntity(Guid homeTeamId, Guid awayTeamId)
        {
            HomeTeamId = homeTeamId;
            AwayTeamId = awayTeamId;
        }

        public string EventCode { get; set; }
        public Guid HomeTeamId { get; set; }
        public Guid AwayTeamId { get; set; }
        public DateTime Date { get; set; }
        public int BetCount { get; set; }
        public decimal Commission { get; set; }
        public decimal Profit { get; set; }
    }
}
