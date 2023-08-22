using Microsoft.EntityFrameworkCore;
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
            modelBuilder.Entity<TeamGeneralStats>().ToTable("Teams_GeneralStats");
            modelBuilder.Entity<TeamHTStats>().ToTable("Teams_HTStats");
            modelBuilder.Entity<TeamFTStats>().ToTable("Teams_FTStats");
            modelBuilder.Entity<TeamGoalsStats>().ToTable("Teams_GoalsStats");


            modelBuilder.Entity<TeamFTStats>().HasIndex(p => p.TeamId).IsUnique();
            modelBuilder.Entity<TeamHTStats>().HasIndex(p => p.TeamId).IsUnique();

            // Não permite deletar a primary key se houver ao menos 1 registro nas tabelas foreign
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}
