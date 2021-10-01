using Microsoft.EntityFrameworkCore.Migrations;

namespace MyProject.Migrations
{
    public partial class ExtendUser_UsersTasksConnect : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "MathTask",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "MathTask",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MathTask_ApplicationUserId",
                table: "MathTask",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_MathTask_AspNetUsers_ApplicationUserId",
                table: "MathTask",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MathTask_AspNetUsers_ApplicationUserId",
                table: "MathTask");

            migrationBuilder.DropIndex(
                name: "IX_MathTask_ApplicationUserId",
                table: "MathTask");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "MathTask");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "MathTask");
        }
    }
}
