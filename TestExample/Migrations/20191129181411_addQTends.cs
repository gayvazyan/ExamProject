using Microsoft.EntityFrameworkCore.Migrations;

namespace TestExample.Migrations
{
    public partial class addQTends : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "QestEnd",
                table: "DbTempQuestions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TestEnd",
                table: "DbTempQuestions",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QestEnd",
                table: "DbTempQuestions");

            migrationBuilder.DropColumn(
                name: "TestEnd",
                table: "DbTempQuestions");
        }
    }
}
