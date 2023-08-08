namespace PlanningBet.Users.API.Models.User
{
    public class UserParameters
    {
        public IEnumerable<Guid> FavoriteTeams { get; set; }
        public IEnumerable<Guid> FavoriteMatches { get; set; }
        public IEnumerable<Guid> FavoriteLeagues { get; set; }
        public IEnumerable<string> Insights { get; set; }
    }
}
