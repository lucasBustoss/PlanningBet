using PlanningBet.Bets.API.Models.Entity;
using PlanningBet.Bets.API.Models.Entity.Views;

namespace PlanningBet.Insights.API.Repositories
{
    public interface IBetsRepository
    {
        IEnumerable<BetEntity> FindAllBets();
        IEnumerable<EventWithTeamView> FindAllEvents();
        IEnumerable<BetEntity> FindBetsByEventId();
        EventEntity FindEventByEventId();
        Task<bool> CreateOrUpdateBets(List<BetEntity> bets);
        Task<bool> CreateOrUpdateEvents(List<EventEntity> events);
    }
}
