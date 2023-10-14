using Microsoft.EntityFrameworkCore;
using PlanningBet.Bets.API.Models.Entity;
using PlanningBet.Bets.API.Models.Entity.Views;
using PlanningBet.Core.Helpers.Database;

namespace PlanningBet.Bets.API.Database
{
    public class BetsDbContext : DbContext
    {
        public BetsDbContext() { }

        public BetsDbContext(DbContextOptions<BetsDbContext> options) : base(options) { }

        public DbSet<EventEntity> Events { get; set; }
        public DbSet<BetEntity> Bets { get; set; }
        public DbSet<EventWithTeamView> EventsWithTeamView { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                entity.SetTableName(entity.GetTableName().ToSnakeCase());

                foreach (var property in entity.GetProperties())
                {
                    property.SetColumnName(property.GetColumnName().ToSnakeCase());
                }

                foreach (var key in entity.GetKeys())
                {
                    key.SetName(key.GetName().ToSnakeCase());
                }

                foreach (var foreignKey in entity.GetForeignKeys())
                {
                    foreignKey.SetConstraintName(foreignKey.GetConstraintName().ToSnakeCase());
                }
            }
        }
    }
}
