using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using PlanningBet.Stats.API.Models.ApiResponse.Leagues.LeagueStatsInfo;

namespace PlanningBet.Stats.API.Models.Model.Leagues
{
    public class LeagueStatsInfo
    {
        public LeagueStatsInfo(LeagueStatsInfoRequest leagueStatsInfoRequest)
        {
            IsoCode = leagueStatsInfoRequest.IsoCode;
            Country = leagueStatsInfoRequest.CountryName;
            Name = leagueStatsInfoRequest.LeagueName;

            if (Country == "Asia" ||
                Country == "Europe" ||
                Country == "Oceania" ||
                Country == "South America" ||
                Country == "North America" ||
                Country == "International")
            {
                ImageUrl = leagueStatsInfoRequest.LeagueImage;
            }
            else
            {
                ImageUrl = $"https://flagcdn.com/${leagueStatsInfoRequest.IsoCode}.svg";
            }
        }

        public string IsoCode { get; private set; }
        public string Country { get; private set; }
        public string Name { get; private set; }
        public string ImageUrl { get; private set; }
    }
}
