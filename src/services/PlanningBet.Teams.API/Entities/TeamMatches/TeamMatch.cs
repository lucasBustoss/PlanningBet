using PlanningBet.Core.Models;

namespace PlanningBet.Teams.API.Entities.TeamMatches
{
    public class TeamMatch : BaseModel
    {
        public int MatchId { get; set; }

        public int RoundId { get; set; }

        public long MatchDateTimestamp { get; set; }

        public int CompetitionId { get; set; }

        public string MatchStatus { get; set; }

        public int HomeTeamId { get; set; }

        public int AwayTeamId { get; set; }

        public int HomeTeamGoals { get; set; }

        public int AwayTeamGoals { get; set; }
    }
}
