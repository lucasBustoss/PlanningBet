using Microsoft.EntityFrameworkCore;
using PlanningBet.Insights.API.Models;

namespace PlanningBet.Insights.API.Infra.Context
{
    public class InsightsDbContext : DbContext
    {
        public InsightsDbContext() { }

        public InsightsDbContext(DbContextOptions<InsightsDbContext> options) : base(options) { }

        public DbSet<InsightEntity> Insights { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Seed Data

            modelBuilder.Entity<InsightEntity>().HasData(
               new InsightEntity()
               {
                   Id = Guid.NewGuid(),
                   Name = "Vitórias",
                   Value = "wins",
                   Type = "sequency",
                   Active = true
               }, 
               new InsightEntity()
               {
                   Id = Guid.NewGuid(),
                   Name = "Derrotas",
                   Value = "loses",
                   Type = "sequency",
                   Active = true
               }, 
               new InsightEntity()
               {
                   Id = Guid.NewGuid(),
                   Name = "Invencibilidade",
                   Value = "invincibility",
                   Type = "sequency",
                   Active = true
               }, 
               new InsightEntity()
               {
                   Id = Guid.NewGuid(),
                   Name = "Marcou gols",
                   Value = "scored",
                   Type = "sequency",
                   Active = true
               }, 
               new InsightEntity()
               {
                   Id = Guid.NewGuid(),
                   Name = "Sofreu gols",
                   Value = "conceded",
                   Type = "sequency",
                   Active = true
               }, 
               new InsightEntity()
               {
                   Id = Guid.NewGuid(),
                   Name = "Ambas marcam",
                   Value = "bttsYes",
                   Type = "sequency",
                   Active = true
               }, 
               new InsightEntity()
               {
                   Id = Guid.NewGuid(),
                   Name = "Ambas marcam Não",
                   Value = "bttsNo",
                   Type = "sequency",
                   Active = false
               }, 
               new InsightEntity()
               {
                   Id = Guid.NewGuid(),
                   Name = "Over 2.5",
                   Value = "over25",
                   Type = "sequency",
                   Active = true
               }, 
               new InsightEntity()
               {
                   Id = Guid.NewGuid(),
                   Name = "Under 2.5",
                   Value = "under25",
                   Type = "sequency",
                   Active = false
               }, 
               new InsightEntity()
               {
                   Id = Guid.NewGuid(),
                   Name = "Cantos",
                   Value = "corner",
                   Type = "sequency",
                   Active = true
               }, 
               new InsightEntity()
               {
                   Id = Guid.NewGuid(),
                   Name = "Cartões",
                   Value = "cards",
                   Type = "sequency",
                   Active = true
               }, 
               new InsightEntity()
               {
                   Id = Guid.NewGuid(),
                   Name = "Pontos por jogo",
                   Value = "ppg",
                   Type = "comparativeHomeAway",
                   Active = true
               }, 
               new InsightEntity()
               {
                   Id = Guid.NewGuid(),
                   Name = "% de vitórias",
                   Value = "winsPercentage",
                   Type = "comparativeHomeAway",
                   Active = true
               }, 
               new InsightEntity()
               {
                   Id = Guid.NewGuid(),
                   Name = "Primeiro a marcar",
                   Value = "firstToScore",
                   Type = "comparativeHomeAway",
                   Active = true
               }, 
               new InsightEntity()
               {
                   Id = Guid.NewGuid(),
                   Name = "Gols marcados",
                   Value = "scoredHomeAway",
                   Type = "comparativeHomeAway",
                   Active = true
               }, 
               new InsightEntity()
               {
                   Id = Guid.NewGuid(),
                   Name = "Gols sofridos",
                   Value = "concededHomeAway",
                   Type = "comparativeHomeAway",
                   Active = true
               }, 
               new InsightEntity()
               {
                   Id = Guid.NewGuid(),
                   Name = "Finalizações",
                   Value = "shots",
                   Type = "comparativeHomeAway",
                   Active = true
               }, 
               new InsightEntity()
               {
                   Id = Guid.NewGuid(),
                   Name = "xG a favor",
                   Value = "favorXG",
                   Type = "comparativeHomeAway",
                   Active = true
               }, 
               new InsightEntity()
               {
                   Id = Guid.NewGuid(),
                   Name = "xG contra",
                   Value = "concededXG",
                   Type = "comparativeHomeAway",
                   Active = false
               }, 
               new InsightEntity()
               {
                   Id = Guid.NewGuid(),
                   Name = "Gols marcados no primeiro tempo",
                   Value = "goalsScoredFirstHalf",
                   Type = "comparativeGoals",
                   Active = true
               }, 
               new InsightEntity()
               {
                   Id = Guid.NewGuid(),
                   Name = "Gols sofridos no primeiro tempo",
                   Value = "goalsConcededFirstHalf",
                   Type = "comparativeGoals",
                   Active = true
               }
            );
            
            #endregion
        }
    }
}
