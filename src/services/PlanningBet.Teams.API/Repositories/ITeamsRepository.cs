using PlanningBet.Teams.API.Entities;

namespace PlanningBet.Teams.API.Repositories
{
    public interface ITeamsRepository
    {
        IEnumerable<Team> FindAll();
        Task<bool> CreateOrUpdate(Team team);
    }
}
