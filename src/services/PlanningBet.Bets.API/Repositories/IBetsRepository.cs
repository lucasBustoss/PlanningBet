using PlanningBet.Bets.API.Models.Entity;

namespace PlanningBet.Insights.API.Repositories
{
    public interface IBetsRepository
    {
        IEnumerable<BetEntity> FindAllBets();
        IEnumerable<BetEntity> FindBetsByEventId();
        EventEntity FindEventByEventId();
        Task<bool> CreateOrUpdateBets(List<BetEntity> bets);
        Task<bool> CreateOrUpdateEvents(List<EventEntity> events);
    }
}
