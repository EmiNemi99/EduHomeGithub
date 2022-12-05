using Microsoft.EntityFrameworkCore.Migrations;

namespace EduPage.Migrations
{
    public partial class IsDeactiveToNoticeboard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeactive",
                table: "NoticeBoards",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeactive",
                table: "NoticeBoards");
        }
    }
}
