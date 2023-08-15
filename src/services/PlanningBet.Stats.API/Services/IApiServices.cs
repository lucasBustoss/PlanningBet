using PlanningBet.Stats.API.Models.ApiResponse;
using PlanningBet.Stats.API.Models.ApiResponse.Leagues.LeagueStatsInfo;
using PlanningBet.Stats.API.Models.Model.Leagues;
using PlanningBet.Stats.API.Models.Model.Teams;

namespace PlanningBet.Stats.API.Services
{
    public interface IApiServices
    {
        void GetAllStats();
        void GetFixtures();
        Task<List<League>> GetLeagues();
        Task<List<Team>> GetTeams(List<League> leagues);
        void GetLeagueStanding();
        void GetLeagueMatches();
        void GetLastStats();
    }
}
