namespace PlanningBet.Stats.API.Models.Model.Teams.TeamMatches
{
    public class TeamMatchesGeneral
    {
        public TeamMatchesGeneral()
        {
            OverallMatches = new TeamMatchesType();
            HomeMatches = new TeamMatchesType();
            AwayMatches = new TeamMatchesType();
        }

        public TeamMatchesType OverallMatches { get; set; }
        public TeamMatchesType HomeMatches { get; set; }
        public TeamMatchesType AwayMatches { get; set; }
    }
}
