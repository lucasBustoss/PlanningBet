using PlanningBet.Stats.API.Models.Model.Leagues.Matches;

namespace PlanningBet.Stats.API.Models.Model.Teams.TeamMatches
{
    public class TeamMatchesType
    {
        public TeamMatchesType()
        {
            LastMatches = new List<Fixture>();
            NextMatches = new List<Fixture>();
        }

        public List<Fixture> LastMatches { get; set; }
        public List<Fixture> NextMatches { get; set; }
    }
}
