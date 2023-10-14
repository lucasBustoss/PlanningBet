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
                name: "bets",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    event_id = table.Column<Guid>(type: "uuid", nullable: false),
                    event_code = table.Column<string>(type: "text", nullable: true),
                    market_id = table.Column<string>(type: "text", nullable: true),
                    selection_id = table.Column<int>(type: "integer", nullable: false),
                    bet_id = table.Column<string>(type: "text", nullable: true),
                    placed_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    side = table.Column<string>(type: "text", nullable: true),
                    odd_request = table.Column<decimal>(type: "numeric", nullable: false),
                    settled_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    odd_matched = table.Column<decimal>(type: "numeric", nullable: false),
                    price_settled = table.Column<decimal>(type: "numeric", nullable: false),
                    profit = table.Column<decimal>(type: "numeric", nullable: false),
                    market_description = table.Column<string>(type: "text", nullable: true),
                    market_type = table.Column<int>(type: "integer", nullable: false),
                    pick_team_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("p_k_bets", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "events",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    event_code = table.Column<string>(type: "text", nullable: true),
                    home_team_id = table.Column<Guid>(type: "uuid", nullable: false),
                    away_team_id = table.Column<Guid>(type: "uuid", nullable: false),
                    date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    bet_count = table.Column<int>(type: "integer", nullable: false),
                    commission = table.Column<decimal>(type: "numeric", nullable: false),
                    profit = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("p_k_events", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bets");

            migrationBuilder.DropTable(
                name: "events");
        }
    }
}
