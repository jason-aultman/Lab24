using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab24.Migrations
{
    public partial class seedMovieRepair : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genre", "Runtime", "Title" },
                values: new object[] { 1, "Action", null, "Something" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
