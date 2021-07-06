using Microsoft.EntityFrameworkCore.Migrations;

namespace Educavo.Migrations
{
    public partial class blogkhbsd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_PanelUsers_PanelUserId",
                table: "Blogs");

            migrationBuilder.AlterColumn<int>(
                name: "PanelUserId",
                table: "Blogs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "CustomUserId",
                table: "Blogs",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CustomUserId",
                table: "Blogs",
                column: "CustomUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_AspNetUsers_CustomUserId",
                table: "Blogs",
                column: "CustomUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_PanelUsers_PanelUserId",
                table: "Blogs",
                column: "PanelUserId",
                principalTable: "PanelUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_AspNetUsers_CustomUserId",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_PanelUsers_PanelUserId",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_CustomUserId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "CustomUserId",
                table: "Blogs");

            migrationBuilder.AlterColumn<int>(
                name: "PanelUserId",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_PanelUsers_PanelUserId",
                table: "Blogs",
                column: "PanelUserId",
                principalTable: "PanelUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
