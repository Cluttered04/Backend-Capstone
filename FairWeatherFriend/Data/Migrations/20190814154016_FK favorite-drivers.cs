using Microsoft.EntityFrameworkCore.Migrations;

namespace FairWeatherFriend.Data.Migrations
{
    public partial class FKfavoritedrivers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ApplicationUserId",
                table: "AspNetUsers",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_ApplicationUserId",
                table: "AspNetUsers",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_ApplicationUserId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ApplicationUserId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "AspNetUsers");

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
    }
}
