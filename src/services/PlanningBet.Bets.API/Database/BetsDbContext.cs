using Microsoft.EntityFrameworkCore;
using PlanningBet.Bets.API.Models.Entity;

namespace PlanningBet.Bets.API.Database
{
    public class BetsDbContext : DbContext
    {
        public BetsDbContext() { }

        public BetsDbContext(DbContextOptions<BetsDbContext> options) : base(options) { }

        public DbSet<BetEntity> Bets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
