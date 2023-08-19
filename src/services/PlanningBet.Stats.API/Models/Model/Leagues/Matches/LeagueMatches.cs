using PlanningBet.Stats.API.Models.ApiResponse.Leagues.LeagueMatches;
using System.Text.Json.Serialization;

namespace PlanningBet.Stats.API.Models.Model.Leagues.Matches
{
    public class LeagueMatches
    {
        public LeagueMatches(LeagueMatchesResponse leagueMatchesResponse)
        {
            MatchId = leagueMatchesResponse.MatchId;
            RoundId = leagueMatchesResponse.RoundId;
            MatchDateTimestamp = leagueMatchesResponse.Timestamp;
            CompetitionId = leagueMatchesResponse.CompetitionId;
            MatchStatus = leagueMatchesResponse.MatchStatus;

            HomeTeam = new LeagueMatchesTeam();
            HomeTeam.Code = leagueMatchesResponse.TeamHomeId;
            HomeTeam.Name = leagueMatchesResponse.TeamHomeName;
            HomeTeam.Logo = leagueMatchesResponse.TeamHomeLogo;
            HomeTeam.Goals = leagueMatchesResponse.TeamHomeGoals;

            AwayTeam = new LeagueMatchesTeam();
            AwayTeam.Code = leagueMatchesResponse.TeamAwayId;
            AwayTeam.Name = leagueMatchesResponse.TeamAwayName;
            AwayTeam.Logo = leagueMatchesResponse.TeamAwayLogo;
            AwayTeam.Goals = leagueMatchesResponse.TeamAwayGoals;
        }

        public int MatchId { get; set; }

        public int RoundId { get; set; }

        public long MatchDateTimestamp { get; set; }

        public int CompetitionId { get; set; }

        public string MatchStatus { get; set; }

        public LeagueMatchesTeam HomeTeam { get; set; }

        public LeagueMatchesTeam AwayTeam { get; set; }
    }
}
