using PlanningBet.Core.Models;
using PlanningBet.Stats.API.Models.ApiResponse.Leagues.LeagueStanding;

namespace PlanningBet.Stats.API.Models.Model.Leagues.Standing
{
    public class LeagueStanding
    {
        public LeagueStanding(Guid leagueId, LeagueStandingRequest leagueStandingRequest)
        {
            LeagueId = leagueId;
            Overall = new LeagueStandingTable(leagueStandingRequest.TableOverall);
            Home = new LeagueStandingTable(leagueStandingRequest.TableHome);
            Away = new LeagueStandingTable(leagueStandingRequest.TableAway);
        }

        public Guid LeagueId { get; set; }
        public LeagueStandingTable Overall { get; set; }
        public LeagueStandingTable Home { get; set; }
        public LeagueStandingTable Away { get; set; }
    }
}
