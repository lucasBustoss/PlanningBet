using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlanningBet.Teams.API.Migrations
{
    /// <inheritdoc />
    public partial class AddStats : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams_FTStats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TeamId = table.Column<Guid>(type: "uuid", nullable: false),
                    WinPercentageFTHome = table.Column<decimal>(type: "numeric", nullable: false),
                    WinPercentageFTAway = table.Column<decimal>(type: "numeric", nullable: false),
                    WinPercentageFTOverall = table.Column<decimal>(type: "numeric", nullable: false),
                    DrawPercentageFTHome = table.Column<decimal>(type: "numeric", nullable: false),
                    DrawPercentageFTAway = table.Column<decimal>(type: "numeric", nullable: false),
                    DrawPercentageFTOverall = table.Column<decimal>(type: "numeric", nullable: false),
                    LosePercentageFTHome = table.Column<decimal>(type: "numeric", nullable: false),
                    LosePercentageFTAway = table.Column<decimal>(type: "numeric", nullable: false),
                    LosePercentageFTOverall = table.Column<decimal>(type: "numeric", nullable: false),
                    FailedToScorePercentageFTHome = table.Column<decimal>(type: "numeric", nullable: false),
                    FailedToScorePercentageFTAway = table.Column<decimal>(type: "numeric", nullable: false),
                    FailedToScorePercentageFTOverall = table.Column<decimal>(type: "numeric", nullable: false),
                    CleanSheetPercentageFTHome = table.Column<decimal>(type: "numeric", nullable: false),
                    CleanSheetPercentageFTAway = table.Column<decimal>(type: "numeric", nullable: false),
                    CleanSheetPercentageFTOverall = table.Column<decimal>(type: "numeric", nullable: false),
                    GoalsScoredFTHome = table.Column<int>(type: "integer", nullable: false),
                    GoalsScoredFTAway = table.Column<int>(type: "integer", nullable: false),
                    GoalsScoredFTOverall = table.Column<int>(type: "integer", nullable: false),
                    GoalsConcededFTHome = table.Column<int>(type: "integer", nullable: false),
                    GoalsConcededFTAway = table.Column<int>(type: "integer", nullable: false),
                    GoalsConcededFTOverall = table.Column<int>(type: "integer", nullable: false),
                    AvgGoalsScoredFTHome = table.Column<decimal>(type: "numeric", nullable: false),
                    AvgGoalsScoredFTAway = table.Column<decimal>(type: "numeric", nullable: false),
                    AvgGoalsScoredFTOverall = table.Column<decimal>(type: "numeric", nullable: false),
                    AvgGoalsConcededFTHome = table.Column<decimal>(type: "numeric", nullable: false),
                    AvgGoalsConcededFTAway = table.Column<decimal>(type: "numeric", nullable: false),
                    AvgGoalsConcededFTOverall = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams_FTStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_FTStats_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teams_GeneralStats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TeamId = table.Column<Guid>(type: "uuid", nullable: false),
                    PointsPerGameHome = table.Column<decimal>(type: "numeric", nullable: false),
                    PointsPerGameAway = table.Column<decimal>(type: "numeric", nullable: false),
                    PointsPerGameOverall = table.Column<decimal>(type: "numeric", nullable: false),
                    MatchesPlayedHome = table.Column<int>(type: "integer", nullable: false),
                    MatchesPlayedAway = table.Column<decimal>(type: "numeric", nullable: false),
                    MatchesPlayedOverall = table.Column<decimal>(type: "numeric", nullable: false),
                    TotalWinsHome = table.Column<int>(type: "integer", nullable: false),
                    TotalWinsAway = table.Column<int>(type: "integer", nullable: false),
                    TotalWinsOverall = table.Column<int>(type: "integer", nullable: false),
                    WinsPercentageHome = table.Column<decimal>(type: "numeric", nullable: false),
                    WinsPercentageAway = table.Column<decimal>(type: "numeric", nullable: false),
                    WinsPercentageOverall = table.Column<decimal>(type: "numeric", nullable: false),
                    FirstGoalScoredPercentageHome = table.Column<decimal>(type: "numeric", nullable: false),
                    FirstGoalScoredPercentageAway = table.Column<decimal>(type: "numeric", nullable: false),
                    FirstGoalScoredPercentageOverall = table.Column<decimal>(type: "numeric", nullable: false),
                    CleanSheetPercentageHome = table.Column<decimal>(type: "numeric", nullable: false),
                    CleanSheetPercentageAway = table.Column<decimal>(type: "numeric", nullable: false),
                    CleanSheetPercentageOverall = table.Column<decimal>(type: "numeric", nullable: false),
                    FailedToScorePercentageHome = table.Column<decimal>(type: "numeric", nullable: false),
                    FailedToScorePercentageAway = table.Column<decimal>(type: "numeric", nullable: false),
                    FailedToScorePercentageOverall = table.Column<decimal>(type: "numeric", nullable: false),
                    BothTeamsToScoredHome = table.Column<int>(type: "integer", nullable: false),
                    BothTeamsToScoredAway = table.Column<int>(type: "integer", nullable: false),
                    BothTeamsToScoredOverall = table.Column<int>(type: "integer", nullable: false),
                    GoalsScoredHome = table.Column<int>(type: "integer", nullable: false),
                    GoalsScoredAway = table.Column<int>(type: "integer", nullable: false),
                    GoalsScoredOverall = table.Column<int>(type: "integer", nullable: false),
                    GoalsConcededHome = table.Column<int>(type: "integer", nullable: false),
                    GoalsConcededAway = table.Column<int>(type: "integer", nullable: false),
                    GoalsConcededOverall = table.Column<int>(type: "integer", nullable: false),
                    AvgGoalsScoredHome = table.Column<decimal>(type: "numeric", nullable: false),
                    AvgGoalsScoredAway = table.Column<decimal>(type: "numeric", nullable: false),
                    AvgGoalsScoredOverall = table.Column<decimal>(type: "numeric", nullable: false),
                    AvgGoalsConcededHome = table.Column<decimal>(type: "numeric", nullable: false),
                    AvgGoalsConcededAway = table.Column<decimal>(type: "numeric", nullable: false),
                    AvgGoalsConcededOverall = table.Column<decimal>(type: "numeric", nullable: false),
                    AvgTotalGoalsHome = table.Column<decimal>(type: "numeric", nullable: false),
                    AvgTotalGoalsAway = table.Column<decimal>(type: "numeric", nullable: false),
                    AvgTotalGoalsOverall = table.Column<decimal>(type: "numeric", nullable: false),
                    AvgShotsHome = table.Column<decimal>(type: "numeric", nullable: false),
                    AvgShotsAway = table.Column<decimal>(type: "numeric", nullable: false),
                    AvgShotsOverall = table.Column<decimal>(type: "numeric", nullable: false),
                    AvgShotsOnTargetHome = table.Column<decimal>(type: "numeric", nullable: false),
                    AvgShotsOnTargetAway = table.Column<decimal>(type: "numeric", nullable: false),
                    AvgShotsOnTargetOverall = table.Column<decimal>(type: "numeric", nullable: false),
                    XgForHome = table.Column<decimal>(type: "numeric", nullable: false),
                    XgForAway = table.Column<decimal>(type: "numeric", nullable: false),
                    XgForOverall = table.Column<decimal>(type: "numeric", nullable: false),
                    XgAgainstHome = table.Column<decimal>(type: "numeric", nullable: false),
                    XgAgainstAway = table.Column<decimal>(type: "numeric", nullable: false),
                    XgAgainstOverall = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams_GeneralStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_GeneralStats_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teams_GoalsStats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TeamId = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstGoalScoredOverall = table.Column<int>(type: "integer", nullable: false),
                    FirstGoalScoredHome = table.Column<int>(type: "integer", nullable: false),
                    FirstGoalScoredAway = table.Column<int>(type: "integer", nullable: false),
                    GoalsScoredMin0To15Overall = table.Column<int>(type: "integer", nullable: false),
                    GoalsScoredMin16To30Overall = table.Column<int>(type: "integer", nullable: false),
                    GoalsScoredMin31To45Overall = table.Column<int>(type: "integer", nullable: false),
                    GoalsConcededMin0To15Overall = table.Column<int>(type: "integer", nullable: false),
                    GoalsConcededMin16To30Overall = table.Column<int>(type: "integer", nullable: false),
                    GoalsConcededMin31To45Overall = table.Column<int>(type: "integer", nullable: false),
                    GoalsScoredMin0To15Home = table.Column<int>(type: "integer", nullable: false),
                    GoalsScoredMin16To30Home = table.Column<int>(type: "integer", nullable: false),
                    GoalsScoredMin31To45Home = table.Column<int>(type: "integer", nullable: false),
                    GoalsConcededMin0To15Home = table.Column<int>(type: "integer", nullable: false),
                    GoalsConcededMin16To30Home = table.Column<int>(type: "integer", nullable: false),
                    GoalsConcededMin31To45Home = table.Column<int>(type: "integer", nullable: false),
                    GoalsScoredMin0To15Away = table.Column<int>(type: "integer", nullable: false),
                    GoalsScoredMin16To30Away = table.Column<int>(type: "integer", nullable: false),
                    GoalsScoredMin31To45Away = table.Column<int>(type: "integer", nullable: false),
                    GoalsConcededMin0To15Away = table.Column<int>(type: "integer", nullable: false),
                    GoalsConcededMin16To30Away = table.Column<int>(type: "integer", nullable: false),
                    GoalsConcededMin31To45Away = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams_GoalsStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_GoalsStats_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teams_HTStats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TeamId = table.Column<Guid>(type: "uuid", nullable: false),
                    WinPercentageFTHome = table.Column<decimal>(type: "numeric", nullable: false),
                    WinPercentageFTAway = table.Column<decimal>(type: "numeric", nullable: false),
                    WinPercentageFTOverall = table.Column<decimal>(type: "numeric", nullable: false),
                    DrawPercentageFTHome = table.Column<decimal>(type: "numeric", nullable: false),
                    DrawPercentageFTAway = table.Column<decimal>(type: "numeric", nullable: false),
                    DrawPercentageFTOverall = table.Column<decimal>(type: "numeric", nullable: false),
                    LosePercentageFTHome = table.Column<decimal>(type: "numeric", nullable: false),
                    LosePercentageFTAway = table.Column<decimal>(type: "numeric", nullable: false),
                    LosePercentageFTOverall = table.Column<decimal>(type: "numeric", nullable: false),
                    FailedToScorePercentageFTHome = table.Column<decimal>(type: "numeric", nullable: false),
                    FailedToScorePercentageFTAway = table.Column<decimal>(type: "numeric", nullable: false),
                    FailedToScorePercentageFTOverall = table.Column<decimal>(type: "numeric", nullable: false),
                    CleanSheetPercentageFTHome = table.Column<decimal>(type: "numeric", nullable: false),
                    CleanSheetPercentageFTAway = table.Column<decimal>(type: "numeric", nullable: false),
                    CleanSheetPercentageFTOverall = table.Column<decimal>(type: "numeric", nullable: false),
                    GoalsScoredFTHome = table.Column<int>(type: "integer", nullable: false),
                    GoalsScoredFTAway = table.Column<int>(type: "integer", nullable: false),
                    GoalsScoredFTOverall = table.Column<int>(type: "integer", nullable: false),
                    GoalsConcededFTHome = table.Column<int>(type: "integer", nullable: false),
                    GoalsConcededFTAway = table.Column<int>(type: "integer", nullable: false),
                    GoalsConcededFTOverall = table.Column<int>(type: "integer", nullable: false),
                    AvgGoalsScoredFTHome = table.Column<decimal>(type: "numeric", nullable: false),
                    AvgGoalsScoredFTAway = table.Column<decimal>(type: "numeric", nullable: false),
                    AvgGoalsScoredFTOverall = table.Column<decimal>(type: "numeric", nullable: false),
                    AvgGoalsConcededFTHome = table.Column<decimal>(type: "numeric", nullable: false),
                    AvgGoalsConcededFTAway = table.Column<decimal>(type: "numeric", nullable: false),
                    AvgGoalsConcededFTOverall = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams_HTStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_HTStats_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teams_FTStats_TeamId",
                table: "Teams_FTStats",
                column: "TeamId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_GeneralStats_TeamId",
                table: "Teams_GeneralStats",
                column: "TeamId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_GoalsStats_TeamId",
                table: "Teams_GoalsStats",
                column: "TeamId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_HTStats_TeamId",
                table: "Teams_HTStats",
                column: "TeamId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teams_FTStats");

            migrationBuilder.DropTable(
                name: "Teams_GeneralStats");

            migrationBuilder.DropTable(
                name: "Teams_GoalsStats");

            migrationBuilder.DropTable(
                name: "Teams_HTStats");
        }
    }
}
