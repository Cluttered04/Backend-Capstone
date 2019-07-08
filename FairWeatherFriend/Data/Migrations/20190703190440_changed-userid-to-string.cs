using Microsoft.EntityFrameworkCore.Migrations;

namespace FairWeatherFriend.Data.Migrations
{
    public partial class changeduseridtostring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteRaces_AspNetUsers_UserId1",
                table: "FavoriteRaces");

            migrationBuilder.DropIndex(
                name: "IX_FavoriteRaces_UserId1",
                table: "FavoriteRaces");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "FavoriteRaces");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "FavoriteRaces",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteRaces_UserId",
                table: "FavoriteRaces",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteRaces_AspNetUsers_UserId",
                table: "FavoriteRaces",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteRaces_AspNetUsers_UserId",
                table: "FavoriteRaces");

            migrationBuilder.DropIndex(
                name: "IX_FavoriteRaces_UserId",
                table: "FavoriteRaces");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "FavoriteRaces",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "FavoriteRaces",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteRaces_UserId1",
                table: "FavoriteRaces",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteRaces_AspNetUsers_UserId1",
                table: "FavoriteRaces",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
