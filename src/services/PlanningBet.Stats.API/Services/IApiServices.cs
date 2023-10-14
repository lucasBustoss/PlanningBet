using PlanningBet.Stats.API.Models.ApiResponse;
using PlanningBet.Stats.API.Models.ApiResponse.Leagues.LeagueStatsInfo;
using PlanningBet.Stats.API.Models.Model.Leagues;
using PlanningBet.Stats.API.Models.Model.Teams;

namespace PlanningBet.Stats.API.Services
{
    public interface IApiServices
    {
        void GetAllStats();
        void GetFixtures(List<League> leagues);
        Task<List<League>> GetLeagues(List<Country> countries);
        Task<List<Team>> GetTeams(List<Country> countries, List<League> leagues);
        void GetLeagueStanding(List<League> leagues);
        void GetLastStats();
    }
}
