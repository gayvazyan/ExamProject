using Microsoft.EntityFrameworkCore.Migrations;

namespace TestExample.Migrations
{
    public partial class addnewID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DbAnswer3",
                keyColumn: "Id",
                keyValue: 4,
                column: "QuestionId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "DbAnswer3",
                keyColumn: "Id",
                keyValue: 5,
                column: "QuestionId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "DbAnswer3",
                keyColumn: "Id",
                keyValue: 6,
                column: "QuestionId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "DbAnswer4",
                keyColumn: "Id",
                keyValue: 4,
                column: "QuestionId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "DbAnswer4",
                keyColumn: "Id",
                keyValue: 5,
                column: "QuestionId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "DbAnswer4",
                keyColumn: "Id",
                keyValue: 6,
                column: "QuestionId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "DbAnswer5",
                keyColumn: "Id",
                keyValue: 4,
                column: "QuestionId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "DbAnswer5",
                keyColumn: "Id",
                keyValue: 5,
                column: "QuestionId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "DbAnswer5",
                keyColumn: "Id",
                keyValue: 6,
                column: "QuestionId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "DbAnswer6",
                keyColumn: "Id",
                keyValue: 4,
                column: "QuestionId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "DbAnswer6",
                keyColumn: "Id",
                keyValue: 5,
                column: "QuestionId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "DbAnswer6",
                keyColumn: "Id",
                keyValue: 6,
                column: "QuestionId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "DbAnswer7",
                keyColumn: "Id",
                keyValue: 4,
                column: "QuestionId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "DbAnswer7",
                keyColumn: "Id",
                keyValue: 5,
                column: "QuestionId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "DbAnswer7",
                keyColumn: "Id",
                keyValue: 6,
                column: "QuestionId",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DbAnswer3",
                keyColumn: "Id",
                keyValue: 4,
                column: "QuestionId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DbAnswer3",
                keyColumn: "Id",
                keyValue: 5,
                column: "QuestionId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DbAnswer3",
                keyColumn: "Id",
                keyValue: 6,
                column: "QuestionId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DbAnswer4",
                keyColumn: "Id",
                keyValue: 4,
                column: "QuestionId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DbAnswer4",
                keyColumn: "Id",
                keyValue: 5,
                column: "QuestionId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DbAnswer4",
                keyColumn: "Id",
                keyValue: 6,
                column: "QuestionId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DbAnswer5",
                keyColumn: "Id",
                keyValue: 4,
                column: "QuestionId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DbAnswer5",
                keyColumn: "Id",
                keyValue: 5,
                column: "QuestionId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DbAnswer5",
                keyColumn: "Id",
                keyValue: 6,
                column: "QuestionId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DbAnswer6",
                keyColumn: "Id",
                keyValue: 4,
                column: "QuestionId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DbAnswer6",
                keyColumn: "Id",
                keyValue: 5,
                column: "QuestionId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DbAnswer6",
                keyColumn: "Id",
                keyValue: 6,
                column: "QuestionId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DbAnswer7",
                keyColumn: "Id",
                keyValue: 4,
                column: "QuestionId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DbAnswer7",
                keyColumn: "Id",
                keyValue: 5,
                column: "QuestionId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DbAnswer7",
                keyColumn: "Id",
                keyValue: 6,
                column: "QuestionId",
                value: 1);
        }
    }
}
