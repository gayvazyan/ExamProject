using Microsoft.EntityFrameworkCore.Migrations;

namespace TestExample.Migrations
{
    public partial class AddindNotification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notification",
                table: "DbCitizenReport",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notification",
                table: "DbCitizenReport");
        }
    }
}
