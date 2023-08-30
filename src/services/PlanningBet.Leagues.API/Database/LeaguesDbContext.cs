using Microsoft.EntityFrameworkCore;
using PlanningBet.Leagues.API.Entities;
using System.Reflection.Emit;

namespace PlanningBet.Leagues.API.Database
{
    public class LeaguesDbContext : DbContext
    {
        public LeaguesDbContext() { }

        public LeaguesDbContext(DbContextOptions<LeaguesDbContext> options) : base(options) { }
        
        public DbSet<League> Leagues { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
