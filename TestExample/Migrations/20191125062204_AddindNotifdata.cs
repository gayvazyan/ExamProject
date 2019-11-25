using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestExample.Migrations
{
    public partial class AddindNotifdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "NotificationData",
                table: "DbCitizenReport",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 6,
                column: "CorrectAnswer",
                value: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NotificationData",
                table: "DbCitizenReport");

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 6,
                column: "CorrectAnswer",
                value: true);
        }
    }
}
