using Microsoft.EntityFrameworkCore.Migrations;

namespace FairWeatherFriend.Data.Migrations
{
    public partial class addedracestouser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Race",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Race_ApplicationUserId",
                table: "Race",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Race_AspNetUsers_ApplicationUserId",
                table: "Race",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Race_AspNetUsers_ApplicationUserId",
                table: "Race");

            migrationBuilder.DropIndex(
                name: "IX_Race_ApplicationUserId",
                table: "Race");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Race");
        }
    }
}
