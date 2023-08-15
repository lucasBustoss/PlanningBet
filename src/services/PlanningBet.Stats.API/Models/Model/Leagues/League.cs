using PlanningBet.Core.Models;
using PlanningBet.Stats.API.Models.ApiResponse.Leagues;

namespace PlanningBet.Stats.API.Models.Model.Leagues
{
    public class League : BaseModel
    {
        public League(LeagueResponse leagueResponse, string seasonName, int seasonId, string imageUrl)
        {
            Id = Guid.NewGuid();
            Code = seasonId;
            Name = leagueResponse.LeagueName;
            Country = leagueResponse.LeagueCountry;
            Image = leagueResponse.LeagueImage;
            SeasonName = seasonName;
            ImageUrl = imageUrl;
        }

        public int Code { get; private set; }
        public string Name { get; private set; }
        public string Country { get; private set; }
        public string Image { get; private set; }
        public string SeasonName { get; private set; }
        public string ImageUrl { get; private set; }
    }
}
