using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PlanningBet.Users.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9ab4cfc7-8e21-40ab-a258-0d37693aab3a", "718d59ca-5470-4997-9744-86725a52675c", "Admin", "ADMIN" },
                    { "dec9c8e5-f062-4b84-a723-1837b80086fd", "334c1e67-d8de-4166-9e75-728d134d4cb5", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "9ab4cfc7-8e21-40ab-a258-0d37693aab3a");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "dec9c8e5-f062-4b84-a723-1837b80086fd");
        }
    }
}
