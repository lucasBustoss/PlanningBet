using PlanningBet.Core.Models;
using PlanningBet.Teams.API.Entities.TeamMatches;

namespace PlanningBet.Teams.API.Entities
{
    public class Team : BaseModel
    {
        public Team() { }

        public int Code { get; set; }
        public string Name { get; set; }
        public string CleanName { get; set; }
        public string Country { get; set; }
        public string ImageUrl { get; set; }
        public int CompetitionId { get; set; }
        public string Season { get; set; }
        public string CompetitionType { get; set; }
        public TeamGeneralStats GeneralStats { get; set; }
        public TeamHTStats HTStats { get; set; }
        public TeamFTStats FTStats { get; set; }
        public TeamGoalsStats GoalsStats { get; set; }
        public List<TeamMatch> Matches { get; set; }
    }
}
