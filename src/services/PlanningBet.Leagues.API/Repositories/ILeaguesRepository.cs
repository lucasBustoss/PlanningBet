using PlanningBet.Core.Interfaces.Repositories;
using PlanningBet.Leagues.API.Entities;

namespace PlanningBet.Leagues.API.Repositories
{
    public interface ILeaguesRepository : IMessageRepository<League>
    {
    }
}
