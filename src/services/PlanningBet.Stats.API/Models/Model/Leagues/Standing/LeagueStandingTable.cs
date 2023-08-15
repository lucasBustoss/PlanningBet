using PlanningBet.Core.Models;
using PlanningBet.Stats.API.Enums;
using PlanningBet.Stats.API.Models.ApiResponse.Leagues.LeagueStanding;
using System.Collections.Generic;

namespace PlanningBet.Stats.API.Models.Model.Leagues.Standing
{
    public class LeagueStandingTable : BaseModel
    {
        public LeagueStandingTable(List<LeagueStandingTeamRequest> tableTeams)
        {
            Id = Guid.NewGuid();
            Teams = GetTeams(tableTeams);
        }

        public List<LeagueStandingTableTeam> Teams { get; set; }

        public List<LeagueStandingTableTeam> GetTeams(List<LeagueStandingTeamRequest> tableTeams)
        {
            List<LeagueStandingTableTeam> teams = new List<LeagueStandingTableTeam>();
            
            foreach (var tableTeam in tableTeams)
            {
                LeagueStandingTableTeam team = new LeagueStandingTableTeam(tableTeam);
                teams.Add(team);
            }

            return teams;
        }
    }
}
