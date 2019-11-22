using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestExample.Migrations
{
    public partial class addnchecking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TestDataTime",
                table: "DbCitizenReport",
                newName: "Test2DataTime");

            migrationBuilder.AddColumn<bool>(
                name: "Test1Check",
                table: "DbCitizenReport",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Test1DataTime",
                table: "DbCitizenReport",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Test2Check",
                table: "DbCitizenReport",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Test1Check",
                table: "DbCitizenReport");

            migrationBuilder.DropColumn(
                name: "Test1DataTime",
                table: "DbCitizenReport");

            migrationBuilder.DropColumn(
                name: "Test2Check",
                table: "DbCitizenReport");

            migrationBuilder.RenameColumn(
                name: "Test2DataTime",
                table: "DbCitizenReport",
                newName: "TestDataTime");
        }
    }
}
