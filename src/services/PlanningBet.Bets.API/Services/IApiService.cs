using PlanningBet.Bets.API.Models.Entity;

namespace PlanningBet.Bets.API.Services
{
    public interface IApiService
    {
        Task<List<BetEntity>> SyncBets();
    }
}
