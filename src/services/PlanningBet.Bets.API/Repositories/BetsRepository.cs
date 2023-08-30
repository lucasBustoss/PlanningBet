using Microsoft.EntityFrameworkCore;
using PlanningBet.Bets.API.Database;
using PlanningBet.Bets.API.Models.Entity;

namespace PlanningBet.Insights.API.Repositories
{
    public class BetsRepository : IBetsRepository
    {
        private readonly BetsDbContext _context;

        public BetsRepository(BetsDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateOrUpdateBets(List<BetEntity> bets)
        {
            try
            {
                foreach (var bet in bets)
                {
                    var existentBet = await _context.Bets.FirstOrDefaultAsync(p => p.BetId == bet.BetId);

                    if (existentBet == null)
                        _context.Bets.Add(bet);
                    else
                    {
                        bet.Id = existentBet.Id;
                        _context.Entry(existentBet).CurrentValues.SetValues(bet);
                    }
                }
                
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> CreateOrUpdateEvents(List<EventEntity> events)
        {
            try
            {
                foreach (var betEvent in events)
                {
                    var existentBet = await _context.Events.FirstOrDefaultAsync(p => p.EventCode == betEvent.EventCode);

                    if (existentBet == null)
                        _context.Events.Add(betEvent);
                    else
                    {
                        betEvent.Id = existentBet.Id;
                        _context.Entry(existentBet).CurrentValues.SetValues(betEvent);
                    }
                }

                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<BetEntity> FindAllBets()
        {
            List<BetEntity> bets = _context.Bets.ToList();
            return bets;
        }

        public IEnumerable<EventEntity> FindAllEvents()
        {
            List<EventEntity> events = _context.Events.ToList();
            return events;
        }

        public IEnumerable<BetEntity> FindBetsByEventId()
        {
            throw new NotImplementedException();
        }

        public EventEntity FindEventByEventId()
        {
            throw new NotImplementedException();
        }
    }
}
