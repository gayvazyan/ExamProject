using Microsoft.EntityFrameworkCore.Migrations;

namespace TestExample.Migrations
{
    public partial class AddindNotifdatabool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Notification",
                table: "DbCitizenReport",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Notification",
                table: "DbCitizenReport",
                nullable: true,
                oldClrType: typeof(bool));
        }
    }
}
