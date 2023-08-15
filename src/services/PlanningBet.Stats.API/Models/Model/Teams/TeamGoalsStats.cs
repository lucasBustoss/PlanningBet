using PlanningBet.Stats.API.Models.ApiResponse.Teams.TeamsResponse;

namespace PlanningBet.Stats.API.Models.Model.Teams
{
    public class TeamGoalsStats
    {
        public TeamGoalsStats(TeamStatsResponse statsResponse)
        {
            FirstGoalScoredOverall = statsResponse.TeamFirstGoalScoredOverall;
            FirstGoalScoredHome = statsResponse.TeamFirstGoalScoredHome;
            FirstGoalScoredAway = statsResponse.TeamFirstGoalScoredAway;
            GoalsScoredMin0To15Overall = statsResponse.TeamGoalsScoredMin0To15Overall;
            GoalsScoredMin16To30Overall = statsResponse.TeamGoalsScoredMin16To30Overall;
            GoalsScoredMin31To45Overall = statsResponse.TeamGoalsScoredMin31To45Overall;
            GoalsConcededMin0To15Overall = statsResponse.TeamGoalsConcededMin0To15Overall;
            GoalsConcededMin16To30Overall = statsResponse.TeamGoalsConcededMin16To30Overall;
            GoalsConcededMin31To45Overall = statsResponse.TeamGoalsConcededMin31To45Overall;
            GoalsScoredMin0To15Home = statsResponse.TeamGoalsScoredMin0To15Home;
            GoalsScoredMin16To30Home = statsResponse.TeamGoalsScoredMin16To30Home;
            GoalsScoredMin31To45Home = statsResponse.TeamGoalsScoredMin31To45Home;
            GoalsConcededMin0To15Home = statsResponse.TeamGoalsConcededMin0To15Home;
            GoalsConcededMin16To30Home = statsResponse.TeamGoalsConcededMin16To30Home;
            GoalsConcededMin31To45Home = statsResponse.TeamGoalsConcededMin31To45Home;
            GoalsScoredMin0To15Away = statsResponse.TeamGoalsScoredMin0To15Away;
            GoalsScoredMin16To30Away = statsResponse.TeamGoalsScoredMin16To30Away;
            GoalsScoredMin31To45Away = statsResponse.TeamGoalsScoredMin31To45Away;
            GoalsConcededMin0To15Away = statsResponse.TeamGoalsConcededMin0To15Away;
            GoalsConcededMin16To30Away = statsResponse.TeamGoalsConcededMin16To30Away;
            GoalsConcededMin31To45Away = statsResponse.TeamGoalsConcededMin31To45Away;
            GoalsScoredHome = statsResponse.GoalsScoredHome;
            GoalsScoredAway = statsResponse.GoalsScoredAway;
            GoalsConcededHome = statsResponse.GoalsConcededHome;
            GoalsConcededAway = statsResponse.GoalsConcededAway;
        }

        public int FirstGoalScoredOverall { get; set; }

        public int FirstGoalScoredHome { get; set; }

        public int FirstGoalScoredAway { get; set; }

        public int GoalsScoredMin0To15Overall { get; set; }

        public int GoalsScoredMin16To30Overall { get; set; }

        public int GoalsScoredMin31To45Overall { get; set; }

        public int GoalsConcededMin0To15Overall { get; set; }

        public int GoalsConcededMin16To30Overall { get; set; }

        public int GoalsConcededMin31To45Overall { get; set; }

        public int GoalsScoredMin0To15Home { get; set; }

        public int GoalsScoredMin16To30Home { get; set; }

        public int GoalsScoredMin31To45Home { get; set; }

        public int GoalsConcededMin0To15Home { get; set; }

        public int GoalsConcededMin16To30Home { get; set; }

        public int GoalsConcededMin31To45Home { get; set; }

        public int GoalsScoredMin0To15Away { get; set; }

        public int GoalsScoredMin16To30Away { get; set; }

        public int GoalsScoredMin31To45Away { get; set; }

        public int GoalsConcededMin0To15Away { get; set; }

        public int GoalsConcededMin16To30Away { get; set; }

        public int GoalsConcededMin31To45Away { get; set; }

        public List<string> GoalsScoredHome { get; set; }

        public List<string> GoalsScoredAway { get; set; }

        public List<string> GoalsConcededHome { get; set; }

        public List<string> GoalsConcededAway { get; set; }
    }
}
