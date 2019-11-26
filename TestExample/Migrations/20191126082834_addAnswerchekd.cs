using Microsoft.EntityFrameworkCore.Migrations;

namespace TestExample.Migrations
{
    public partial class addAnswerchekd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Answer1",
                table: "DbTempQuestions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Answer2",
                table: "DbTempQuestions",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Cheked1",
                table: "DbTempQuestions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Cheked2",
                table: "DbTempQuestions",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Answer1",
                table: "DbTempQuestions");

            migrationBuilder.DropColumn(
                name: "Answer2",
                table: "DbTempQuestions");

            migrationBuilder.DropColumn(
                name: "Cheked1",
                table: "DbTempQuestions");

            migrationBuilder.DropColumn(
                name: "Cheked2",
                table: "DbTempQuestions");
        }
    }
}
