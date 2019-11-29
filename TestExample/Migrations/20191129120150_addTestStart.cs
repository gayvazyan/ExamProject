using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestExample.Migrations
{
    public partial class addTestStart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QusetionsSartTime",
                table: "DbTempQuestions");

            migrationBuilder.AddColumn<bool>(
                name: "TestStart",
                table: "DbTempQuestions",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TestStart",
                table: "DbTempQuestions");

            migrationBuilder.AddColumn<DateTime>(
                name: "QusetionsSartTime",
                table: "DbTempQuestions",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
