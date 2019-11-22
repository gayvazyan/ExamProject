using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestExample.Migrations
{
    public partial class AddNewQa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DbAnswer3",
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
                    table.PrimaryKey("PK_DbAnswer3", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DbAnswer4",
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
                    table.PrimaryKey("PK_DbAnswer4", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DbAnswer5",
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
                    table.PrimaryKey("PK_DbAnswer5", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DbAnswer6",
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
                    table.PrimaryKey("PK_DbAnswer6", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DbAnswer7",
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
                    table.PrimaryKey("PK_DbAnswer7", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DbQuestion3",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    QuestionContent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbQuestion3", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DbQuestion4",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    QuestionContent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbQuestion4", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DbQuestion5",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    QuestionContent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbQuestion5", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DbQuestion6",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    QuestionContent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbQuestion6", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DbQuestion7",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    QuestionContent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbQuestion7", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "DbAnswer3",
                columns: new[] { "Id", "CheckCorrectAnswer", "CheckdAnswer", "CorrectAnswer", "QuestionId", "QuestionVariantContent" },
                values: new object[,]
                {
                    { 1, false, false, false, 1, "եթե կողմ են քվեարկել քվեարկությանը ներկա հանձնաժողովի անդամների մեկ երրորդը, բացառությամբ օրենքով սահմանցած դեպքերի" },
                    { 2, false, false, true, 1, "եթե կողմ են քվեարկել նիստին ներկա հանձնաժողովի անդամների թվի կեսից ավելին, բացառությամբ օրենքով սահմանցած դեպքերի" },
                    { 3, false, false, false, 1, "եթե կողմ են քվեարկել քվեարկությանը ներկա հանձնաժողովի անդամների մեկ երրորդը, բացառությամբ օրենքով սահմանցած դեպքերի" },
                    { 4, false, false, true, 1, "եթե կողմ են քվեարկել նիստին ներկա հանձնաժողովի անդամների թվի կեսից ավելին, բացառությամբ օրենքով սահմանցած դեպքերի" },
                    { 5, false, false, false, 1, "եթե կողմ են քվեարկել քվեարկությանը ներկա հանձնաժողովի անդամների մեկ երրորդը, բացառությամբ օրենքով սահմանցած դեպքերի" },
                    { 6, false, false, true, 1, "եթե կողմ են քվեարկել նիստին ներկա հանձնաժողովի անդամների թվի կեսից ավելին, բացառությամբ օրենքով սահմանցած դեպքերի" }
                });

            migrationBuilder.InsertData(
                table: "DbAnswer4",
                columns: new[] { "Id", "CheckCorrectAnswer", "CheckdAnswer", "CorrectAnswer", "QuestionId", "QuestionVariantContent" },
                values: new object[,]
                {
                    { 6, false, false, true, 1, "եթե կողմ են քվեարկել նիստին ներկա հանձնաժողովի անդամների թվի կեսից ավելին, բացառությամբ օրենքով սահմանցած դեպքերի" },
                    { 4, false, false, true, 1, "եթե կողմ են քվեարկել նիստին ներկա հանձնաժողովի անդամների թվի կեսից ավելին, բացառությամբ օրենքով սահմանցած դեպքերի" },
                    { 5, false, false, false, 1, "եթե կողմ են քվեարկել քվեարկությանը ներկա հանձնաժողովի անդամների մեկ երրորդը, բացառությամբ օրենքով սահմանցած դեպքերի" },
                    { 2, false, false, true, 1, "եթե կողմ են քվեարկել նիստին ներկա հանձնաժողովի անդամների թվի կեսից ավելին, բացառությամբ օրենքով սահմանցած դեպքերի" },
                    { 1, false, false, false, 1, "եթե կողմ են քվեարկել քվեարկությանը ներկա հանձնաժողովի անդամների մեկ երրորդը, բացառությամբ օրենքով սահմանցած դեպքերի" },
                    { 3, false, false, false, 1, "եթե կողմ են քվեարկել քվեարկությանը ներկա հանձնաժողովի անդամների մեկ երրորդը, բացառությամբ օրենքով սահմանցած դեպքերի" }
                });

            migrationBuilder.InsertData(
                table: "DbAnswer5",
                columns: new[] { "Id", "CheckCorrectAnswer", "CheckdAnswer", "CorrectAnswer", "QuestionId", "QuestionVariantContent" },
                values: new object[,]
                {
                    { 1, false, false, false, 1, "եթե կողմ են քվեարկել քվեարկությանը ներկա հանձնաժողովի անդամների մեկ երրորդը, բացառությամբ օրենքով սահմանցած դեպքերի" },
                    { 2, false, false, true, 1, "եթե կողմ են քվեարկել նիստին ներկա հանձնաժողովի անդամների թվի կեսից ավելին, բացառությամբ օրենքով սահմանցած դեպքերի" },
                    { 3, false, false, false, 1, "եթե կողմ են քվեարկել քվեարկությանը ներկա հանձնաժողովի անդամների մեկ երրորդը, բացառությամբ օրենքով սահմանցած դեպքերի" },
                    { 4, false, false, true, 1, "եթե կողմ են քվեարկել նիստին ներկա հանձնաժողովի անդամների թվի կեսից ավելին, բացառությամբ օրենքով սահմանցած դեպքերի" },
                    { 5, false, false, false, 1, "եթե կողմ են քվեարկել քվեարկությանը ներկա հանձնաժողովի անդամների մեկ երրորդը, բացառությամբ օրենքով սահմանցած դեպքերի" },
                    { 6, false, false, true, 1, "եթե կողմ են քվեարկել նիստին ներկա հանձնաժողովի անդամների թվի կեսից ավելին, բացառությամբ օրենքով սահմանցած դեպքերի" }
                });

            migrationBuilder.InsertData(
                table: "DbAnswer6",
                columns: new[] { "Id", "CheckCorrectAnswer", "CheckdAnswer", "CorrectAnswer", "QuestionId", "QuestionVariantContent" },
                values: new object[,]
                {
                    { 5, false, false, false, 1, "եթե կողմ են քվեարկել քվեարկությանը ներկա հանձնաժողովի անդամների մեկ երրորդը, բացառությամբ օրենքով սահմանցած դեպքերի" },
                    { 6, false, false, true, 1, "եթե կողմ են քվեարկել նիստին ներկա հանձնաժողովի անդամների թվի կեսից ավելին, բացառությամբ օրենքով սահմանցած դեպքերի" },
                    { 4, false, false, true, 1, "եթե կողմ են քվեարկել նիստին ներկա հանձնաժողովի անդամների թվի կեսից ավելին, բացառությամբ օրենքով սահմանցած դեպքերի" },
                    { 2, false, false, true, 1, "եթե կողմ են քվեարկել նիստին ներկա հանձնաժողովի անդամների թվի կեսից ավելին, բացառությամբ օրենքով սահմանցած դեպքերի" },
                    { 1, false, false, false, 1, "եթե կողմ են քվեարկել քվեարկությանը ներկա հանձնաժողովի անդամների մեկ երրորդը, բացառությամբ օրենքով սահմանցած դեպքերի" },
                    { 3, false, false, false, 1, "եթե կողմ են քվեարկել քվեարկությանը ներկա հանձնաժողովի անդամների մեկ երրորդը, բացառությամբ օրենքով սահմանցած դեպքերի" }
                });

            migrationBuilder.InsertData(
                table: "DbAnswer7",
                columns: new[] { "Id", "CheckCorrectAnswer", "CheckdAnswer", "CorrectAnswer", "QuestionId", "QuestionVariantContent" },
                values: new object[,]
                {
                    { 1, false, false, false, 1, "եթե կողմ են քվեարկել քվեարկությանը ներկա հանձնաժողովի անդամների մեկ երրորդը, բացառությամբ օրենքով սահմանցած դեպքերի" },
                    { 2, false, false, true, 1, "եթե կողմ են քվեարկել նիստին ներկա հանձնաժողովի անդամների թվի կեսից ավելին, բացառությամբ օրենքով սահմանցած դեպքերի" },
                    { 3, false, false, false, 1, "եթե կողմ են քվեարկել քվեարկությանը ներկա հանձնաժողովի անդամների մեկ երրորդը, բացառությամբ օրենքով սահմանցած դեպքերի" },
                    { 4, false, false, true, 1, "եթե կողմ են քվեարկել նիստին ներկա հանձնաժողովի անդամների թվի կեսից ավելին, բացառությամբ օրենքով սահմանցած դեպքերի" },
                    { 5, false, false, false, 1, "եթե կողմ են քվեարկել քվեարկությանը ներկա հանձնաժողովի անդամների մեկ երրորդը, բացառությամբ օրենքով սահմանցած դեպքերի" },
                    { 6, false, false, true, 1, "եթե կողմ են քվեարկել նիստին ներկա հանձնաժողովի անդամների թվի կեսից ավելին, բացառությամբ օրենքով սահմանցած դեպքերի" }
                });

            migrationBuilder.InsertData(
                table: "DbQuestion3",
                columns: new[] { "Id", "QuestionContent" },
                values: new object[,]
                {
                    { 1, "Հարց 1. Ընտրական հանձնաժողովի որոշումը ե՞րբ է համարվում ընդունցած՝" },
                    { 2, "Հարց 2.Տեղամասային ընտրական հանձնաժողովի նախագահը ընտրողների ցուցակի օրինակը տեղամասային կենտրոնում՝ բոլորի համար տեսանելի տեղում փակցվում է՝ " }
                });

            migrationBuilder.InsertData(
                table: "DbQuestion4",
                columns: new[] { "Id", "QuestionContent" },
                values: new object[,]
                {
                    { 1, "Հարց 1. Ընտրական հանձնաժողովի որոշումը ե՞րբ է համարվում ընդունցած՝" },
                    { 2, "Հարց 2.Տեղամասային ընտրական հանձնաժողովի նախագահը ընտրողների ցուցակի օրինակը տեղամասային կենտրոնում՝ բոլորի համար տեսանելի տեղում փակցվում է՝ " }
                });

            migrationBuilder.InsertData(
                table: "DbQuestion5",
                columns: new[] { "Id", "QuestionContent" },
                values: new object[,]
                {
                    { 1, "Հարց 1. Ընտրական հանձնաժողովի որոշումը ե՞րբ է համարվում ընդունցած՝" },
                    { 2, "Հարց 2.Տեղամասային ընտրական հանձնաժողովի նախագահը ընտրողների ցուցակի օրինակը տեղամասային կենտրոնում՝ բոլորի համար տեսանելի տեղում փակցվում է՝ " }
                });

            migrationBuilder.InsertData(
                table: "DbQuestion6",
                columns: new[] { "Id", "QuestionContent" },
                values: new object[,]
                {
                    { 1, "Հարց 1. Ընտրական հանձնաժողովի որոշումը ե՞րբ է համարվում ընդունցած՝" },
                    { 2, "Հարց 2.Տեղամասային ընտրական հանձնաժողովի նախագահը ընտրողների ցուցակի օրինակը տեղամասային կենտրոնում՝ բոլորի համար տեսանելի տեղում փակցվում է՝ " }
                });

            migrationBuilder.InsertData(
                table: "DbQuestion7",
                columns: new[] { "Id", "QuestionContent" },
                values: new object[,]
                {
                    { 1, "Հարց 1. Ընտրական հանձնաժողովի որոշումը ե՞րբ է համարվում ընդունցած՝" },
                    { 2, "Հարց 2.Տեղամասային ընտրական հանձնաժողովի նախագահը ընտրողների ցուցակի օրինակը տեղամասային կենտրոնում՝ բոլորի համար տեսանելի տեղում փակցվում է՝ " }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DbAnswer3");

            migrationBuilder.DropTable(
                name: "DbAnswer4");

            migrationBuilder.DropTable(
                name: "DbAnswer5");

            migrationBuilder.DropTable(
                name: "DbAnswer6");

            migrationBuilder.DropTable(
                name: "DbAnswer7");

            migrationBuilder.DropTable(
                name: "DbQuestion3");

            migrationBuilder.DropTable(
                name: "DbQuestion4");

            migrationBuilder.DropTable(
                name: "DbQuestion5");

            migrationBuilder.DropTable(
                name: "DbQuestion6");

            migrationBuilder.DropTable(
                name: "DbQuestion7");
        }
    }
}
