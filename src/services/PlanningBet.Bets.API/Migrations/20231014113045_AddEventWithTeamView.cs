using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlanningBet.Bets.API.Migrations
{
    /// <inheritdoc />
    public partial class AddEventWithTeamView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"CREATE VIEW events_with_teams_view AS 
                SELECT  
	                events.id,
	                event_code, 
	                home_team.clean_name as home_team_name,
	                away_team.clean_name as away_team_name,
	                DATE,
	                profit, 
	                commission
                FROM events
                INNER JOIN teams home_team
	                ON home_team.id = events.home_team_id
                INNER JOIN teams away_team
	                ON away_team.id = events.away_team_id"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW IF EXISTS events_with_teams_view");
        }
    }
}
