using PlanningBet.Stats.API.Models.ApiResponse.Leagues.LeagueStanding;

namespace PlanningBet.Stats.API.Models.Model.Leagues.Standing
{
    public class LeagueStandingTableTeam
    {
        public LeagueStandingTableTeam(LeagueStandingTeamRequest teamRequest)
        {
            TeamCode = teamRequest.TeamCode;
            Position = teamRequest.TeamPosition;
            Points = teamRequest.TeamPoints;
            MatchesPlayed = teamRequest.TeamMatchesPlayed;
            GoalsScored = teamRequest.TeamGoalsScored;
            GoalsConceded = teamRequest.TeamGoalsConceded;
            GoalsDifference = teamRequest.TeamGoalsDifference;
            Wins = teamRequest.TeamWins;
            Draws = teamRequest.TeamDraws;
            Losses = teamRequest.TeamLosses;
        }

        public int TeamCode { get; set; }
        public int Position { get; set; }
        public int Points { get; set; }
        public int MatchesPlayed { get; set; }
        public int GoalsScored { get; set; }
        public int GoalsConceded { get; set; }
        public int GoalsDifference { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Losses { get; set; }
    }
}
