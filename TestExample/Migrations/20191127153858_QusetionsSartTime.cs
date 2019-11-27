using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestExample.Migrations
{
    public partial class QusetionsSartTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "QusetionsSartTime",
                table: "DbTempQuestions",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QusetionsSartTime",
                table: "DbTempQuestions");
        }
    }
}
