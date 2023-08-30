using PlanningBet.Bets.API.Models.Entity;

namespace PlanningBet.Bets.API.Services
{
    public interface IApiService
    {
        Task<List<EventEntity>> SyncBets(string auth);
    }
}
