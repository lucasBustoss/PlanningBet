using PlanningBet.Stats.API.Models.ApiResponse.Teams.TeamsResponse;

namespace PlanningBet.Stats.API.Models.Model.Teams
{
    public class Team
    {
        public Team(TeamResponse teamResponse)
        {
            Id = Guid.NewGuid();
            Code = teamResponse.TeamId;
            Name = teamResponse.TeamName;
            CleanName = teamResponse.TeamCleanName;
            Country = teamResponse.TeamCountry;
            ImageUrl = teamResponse.TeamImageUrl;
            CompetitionId = teamResponse.TeamCompetitionId;
            Season = teamResponse.TeamSeason;
            CompetitionType = teamResponse.TeamCompetitionType;
            GeneralStats = new TeamGeneralStats(teamResponse.TeamStats);
            HTStats = new TeamHTStats(teamResponse.TeamStats);
            FTStats = new TeamFTStats(teamResponse.TeamStats);
            GoalsStats = new TeamGoalsStats(teamResponse.TeamStats);
        }

        public Guid Id { get; private set; }

        public int Code { get; private set; }

        public string Name { get; private set; }

        public string CleanName { get; private set; }

        public string Country { get; private set; }

        public string ImageUrl { get; private set; }

        public int CompetitionId { get; private set; }

        public string Season { get; private set; }

        public string CompetitionType { get; private set; }

        public TeamGeneralStats GeneralStats { get; private set; }

        public TeamHTStats HTStats { get; private set; }

        public TeamFTStats FTStats { get; private set; }

        public TeamGoalsStats GoalsStats { get; private set; }
    }
}
