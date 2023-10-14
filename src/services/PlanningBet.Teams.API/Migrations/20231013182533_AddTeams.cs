using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlanningBet.Teams.API.Migrations
{
    /// <inheritdoc />
    public partial class AddTeams : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "teams",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    code = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "text", nullable: true),
                    clean_name = table.Column<string>(type: "text", nullable: true),
                    country = table.Column<string>(type: "text", nullable: true),
                    image_url = table.Column<string>(type: "text", nullable: true),
                    competition_id = table.Column<int>(type: "integer", nullable: false),
                    season = table.Column<string>(type: "text", nullable: true),
                    competition_type = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("p_k_teams", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "team_match",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    match_id = table.Column<int>(type: "integer", nullable: false),
                    round_id = table.Column<int>(type: "integer", nullable: false),
                    match_date_timestamp = table.Column<long>(type: "bigint", nullable: false),
                    competition_id = table.Column<int>(type: "integer", nullable: false),
                    match_status = table.Column<string>(type: "text", nullable: true),
                    home_team_id = table.Column<int>(type: "integer", nullable: false),
                    away_team_id = table.Column<int>(type: "integer", nullable: false),
                    home_team_goals = table.Column<int>(type: "integer", nullable: false),
                    away_team_goals = table.Column<int>(type: "integer", nullable: false),
                    team_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("p_k_team_match", x => x.id);
                    table.ForeignKey(
                        name: "f_k_team_match_teams_team_id",
                        column: x => x.team_id,
                        principalTable: "teams",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "teams_ftstats",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    team_id = table.Column<Guid>(type: "uuid", nullable: false),
                    win_percentage_f_t_home = table.Column<decimal>(type: "numeric", nullable: false),
                    win_percentage_f_t_away = table.Column<decimal>(type: "numeric", nullable: false),
                    win_percentage_f_t_overall = table.Column<decimal>(type: "numeric", nullable: false),
                    draw_percentage_f_t_home = table.Column<decimal>(type: "numeric", nullable: false),
                    draw_percentage_f_t_away = table.Column<decimal>(type: "numeric", nullable: false),
                    draw_percentage_f_t_overall = table.Column<decimal>(type: "numeric", nullable: false),
                    lose_percentage_f_t_home = table.Column<decimal>(type: "numeric", nullable: false),
                    lose_percentage_f_t_away = table.Column<decimal>(type: "numeric", nullable: false),
                    lose_percentage_f_t_overall = table.Column<decimal>(type: "numeric", nullable: false),
                    failed_to_score_percentage_f_t_home = table.Column<decimal>(type: "numeric", nullable: false),
                    failed_to_score_percentage_f_t_away = table.Column<decimal>(type: "numeric", nullable: false),
                    failed_to_score_percentage_f_t_overall = table.Column<decimal>(type: "numeric", nullable: false),
                    clean_sheet_percentage_f_t_home = table.Column<decimal>(type: "numeric", nullable: false),
                    clean_sheet_percentage_f_t_away = table.Column<decimal>(type: "numeric", nullable: false),
                    clean_sheet_percentage_f_t_overall = table.Column<decimal>(type: "numeric", nullable: false),
                    goals_scored_f_t_home = table.Column<int>(type: "integer", nullable: false),
                    goals_scored_f_t_away = table.Column<int>(type: "integer", nullable: false),
                    goals_scored_f_t_overall = table.Column<int>(type: "integer", nullable: false),
                    goals_conceded_f_t_home = table.Column<int>(type: "integer", nullable: false),
                    goals_conceded_f_t_away = table.Column<int>(type: "integer", nullable: false),
                    goals_conceded_f_t_overall = table.Column<int>(type: "integer", nullable: false),
                    avg_goals_scored_f_t_home = table.Column<decimal>(type: "numeric", nullable: false),
                    avg_goals_scored_f_t_away = table.Column<decimal>(type: "numeric", nullable: false),
                    avg_goals_scored_f_t_overall = table.Column<decimal>(type: "numeric", nullable: false),
                    avg_goals_conceded_f_t_home = table.Column<decimal>(type: "numeric", nullable: false),
                    avg_goals_conceded_f_t_away = table.Column<decimal>(type: "numeric", nullable: false),
                    avg_goals_conceded_f_t_overall = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("p_k_teams_ftstats", x => x.id);
                    table.ForeignKey(
                        name: "f_k_teams_ftstats_teams_team_id",
                        column: x => x.team_id,
                        principalTable: "teams",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "teams_generalstats",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    team_id = table.Column<Guid>(type: "uuid", nullable: false),
                    points_per_game_home = table.Column<decimal>(type: "numeric", nullable: false),
                    points_per_game_away = table.Column<decimal>(type: "numeric", nullable: false),
                    points_per_game_overall = table.Column<decimal>(type: "numeric", nullable: false),
                    matches_played_home = table.Column<int>(type: "integer", nullable: false),
                    matches_played_away = table.Column<decimal>(type: "numeric", nullable: false),
                    matches_played_overall = table.Column<decimal>(type: "numeric", nullable: false),
                    total_wins_home = table.Column<int>(type: "integer", nullable: false),
                    total_wins_away = table.Column<int>(type: "integer", nullable: false),
                    total_wins_overall = table.Column<int>(type: "integer", nullable: false),
                    wins_percentage_home = table.Column<decimal>(type: "numeric", nullable: false),
                    wins_percentage_away = table.Column<decimal>(type: "numeric", nullable: false),
                    wins_percentage_overall = table.Column<decimal>(type: "numeric", nullable: false),
                    first_goal_scored_percentage_home = table.Column<decimal>(type: "numeric", nullable: false),
                    first_goal_scored_percentage_away = table.Column<decimal>(type: "numeric", nullable: false),
                    first_goal_scored_percentage_overall = table.Column<decimal>(type: "numeric", nullable: false),
                    clean_sheet_percentage_home = table.Column<decimal>(type: "numeric", nullable: false),
                    clean_sheet_percentage_away = table.Column<decimal>(type: "numeric", nullable: false),
                    clean_sheet_percentage_overall = table.Column<decimal>(type: "numeric", nullable: false),
                    failed_to_score_percentage_home = table.Column<decimal>(type: "numeric", nullable: false),
                    failed_to_score_percentage_away = table.Column<decimal>(type: "numeric", nullable: false),
                    failed_to_score_percentage_overall = table.Column<decimal>(type: "numeric", nullable: false),
                    both_teams_to_scored_home = table.Column<int>(type: "integer", nullable: false),
                    both_teams_to_scored_away = table.Column<int>(type: "integer", nullable: false),
                    both_teams_to_scored_overall = table.Column<int>(type: "integer", nullable: false),
                    goals_scored_home = table.Column<int>(type: "integer", nullable: false),
                    goals_scored_away = table.Column<int>(type: "integer", nullable: false),
                    goals_scored_overall = table.Column<int>(type: "integer", nullable: false),
                    goals_conceded_home = table.Column<int>(type: "integer", nullable: false),
                    goals_conceded_away = table.Column<int>(type: "integer", nullable: false),
                    goals_conceded_overall = table.Column<int>(type: "integer", nullable: false),
                    avg_goals_scored_home = table.Column<decimal>(type: "numeric", nullable: false),
                    avg_goals_scored_away = table.Column<decimal>(type: "numeric", nullable: false),
                    avg_goals_scored_overall = table.Column<decimal>(type: "numeric", nullable: false),
                    avg_goals_conceded_home = table.Column<decimal>(type: "numeric", nullable: false),
                    avg_goals_conceded_away = table.Column<decimal>(type: "numeric", nullable: false),
                    avg_goals_conceded_overall = table.Column<decimal>(type: "numeric", nullable: false),
                    avg_total_goals_home = table.Column<decimal>(type: "numeric", nullable: false),
                    avg_total_goals_away = table.Column<decimal>(type: "numeric", nullable: false),
                    avg_total_goals_overall = table.Column<decimal>(type: "numeric", nullable: false),
                    avg_shots_home = table.Column<decimal>(type: "numeric", nullable: false),
                    avg_shots_away = table.Column<decimal>(type: "numeric", nullable: false),
                    avg_shots_overall = table.Column<decimal>(type: "numeric", nullable: false),
                    avg_shots_on_target_home = table.Column<decimal>(type: "numeric", nullable: false),
                    avg_shots_on_target_away = table.Column<decimal>(type: "numeric", nullable: false),
                    avg_shots_on_target_overall = table.Column<decimal>(type: "numeric", nullable: false),
                    xg_for_home = table.Column<decimal>(type: "numeric", nullable: false),
                    xg_for_away = table.Column<decimal>(type: "numeric", nullable: false),
                    xg_for_overall = table.Column<decimal>(type: "numeric", nullable: false),
                    xg_against_home = table.Column<decimal>(type: "numeric", nullable: false),
                    xg_against_away = table.Column<decimal>(type: "numeric", nullable: false),
                    xg_against_overall = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("p_k_teams_generalstats", x => x.id);
                    table.ForeignKey(
                        name: "f_k_teams_generalstats_teams_team_id",
                        column: x => x.team_id,
                        principalTable: "teams",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "teams_goalsstats",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    team_id = table.Column<Guid>(type: "uuid", nullable: false),
                    first_goal_scored_overall = table.Column<int>(type: "integer", nullable: false),
                    first_goal_scored_home = table.Column<int>(type: "integer", nullable: false),
                    first_goal_scored_away = table.Column<int>(type: "integer", nullable: false),
                    goals_scored_min0_to15_overall = table.Column<int>(type: "integer", nullable: false),
                    goals_scored_min16_to30_overall = table.Column<int>(type: "integer", nullable: false),
                    goals_scored_min31_to45_overall = table.Column<int>(type: "integer", nullable: false),
                    goals_conceded_min0_to15_overall = table.Column<int>(type: "integer", nullable: false),
                    goals_conceded_min16_to30_overall = table.Column<int>(type: "integer", nullable: false),
                    goals_conceded_min31_to45_overall = table.Column<int>(type: "integer", nullable: false),
                    goals_scored_min0_to15_home = table.Column<int>(type: "integer", nullable: false),
                    goals_scored_min16_to30_home = table.Column<int>(type: "integer", nullable: false),
                    goals_scored_min31_to45_home = table.Column<int>(type: "integer", nullable: false),
                    goals_conceded_min0_to15_home = table.Column<int>(type: "integer", nullable: false),
                    goals_conceded_min16_to30_home = table.Column<int>(type: "integer", nullable: false),
                    goals_conceded_min31_to45_home = table.Column<int>(type: "integer", nullable: false),
                    goals_scored_min0_to15_away = table.Column<int>(type: "integer", nullable: false),
                    goals_scored_min16_to30_away = table.Column<int>(type: "integer", nullable: false),
                    goals_scored_min31_to45_away = table.Column<int>(type: "integer", nullable: false),
                    goals_conceded_min0_to15_away = table.Column<int>(type: "integer", nullable: false),
                    goals_conceded_min16_to30_away = table.Column<int>(type: "integer", nullable: false),
                    goals_conceded_min31_to45_away = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("p_k_teams_goalsstats", x => x.id);
                    table.ForeignKey(
                        name: "f_k_teams_goalsstats_teams_team_id",
                        column: x => x.team_id,
                        principalTable: "teams",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "teams_htstats",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    team_id = table.Column<Guid>(type: "uuid", nullable: false),
                    win_percentage_f_t_home = table.Column<decimal>(type: "numeric", nullable: false),
                    win_percentage_f_t_away = table.Column<decimal>(type: "numeric", nullable: false),
                    win_percentage_f_t_overall = table.Column<decimal>(type: "numeric", nullable: false),
                    draw_percentage_f_t_home = table.Column<decimal>(type: "numeric", nullable: false),
                    draw_percentage_f_t_away = table.Column<decimal>(type: "numeric", nullable: false),
                    draw_percentage_f_t_overall = table.Column<decimal>(type: "numeric", nullable: false),
                    lose_percentage_f_t_home = table.Column<decimal>(type: "numeric", nullable: false),
                    lose_percentage_f_t_away = table.Column<decimal>(type: "numeric", nullable: false),
                    lose_percentage_f_t_overall = table.Column<decimal>(type: "numeric", nullable: false),
                    failed_to_score_percentage_f_t_home = table.Column<decimal>(type: "numeric", nullable: false),
                    failed_to_score_percentage_f_t_away = table.Column<decimal>(type: "numeric", nullable: false),
                    failed_to_score_percentage_f_t_overall = table.Column<decimal>(type: "numeric", nullable: false),
                    clean_sheet_percentage_f_t_home = table.Column<decimal>(type: "numeric", nullable: false),
                    clean_sheet_percentage_f_t_away = table.Column<decimal>(type: "numeric", nullable: false),
                    clean_sheet_percentage_f_t_overall = table.Column<decimal>(type: "numeric", nullable: false),
                    goals_scored_f_t_home = table.Column<int>(type: "integer", nullable: false),
                    goals_scored_f_t_away = table.Column<int>(type: "integer", nullable: false),
                    goals_scored_f_t_overall = table.Column<int>(type: "integer", nullable: false),
                    goals_conceded_f_t_home = table.Column<int>(type: "integer", nullable: false),
                    goals_conceded_f_t_away = table.Column<int>(type: "integer", nullable: false),
                    goals_conceded_f_t_overall = table.Column<int>(type: "integer", nullable: false),
                    avg_goals_scored_f_t_home = table.Column<decimal>(type: "numeric", nullable: false),
                    avg_goals_scored_f_t_away = table.Column<decimal>(type: "numeric", nullable: false),
                    avg_goals_scored_f_t_overall = table.Column<decimal>(type: "numeric", nullable: false),
                    avg_goals_conceded_f_t_home = table.Column<decimal>(type: "numeric", nullable: false),
                    avg_goals_conceded_f_t_away = table.Column<decimal>(type: "numeric", nullable: false),
                    avg_goals_conceded_f_t_overall = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("p_k_teams_htstats", x => x.id);
                    table.ForeignKey(
                        name: "f_k_teams_htstats_teams_team_id",
                        column: x => x.team_id,
                        principalTable: "teams",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_team_match_team_id",
                table: "team_match",
                column: "team_id");

            migrationBuilder.CreateIndex(
                name: "IX_teams_ftstats_team_id",
                table: "teams_ftstats",
                column: "team_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_teams_generalstats_team_id",
                table: "teams_generalstats",
                column: "team_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_teams_goalsstats_team_id",
                table: "teams_goalsstats",
                column: "team_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_teams_htstats_team_id",
                table: "teams_htstats",
                column: "team_id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "team_match");

            migrationBuilder.DropTable(
                name: "teams_ftstats");

            migrationBuilder.DropTable(
                name: "teams_generalstats");

            migrationBuilder.DropTable(
                name: "teams_goalsstats");

            migrationBuilder.DropTable(
                name: "teams_htstats");

            migrationBuilder.DropTable(
                name: "teams");
        }
    }
}
