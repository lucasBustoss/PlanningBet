using Microsoft.EntityFrameworkCore;
using PlanningBet.Core.Helpers.Database;
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
