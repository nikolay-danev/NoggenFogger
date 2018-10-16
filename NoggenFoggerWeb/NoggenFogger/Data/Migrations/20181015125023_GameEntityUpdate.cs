using Microsoft.EntityFrameworkCore.Migrations;

namespace NoggenFogger.Data.Migrations
{
    public partial class GameEntityUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatorId",
                table: "Games",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DownloadLink",
                table: "Games",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Games_CreatorId",
                table: "Games",
                column: "CreatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_AspNetUsers_CreatorId",
                table: "Games",
                column: "CreatorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_AspNetUsers_CreatorId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_CreatorId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "DownloadLink",
                table: "Games");
        }
    }
}
