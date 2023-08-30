using Microsoft.EntityFrameworkCore;
using PlanningBet.Leagues.API.Database;
using PlanningBet.Leagues.API.Entities;

namespace PlanningBet.Leagues.API.Repositories
{
    public class LeaguesRepository : ILeaguesRepository
    {
        private readonly LeaguesDbContext _context;

        public LeaguesRepository(DbContextOptions<LeaguesDbContext> db)
        {
            _context = new LeaguesDbContext(db);
        }

        public async Task<bool> CreateOrUpdate(League league)
        {
            try
            {
                var existentLeague = await _context.Leagues.FirstOrDefaultAsync(p => p.Code == league.Code);

                if (existentLeague == null)
                    _context.Leagues.Add(league);
                else
                {
                    await Task.Run(() => UpdateLeague(existentLeague, league));
                }

                await _context.SaveChangesAsync();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<League> FindAll()
        {
            List<League> leagues = _context.Leagues.ToList();
            return leagues;
        }

        #region Private methods

        private void UpdateLeague(League oldLeague, League newLeague)
        {
            newLeague.Id = oldLeague.Id;
            _context.Entry(oldLeague).CurrentValues.SetValues(newLeague);
        }

        #endregion
    }
}
