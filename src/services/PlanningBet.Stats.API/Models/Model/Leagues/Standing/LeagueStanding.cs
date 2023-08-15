using PlanningBet.Core.Models;
using PlanningBet.Stats.API.Models.ApiResponse.Leagues.LeagueStanding;

namespace PlanningBet.Stats.API.Models.Model.Leagues.Standing
{
    public class LeagueStanding
    {
        public LeagueStanding(LeagueStandingRequest leagueStandingRequest)
        {
            Overall = new LeagueStandingTable(leagueStandingRequest.TableOverall);
            Home = new LeagueStandingTable(leagueStandingRequest.TableHome);
            Away = new LeagueStandingTable(leagueStandingRequest.TableAway);
        }

        public LeagueStandingTable Overall { get; set; }
        public LeagueStandingTable Home { get; set; }
        public LeagueStandingTable Away { get; set; }
    }
}
