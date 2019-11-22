using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestExample.Migrations
{
    public partial class AddingNewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DbAnswer2",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    QuestionVariantContent = table.Column<string>(nullable: true),
                    CorrectAnswer = table.Column<bool>(nullable: false),
                    CheckCorrectAnswer = table.Column<bool>(nullable: false),
                    CheckdAnswer = table.Column<bool>(nullable: false),
                    QuestionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbAnswer2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DbQuestion2",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    QuestionContent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbQuestion2", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "DbAnswer2",
                columns: new[] { "Id", "CheckCorrectAnswer", "CheckdAnswer", "CorrectAnswer", "QuestionId", "QuestionVariantContent" },
                values: new object[,]
                {
                    { 1, false, false, true, 1, "եթե կողմ են քվեարկել քվեարկությանը ներկա հանձնաժողովի անդամների մեկ երրորդը, բացառությամբ օրենքով սահմանցած դեպքերի" },
                    { 12, false, false, false, 5, "5-3" },
                    { 11, false, false, true, 5, "5-2" },
                    { 10, false, false, false, 5, "5-1" },
                    { 8, false, false, true, 4, "4-2" },
                    { 7, false, false, false, 4, "4-1" },
                    { 9, false, false, false, 4, "4-3" },
                    { 5, false, false, false, 2, "քվեարկության օրվանից 2 օր առաջ" },
                    { 4, false, false, true, 2, "քվեարկության օրվանից 1 օր առաջ" },
                    { 3, false, false, false, 1, "եթե կողմ են քվեարկել հանձնաժողովի նախագահն ու քարտուղարը, բացառությամբ օրենքով սահմանցած դեպքերի" },
                    { 2, false, false, false, 1, "եթե կողմ են քվեարկել նիստին ներկա հանձնաժողովի անդամների թվի կեսից ավելին, բացառությամբ օրենքով սահմանցած դեպքերի" },
                    { 6, false, false, false, 2, "քվեարկության օրը" }
                });

            migrationBuilder.InsertData(
                table: "DbQuestion2",
                columns: new[] { "Id", "QuestionContent" },
                values: new object[,]
                {
                    { 21, "Հարց 21. " },
                    { 17, "Հարց 17. " },
                    { 18, "Հարց 18. " },
                    { 19, "Հարց 19. " },
                    { 20, "Հարց 20. " },
                    { 22, "Հարց 22. " },
                    { 28, "Հարց 28. " },
                    { 24, "Հարց 24." },
                    { 25, "Հարց 25. " },
                    { 26, "Հարց 26." },
                    { 27, "Հարց 27. " },
                    { 16, "Հարց 16. " },
                    { 23, "Հարց 23. " },
                    { 15, "Հարց 15. " },
                    { 9, "Հարց 9. " },
                    { 13, "Հարց 13. " },
                    { 12, "Հարց 12. " },
                    { 11, "Հարց 11. " },
                    { 10, "Հարց 10. " },
                    { 29, "Հարց 29. " },
                    { 8, "Հարց 8." },
                    { 7, "Հարց 7." },
                    { 6, "Հարց 6. " },
                    { 5, "Հարց 5. " },
                    { 4, "Հարց 4. " },
                    { 3, "Հարց 3. " },
                    { 2, "Հարց 2.Տեղամասային ընտրական հանձնաժողովի նախագահը ընտրողների ցուցակի օրինակը տեղամասային կենտրոնում՝ բոլորի համար տեսանելի տեղում փակցվում է՝ " },
                    { 1, "Հարց 1. Ընտրական հանձնաժողովի որոշումը ե՞րբ է համարվում ընդունցած՝" },
                    { 14, "Հարց 14. " },
                    { 30, "Հարց 30. " }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DbAnswer2");

            migrationBuilder.DropTable(
                name: "DbQuestion2");
        }
    }
}
