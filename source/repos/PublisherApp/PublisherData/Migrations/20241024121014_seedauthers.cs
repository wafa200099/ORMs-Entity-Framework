using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PublisherData.Migrations
{
    public partial class seedauthers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authers",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { 1, "awafa", "mh" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authers",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
