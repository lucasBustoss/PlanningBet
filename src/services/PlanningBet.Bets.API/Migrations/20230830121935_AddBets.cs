using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlanningBet.Bets.API.Migrations
{
    /// <inheritdoc />
    public partial class AddBets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    EventCode = table.Column<string>(type: "text", nullable: true),
                    HomeTeamId = table.Column<Guid>(type: "uuid", nullable: false),
                    AwayTeamId = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    BetCount = table.Column<int>(type: "integer", nullable: false),
                    Commission = table.Column<decimal>(type: "numeric", nullable: false),
                    Profit = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_Events_HomeTeamId",
                        column: x => x.HomeTeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teams_Events_AwayTeamId",
                        column: x => x.AwayTeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    EventId = table.Column<Guid>(type: "uuid", nullable: false),
                    EventCode = table.Column<string>(type: "text", nullable: true),
                    MarketId = table.Column<string>(type: "text", nullable: true),
                    SelectionId = table.Column<int>(type: "integer", nullable: false),
                    BetId = table.Column<string>(type: "text", nullable: true),
                    PlacedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Side = table.Column<string>(type: "text", nullable: true),
                    OddRequest = table.Column<decimal>(type: "numeric", nullable: false),
                    SettledDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    OddMatched = table.Column<decimal>(type: "numeric", nullable: false),
                    PriceSettled = table.Column<decimal>(type: "numeric", nullable: false),
                    Profit = table.Column<decimal>(type: "numeric", nullable: false),
                    MarketDescription = table.Column<string>(type: "text", nullable: true),
                    MarketType = table.Column<int>(type: "integer", nullable: false),
                    PickTeamId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Bets_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teams_Events_PickTeamId",
                        column: x => x.PickTeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bets");

            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
