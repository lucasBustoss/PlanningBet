using Microsoft.EntityFrameworkCore;
using PlanningBet.Core.Helpers.Database;
using PlanningBet.Teams.API.Entities;
using System.Reflection.Emit;

namespace PlanningBet.Teams.API.Database
{
    public class TeamsDbContext : DbContext
    {
        public TeamsDbContext() { }

        public TeamsDbContext(DbContextOptions<TeamsDbContext> options) : base(options) { }
    
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamGeneralStats> GeneralStats { get; set; }
        public DbSet<TeamHTStats> HTStats { get; set; }
        public DbSet<TeamFTStats> FTStats { get; set; }
        public DbSet<TeamGoalsStats> GoalsStats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TeamGeneralStats>().ToTable("teams_generalstats");
            modelBuilder.Entity<TeamHTStats>().ToTable("teams_htstats");
            modelBuilder.Entity<TeamFTStats>().ToTable("teams_ftstats");
            modelBuilder.Entity<TeamGoalsStats>().ToTable("teams_goalsstats");


            modelBuilder.Entity<TeamFTStats>().HasIndex(p => p.TeamId).IsUnique();
            modelBuilder.Entity<TeamHTStats>().HasIndex(p => p.TeamId).IsUnique();

            // Não permite deletar a primary key se houver ao menos 1 registro nas tabelas foreign
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

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
