using System.Text.Json.Serialization;

namespace PlanningBet.Stats.API.Models.Model.Leagues.Matches
{
    public class LeagueMatchesTeam
    {
        public int Code { get; set; }

        public string Name { get; set; }

        public string Logo { get; set; }

        public int Goals { get; set; }
    }
}
