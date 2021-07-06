using Microsoft.EntityFrameworkCore.Migrations;

namespace Educavo.Migrations
{
    public partial class blogkhbsdiusrbv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_PanelUsers_PanelUserId",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_PanelUserId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "PanelUserId",
                table: "Blogs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PanelUserId",
                table: "Blogs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_PanelUserId",
                table: "Blogs",
                column: "PanelUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_PanelUsers_PanelUserId",
                table: "Blogs",
                column: "PanelUserId",
                principalTable: "PanelUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
