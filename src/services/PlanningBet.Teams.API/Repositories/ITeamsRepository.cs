using PlanningBet.Core.Interfaces.Repositories;
using PlanningBet.Teams.API.Entities;

namespace PlanningBet.Teams.API.Repositories
{
    public interface ITeamsRepository : IMessageRepository<Team>
    {
    }
}
