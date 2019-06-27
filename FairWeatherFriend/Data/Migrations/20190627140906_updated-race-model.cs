using Microsoft.EntityFrameworkCore.Migrations;

namespace FairWeatherFriend.Data.Migrations
{
    public partial class updatedracemodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Race",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Race");
        }
    }
}
