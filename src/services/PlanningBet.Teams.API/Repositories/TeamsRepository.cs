using Microsoft.EntityFrameworkCore;
using PlanningBet.Teams.API.Database;
using PlanningBet.Teams.API.Entities;
using PlanningBet.Teams.API.Migrations;

namespace PlanningBet.Teams.API.Repositories
{
    public class TeamsRepository : ITeamsRepository
    {
        private readonly TeamsDbContext _context;

        public TeamsRepository(DbContextOptions<TeamsDbContext> db)
        {
            _context = new TeamsDbContext(db);
        }

        public async Task<bool> CreateOrUpdate(Team team)
        {
            try
            {
                var existentTeam = await _context.Teams.FirstOrDefaultAsync(p => p.Code == team.Code);


                if (existentTeam == null)
                    _context.Teams.Add(team);
                else
                {
                    var oldGeneralStats = await _context.GeneralStats.FirstOrDefaultAsync(p => p.TeamId == existentTeam.Id);
                    var oldHTStats = await _context.HTStats.FirstOrDefaultAsync(p => p.TeamId == existentTeam.Id);
                    var oldFTStats = await _context.FTStats.FirstOrDefaultAsync(p => p.TeamId == existentTeam.Id);
                    var oldGoalsStats = await _context.GoalsStats.FirstOrDefaultAsync(p => p.TeamId == existentTeam.Id);

                    await Task.Run(() => UpdateTeam(existentTeam, team));
                    UpdateGeneralStats(oldGeneralStats, team.GeneralStats);
                    UpdateHTStats(oldHTStats, team.HTStats);
                    UpdateFTStats(oldFTStats, team.FTStats);
                    UpdateGoalsStats(oldGoalsStats, team.GoalsStats);
                }

                await _context.SaveChangesAsync();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<Team> FindAll()
        {
            List<Team> teams = _context.Teams.ToList();
            return teams;
        }

        #region Private methods

        private void UpdateTeam(Team oldTeam, Team newTeam)
        {
            newTeam.Id = oldTeam.Id;
            _context.Entry(oldTeam).CurrentValues.SetValues(newTeam);
        }

        private void UpdateGeneralStats(TeamGeneralStats oldStats, TeamGeneralStats newStats)
        {
            newStats.Id = oldStats.Id;
            newStats.TeamId = oldStats.TeamId;
            _context.Entry(oldStats).CurrentValues.SetValues(newStats);
        }

        private void UpdateHTStats(TeamHTStats oldStats, TeamHTStats newStats)
        {
            newStats.Id = oldStats.Id;
            newStats.TeamId = oldStats.TeamId;
            _context.Entry(oldStats).CurrentValues.SetValues(newStats);
        }

        private void UpdateFTStats(TeamFTStats oldStats, TeamFTStats newStats)
        {
            newStats.Id = oldStats.Id;
            newStats.TeamId = oldStats.TeamId;
            _context.Entry(oldStats).CurrentValues.SetValues(newStats);
        }

        private void UpdateGoalsStats(TeamGoalsStats oldStats, TeamGoalsStats newStats)
        {
            newStats.Id = oldStats.Id;
            newStats.TeamId = oldStats.TeamId;
            _context.Entry(oldStats).CurrentValues.SetValues(newStats);
        }

        #endregion
    }
}
