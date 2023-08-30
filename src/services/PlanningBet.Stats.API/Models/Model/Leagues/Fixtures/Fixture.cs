using PlanningBet.Stats.API.Models.ApiResponse.Fixtures;

namespace PlanningBet.Stats.API.Models.Model.Leagues.Matches
{
    public class Fixture
    {
        public Fixture(FixtureResponse fixtureResponse)
        {
            MatchId = fixtureResponse.MatchId;
            RoundId = fixtureResponse.RoundId;
            MatchDateTimestamp = fixtureResponse.Timestamp;
            CompetitionId = fixtureResponse.CompetitionId;
            MatchStatus = fixtureResponse.MatchStatus;
            HomeTeamCode = fixtureResponse.TeamHomeId;
            HomeTeamGoals = fixtureResponse.TeamHomeGoals;
            AwayTeamCode = fixtureResponse.TeamAwayId;
            AwayTeamGoals = fixtureResponse.TeamAwayGoals;
        }

        public int MatchId { get; set; }

        public int RoundId { get; set; }

        public long MatchDateTimestamp { get; set; }

        public int CompetitionId { get; set; }

        public string MatchStatus { get; set; }

        public int HomeTeamCode { get; set; }

        public int HomeTeamGoals { get; set; }

        public int AwayTeamCode { get; set; }

        public int AwayTeamGoals { get; set; }
    }
}
