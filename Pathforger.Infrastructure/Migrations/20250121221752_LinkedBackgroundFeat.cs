using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pathforger.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class LinkedBackgroundFeat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BackgroundFeats_Backgrounds_BackgroundEntityId",
                table: "BackgroundFeats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BackgroundFeats",
                table: "BackgroundFeats");

            migrationBuilder.DropIndex(
                name: "IX_BackgroundFeats_BackgroundEntityId",
                table: "BackgroundFeats");

            migrationBuilder.DropColumn(
                name: "BackgroundEntityId",
                table: "BackgroundFeats");

            migrationBuilder.AddColumn<string>(
                name: "BackgroundId",
                table: "BackgroundFeats",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BackgroundFeats",
                table: "BackgroundFeats",
                columns: new[] { "BackgroundId", "Key" });

            migrationBuilder.AddForeignKey(
                name: "FK_BackgroundFeats_Backgrounds_BackgroundId",
                table: "BackgroundFeats",
                column: "BackgroundId",
                principalTable: "Backgrounds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BackgroundFeats_Backgrounds_BackgroundId",
                table: "BackgroundFeats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BackgroundFeats",
                table: "BackgroundFeats");

            migrationBuilder.DropColumn(
                name: "BackgroundId",
                table: "BackgroundFeats");

            migrationBuilder.AddColumn<string>(
                name: "BackgroundEntityId",
                table: "BackgroundFeats",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BackgroundFeats",
                table: "BackgroundFeats",
                column: "Key");

            migrationBuilder.CreateIndex(
                name: "IX_BackgroundFeats_BackgroundEntityId",
                table: "BackgroundFeats",
                column: "BackgroundEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_BackgroundFeats_Backgrounds_BackgroundEntityId",
                table: "BackgroundFeats",
                column: "BackgroundEntityId",
                principalTable: "Backgrounds",
                principalColumn: "Id");
        }
    }
}
