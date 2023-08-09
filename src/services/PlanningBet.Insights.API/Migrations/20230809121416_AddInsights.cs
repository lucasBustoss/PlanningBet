using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PlanningBet.Insights.API.Migrations
{
    /// <inheritdoc />
    public partial class AddInsights : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Insights",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Value = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true),
                    Active = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insights", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Insights",
                columns: new[] { "Id", "Active", "Name", "Type", "Value" },
                values: new object[,]
                {
                    { new Guid("09deedad-cd4e-4f27-89f6-9adcdbe48871"), false, "Ambas marcam Não", "sequency", "bttsNo" },
                    { new Guid("0df6f7b2-2f2b-46f6-92f4-db7567116413"), true, "Gols sofridos no primeiro tempo", "comparativeGoals", "goalsConcededFirstHalf" },
                    { new Guid("16f808ae-0fdb-4fbe-81d8-068a2bbd08df"), false, "xG contra", "comparativeHomeAway", "concededXG" },
                    { new Guid("18984508-7725-4433-a14c-95188032db48"), true, "Finalizações", "comparativeHomeAway", "shots" },
                    { new Guid("218a5026-efda-4700-9d31-3e538f8cb736"), true, "Vitórias", "sequency", "wins" },
                    { new Guid("2e29ffc5-ae13-40d8-83b1-f5688396659e"), true, "% de vitórias", "comparativeHomeAway", "winsPercentage" },
                    { new Guid("39c089dd-607e-4e32-bedc-f32aab68d39a"), true, "Cantos", "sequency", "corner" },
                    { new Guid("4629a74b-3133-44a6-9267-3d9e77ae7f7e"), true, "Invencibilidade", "sequency", "invincibility" },
                    { new Guid("4e589feb-f99b-4c7e-82f9-2300cd31ef41"), true, "Cartões", "sequency", "cards" },
                    { new Guid("55db23d6-4933-4ca3-b438-50f3a7659696"), false, "Under 2.5", "sequency", "under25" },
                    { new Guid("576517e3-bbf6-4a72-a992-5317c5f7cc00"), true, "xG a favor", "comparativeHomeAway", "favorXG" },
                    { new Guid("6e9bf393-3ed2-46f5-8a64-70c54d22012b"), true, "Gols sofridos", "comparativeHomeAway", "concededHomeAway" },
                    { new Guid("7e9f65bc-ccae-4251-ad11-ae5222b31992"), true, "Pontos por jogo", "comparativeHomeAway", "ppg" },
                    { new Guid("8423bdeb-e862-4e7b-9805-34dcd005b4d3"), true, "Ambas marcam", "sequency", "bttsYes" },
                    { new Guid("87cf2cb9-6d33-4508-8d28-fa8ef6db5ea5"), true, "Primeiro a marcar", "comparativeHomeAway", "firstToScore" },
                    { new Guid("8b36e232-2cb4-40df-bcff-5af4706e5b11"), true, "Derrotas", "sequency", "loses" },
                    { new Guid("aa4cc52e-c2a6-4c97-992c-14bf9a63beef"), true, "Gols marcados", "comparativeHomeAway", "scoredHomeAway" },
                    { new Guid("b359a0df-a478-4fe6-8fa9-4afe28e398e5"), true, "Sofreu gols", "sequency", "conceded" },
                    { new Guid("d4d9e01f-506a-4b96-ae81-43f32188fc0a"), true, "Marcou gols", "sequency", "scored" },
                    { new Guid("d9e1039f-5a5f-409b-aea1-76ea368df5f5"), true, "Over 2.5", "sequency", "over25" },
                    { new Guid("e9327cef-4be9-4030-aef9-1a162d34d435"), true, "Gols marcados no primeiro tempo", "comparativeGoals", "goalsScoredFirstHalf" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Insights");
        }
    }
}
