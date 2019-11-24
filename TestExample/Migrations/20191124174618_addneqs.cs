using Microsoft.EntityFrameworkCore.Migrations;

namespace TestExample.Migrations
{
    public partial class addneqs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 174,
                column: "CorrectAnswer",
                value: true);

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 179,
                column: "CorrectAnswer",
                value: true);

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 183,
                column: "CorrectAnswer",
                value: true);

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 185,
                column: "CorrectAnswer",
                value: true);

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 206,
                column: "CorrectAnswer",
                value: true);

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 260,
                column: "CorrectAnswer",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 174,
                column: "CorrectAnswer",
                value: false);

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 179,
                column: "CorrectAnswer",
                value: false);

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 183,
                column: "CorrectAnswer",
                value: false);

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 185,
                column: "CorrectAnswer",
                value: false);

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 206,
                column: "CorrectAnswer",
                value: false);

            migrationBuilder.UpdateData(
                table: "DbAnswer",
                keyColumn: "Id",
                keyValue: 260,
                column: "CorrectAnswer",
                value: false);
        }
    }
}
