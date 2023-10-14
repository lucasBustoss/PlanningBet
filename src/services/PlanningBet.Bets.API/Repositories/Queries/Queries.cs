using Microsoft.Extensions.Logging;
using System.Text;

namespace PlanningBet.Bets.API.Repositories.Queries
{
    public static class Queries
    {
        public static string GetEventsWithTeams()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SELECT ");
            sb.AppendLine("events.id, ");
	        sb.AppendLine("event_code, ");
	        sb.AppendLine("home_team_id, ");
	        sb.AppendLine("home_team.clean_name as home_name, ");
	        sb.AppendLine("away_team_id, ");
            sb.AppendLine("away_team.clean_name as away_name, ");
	        sb.AppendLine("DATE, ");
	        sb.AppendLine("bet_count, ");
            sb.AppendLine("profit, ");
            sb.AppendLine("commission ");
            
            sb.AppendLine("FROM events ");
            
            sb.AppendLine("INNER JOIN teams home_team ");
            sb.AppendLine("ON home_team.id = events.home_team_id ");
            
            sb.AppendLine("INNER JOIN teams away_team ");
            sb.AppendLine("ON away_team.id = events.away_team_id ");

            return sb.ToString();
        }
    }
}
