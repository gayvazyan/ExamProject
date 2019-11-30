using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestExample.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    SecondName = table.Column<string>(nullable: true),
                    Passport = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DbAnswer",
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
                    table.PrimaryKey("PK_DbAnswer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DbCitizenReport",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    SecondName = table.Column<string>(nullable: true),
                    Passport = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Result_Test1 = table.Column<double>(nullable: false),
                    Test1Check = table.Column<bool>(nullable: false),
                    Result_Test2 = table.Column<double>(nullable: false),
                    Test2Check = table.Column<bool>(nullable: false),
                    NumberTicket = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Test1DataTime = table.Column<DateTime>(nullable: false),
                    Test2DataTime = table.Column<DateTime>(nullable: false),
                    Notification = table.Column<bool>(nullable: false),
                    NotificationData = table.Column<DateTime>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbCitizenReport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DbCitizenTestResults",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NumberTicket = table.Column<int>(nullable: false),
                    Region = table.Column<string>(nullable: true),
                    Community = table.Column<string>(nullable: true),
                    CEC = table.Column<int>(nullable: true),
                    TEC = table.Column<string>(nullable: true),
                    Participants = table.Column<int>(nullable: true),
                    AllAdditionallyDuringElDay = table.Column<int>(nullable: true),
                    PartAdditionallyDuringElDay = table.Column<int>(nullable: true),
                    AllMobileVoters = table.Column<int>(nullable: true),
                    PartMobileVoters = table.Column<int>(nullable: true),
                    AllSum = table.Column<int>(nullable: true),
                    PartSum = table.Column<int>(nullable: true),
                    VadTickets = table.Column<int>(nullable: true),
                    NumerableTickets = table.Column<int>(nullable: true),
                    AllTickets = table.Column<int>(nullable: true),
                    UnusedNumerableTickets = table.Column<int>(nullable: true),
                    UnusedGlueTickets = table.Column<int>(nullable: true),
                    InvalidTickets = table.Column<int>(nullable: true),
                    ForA = table.Column<int>(nullable: true),
                    ForB = table.Column<int>(nullable: true),
                    ForC = table.Column<int>(nullable: true),
                    ForAx = table.Column<int>(nullable: true),
                    ForAy = table.Column<int>(nullable: true),
                    ForBm = table.Column<int>(nullable: true),
                    ForBn = table.Column<int>(nullable: true),
                    ForCk = table.Column<int>(nullable: true),
                    ForCl = table.Column<int>(nullable: true),
                    Result = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbCitizenTestResults", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DbEmptyTextViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Region = table.Column<string>(nullable: true),
                    Community = table.Column<string>(nullable: true),
                    CEC = table.Column<int>(nullable: false),
                    TEC = table.Column<string>(nullable: true),
                    Participants = table.Column<int>(nullable: false),
                    AllAdditionallyDuringElDay = table.Column<int>(nullable: false),
                    AllMobileVoters = table.Column<int>(nullable: false),
                    PartMobileVoters = table.Column<int>(nullable: false),
                    VadTickets = table.Column<int>(nullable: false),
                    NumerableTickets = table.Column<int>(nullable: false),
                    UnusedNumerableTickets = table.Column<int>(nullable: false),
                    UnusedGlueTickets = table.Column<int>(nullable: false),
                    InvalidTickets = table.Column<int>(nullable: false),
                    ForA = table.Column<int>(nullable: false),
                    ForB = table.Column<int>(nullable: false),
                    ForC = table.Column<int>(nullable: false),
                    ForAx = table.Column<int>(nullable: false),
                    ForAy = table.Column<int>(nullable: false),
                    ForBm = table.Column<int>(nullable: false),
                    ForBn = table.Column<int>(nullable: false),
                    ForCk = table.Column<int>(nullable: false),
                    ForCl = table.Column<int>(nullable: false),
                    ListAll = table.Column<int>(nullable: false),
                    TecGlueTickets = table.Column<int>(nullable: false),
                    TecNumerableTickets = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbEmptyTextViewModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DbQuestion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    QId = table.Column<int>(nullable: false),
                    QuestionContent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbQuestion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DbTempQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Passport = table.Column<string>(nullable: true),
                    Id1 = table.Column<int>(nullable: false),
                    Q1 = table.Column<string>(nullable: true),
                    Cheked1 = table.Column<bool>(nullable: false),
                    Answer1 = table.Column<string>(nullable: true),
                    Score1 = table.Column<int>(nullable: false),
                    Id2 = table.Column<int>(nullable: false),
                    Q2 = table.Column<string>(nullable: true),
                    Cheked2 = table.Column<bool>(nullable: false),
                    Answer2 = table.Column<string>(nullable: true),
                    Score2 = table.Column<int>(nullable: false),
                    Id3 = table.Column<int>(nullable: false),
                    Q3 = table.Column<string>(nullable: true),
                    Cheked3 = table.Column<bool>(nullable: false),
                    Answer3 = table.Column<string>(nullable: true),
                    Score3 = table.Column<int>(nullable: false),
                    Id4 = table.Column<int>(nullable: false),
                    Q4 = table.Column<string>(nullable: true),
                    Cheked4 = table.Column<bool>(nullable: false),
                    Answer4 = table.Column<string>(nullable: true),
                    Score4 = table.Column<int>(nullable: false),
                    Id5 = table.Column<int>(nullable: false),
                    Q5 = table.Column<string>(nullable: true),
                    Cheked5 = table.Column<bool>(nullable: false),
                    Answer5 = table.Column<string>(nullable: true),
                    Score5 = table.Column<int>(nullable: false),
                    Id6 = table.Column<int>(nullable: false),
                    Q6 = table.Column<string>(nullable: true),
                    Cheked6 = table.Column<bool>(nullable: false),
                    Answer6 = table.Column<string>(nullable: true),
                    Score6 = table.Column<int>(nullable: false),
                    Id7 = table.Column<int>(nullable: false),
                    Q7 = table.Column<string>(nullable: true),
                    Cheked7 = table.Column<bool>(nullable: false),
                    Answer7 = table.Column<string>(nullable: true),
                    Score7 = table.Column<int>(nullable: false),
                    Id8 = table.Column<int>(nullable: false),
                    Q8 = table.Column<string>(nullable: true),
                    Cheked8 = table.Column<bool>(nullable: false),
                    Answer8 = table.Column<string>(nullable: true),
                    Score8 = table.Column<int>(nullable: false),
                    Id9 = table.Column<int>(nullable: false),
                    Q9 = table.Column<string>(nullable: true),
                    Cheked9 = table.Column<bool>(nullable: false),
                    Answer9 = table.Column<string>(nullable: true),
                    Score9 = table.Column<int>(nullable: false),
                    Id10 = table.Column<int>(nullable: false),
                    Q10 = table.Column<string>(nullable: true),
                    Cheked10 = table.Column<bool>(nullable: false),
                    Answer10 = table.Column<string>(nullable: true),
                    Score10 = table.Column<int>(nullable: false),
                    Id11 = table.Column<int>(nullable: false),
                    Q11 = table.Column<string>(nullable: true),
                    Cheked11 = table.Column<bool>(nullable: false),
                    Answer11 = table.Column<string>(nullable: true),
                    Score11 = table.Column<int>(nullable: false),
                    Id12 = table.Column<int>(nullable: false),
                    Q12 = table.Column<string>(nullable: true),
                    Cheked12 = table.Column<bool>(nullable: false),
                    Answer12 = table.Column<string>(nullable: true),
                    Score12 = table.Column<int>(nullable: false),
                    Id13 = table.Column<int>(nullable: false),
                    Q13 = table.Column<string>(nullable: true),
                    Cheked13 = table.Column<bool>(nullable: false),
                    Answer13 = table.Column<string>(nullable: true),
                    Score13 = table.Column<int>(nullable: false),
                    Id14 = table.Column<int>(nullable: false),
                    Q14 = table.Column<string>(nullable: true),
                    Cheked14 = table.Column<bool>(nullable: false),
                    Answer14 = table.Column<string>(nullable: true),
                    Score14 = table.Column<int>(nullable: false),
                    Id15 = table.Column<int>(nullable: false),
                    Q15 = table.Column<string>(nullable: true),
                    Cheked15 = table.Column<bool>(nullable: false),
                    Answer15 = table.Column<string>(nullable: true),
                    Score15 = table.Column<int>(nullable: false),
                    Id16 = table.Column<int>(nullable: false),
                    Q16 = table.Column<string>(nullable: true),
                    Cheked16 = table.Column<bool>(nullable: false),
                    Answer16 = table.Column<string>(nullable: true),
                    Score16 = table.Column<int>(nullable: false),
                    Id17 = table.Column<int>(nullable: false),
                    Q17 = table.Column<string>(nullable: true),
                    Cheked17 = table.Column<bool>(nullable: false),
                    Answer17 = table.Column<string>(nullable: true),
                    Score17 = table.Column<int>(nullable: false),
                    Id18 = table.Column<int>(nullable: false),
                    Q18 = table.Column<string>(nullable: true),
                    Cheked18 = table.Column<bool>(nullable: false),
                    Answer18 = table.Column<string>(nullable: true),
                    Score18 = table.Column<int>(nullable: false),
                    Id19 = table.Column<int>(nullable: false),
                    Q19 = table.Column<string>(nullable: true),
                    Cheked19 = table.Column<bool>(nullable: false),
                    Answer19 = table.Column<string>(nullable: true),
                    Score19 = table.Column<int>(nullable: false),
                    Id20 = table.Column<int>(nullable: false),
                    Q20 = table.Column<string>(nullable: true),
                    Cheked20 = table.Column<bool>(nullable: false),
                    Answer20 = table.Column<string>(nullable: true),
                    Score20 = table.Column<int>(nullable: false),
                    Id21 = table.Column<int>(nullable: false),
                    Q21 = table.Column<string>(nullable: true),
                    Cheked21 = table.Column<bool>(nullable: false),
                    Answer21 = table.Column<string>(nullable: true),
                    Score21 = table.Column<int>(nullable: false),
                    Id22 = table.Column<int>(nullable: false),
                    Q22 = table.Column<string>(nullable: true),
                    Cheked22 = table.Column<bool>(nullable: false),
                    Answer22 = table.Column<string>(nullable: true),
                    Score22 = table.Column<int>(nullable: false),
                    Id23 = table.Column<int>(nullable: false),
                    Q23 = table.Column<string>(nullable: true),
                    Cheked23 = table.Column<bool>(nullable: false),
                    Answer23 = table.Column<string>(nullable: true),
                    Score23 = table.Column<int>(nullable: false),
                    Id24 = table.Column<int>(nullable: false),
                    Q24 = table.Column<string>(nullable: true),
                    Cheked24 = table.Column<bool>(nullable: false),
                    Answer24 = table.Column<string>(nullable: true),
                    Score24 = table.Column<int>(nullable: false),
                    Id25 = table.Column<int>(nullable: false),
                    Q25 = table.Column<string>(nullable: true),
                    Cheked25 = table.Column<bool>(nullable: false),
                    Answer25 = table.Column<string>(nullable: true),
                    Score25 = table.Column<int>(nullable: false),
                    Id26 = table.Column<int>(nullable: false),
                    Q26 = table.Column<string>(nullable: true),
                    Cheked26 = table.Column<bool>(nullable: false),
                    Answer26 = table.Column<string>(nullable: true),
                    Score26 = table.Column<int>(nullable: false),
                    Id27 = table.Column<int>(nullable: false),
                    Q27 = table.Column<string>(nullable: true),
                    Cheked27 = table.Column<bool>(nullable: false),
                    Answer27 = table.Column<string>(nullable: true),
                    Score27 = table.Column<int>(nullable: false),
                    Id28 = table.Column<int>(nullable: false),
                    Q28 = table.Column<string>(nullable: true),
                    Cheked28 = table.Column<bool>(nullable: false),
                    Answer28 = table.Column<string>(nullable: true),
                    Score28 = table.Column<int>(nullable: false),
                    Id29 = table.Column<int>(nullable: false),
                    Q29 = table.Column<string>(nullable: true),
                    Cheked29 = table.Column<bool>(nullable: false),
                    Answer29 = table.Column<string>(nullable: true),
                    Score29 = table.Column<int>(nullable: false),
                    Id30 = table.Column<int>(nullable: false),
                    Q30 = table.Column<string>(nullable: true),
                    Cheked30 = table.Column<bool>(nullable: false),
                    Answer30 = table.Column<string>(nullable: true),
                    Score30 = table.Column<int>(nullable: false),
                    CurrentAttempt = table.Column<int>(nullable: false),
                    TestStart = table.Column<bool>(nullable: false),
                    QestEnd = table.Column<bool>(nullable: false),
                    TestEnd = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbTempQuestions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DbAnswer",
                columns: new[] { "Id", "CheckCorrectAnswer", "CheckdAnswer", "CorrectAnswer", "QuestionId", "QuestionVariantContent" },
                values: new object[,]
                {
                    { 1, false, false, false, 1, "sxal" },
                    { 212, false, false, false, 71, "sxal1" },
                    { 211, false, false, true, 71, "հանձնաժողովի նախագահի հանձնարարությամբ ընտրողին հատկացնում է նոր քվեաթերթիկ, սխալ լրացված (վնասված) քվեաթերթիկը (քվեաթերթիկները) անհապաղ մարվում են" },
                    { 209, false, false, true, 70, "դիմում է հանձնաժողովի նախագահին` նոր քվեաթերթիկ (ԱԺ ընտրության ժամանակ՝ յուրաքանչյուր կուսակցության մեկական քվեաթերթիկ) ստանալու համար" },
                    { 208, false, false, false, 70, "sxal1" },
                    { 207, false, false, false, 69, "sxal" },
                    { 206, false, false, true, 69, "տեղամասային ընտրական հանձնաժողովի նախագահի կողմից" },
                    { 205, false, false, false, 69, "sxal1" },
                    { 204, false, false, false, 68, "sxal" },
                    { 203, false, false, false, 68, "sxal1" },
                    { 202, false, false, true, 68, "մասնագետն այդ մասին տեղեկացնում է հանձնաժողովի նախագահին, ով քվեարկության սենյակ է հրավիրում ոստիկանության ծառայողներին, որոնք ձեռնարկում են օրենքով սահմանված միջոցներ" },
                    { 201, false, false, false, 67, "sxal" },
                    { 200, false, false, false, 67, "sxal1" },
                    { 199, false, false, true, 67, "հանձնաժողովի նախագահը, կամ նրա հանձնարարությամբ հանձնաժողովի քարտուղարը կամ այլ անդամ" },
                    { 198, false, false, true, 66, "տեխնիկական սարքավորման խափանման կամ չլինելու պարագայում քվեարկության ժամանակ " },
                    { 197, false, false, false, 66, "sxal" },
                    { 213, false, false, false, 71, "sxal" },
                    { 196, false, false, false, 66, "sxal1" },
                    { 214, false, false, true, 72, "ստացիոնար բուժման մեջ գտնվող ընտրողների լրացուցիչ ցուցակները" },
                    { 216, false, false, false, 72, "sxal" },
                    { 231, false, false, false, 77, "sxal1" },
                    { 230, false, false, true, 77, ". համայնքի ավագանու ընտրության քվեարկության արդյունքները" },
                    { 229, false, false, false, 77, "sxal" },
                    { 228, false, false, false, 76, "sxal1" },
                    { 227, false, false, true, 76, "հաշվի չեն առնվում և չեն հաշվարկվում" },
                    { 226, false, false, false, 76, "sxal" },
                    { 225, false, false, false, 75, "sxal" },
                    { 224, false, false, false, 75, "sxal1" },
                    { 223, false, false, true, 75, "հանձնաժողովի անդամի առաջարկությունը" },
                    { 222, false, false, false, 74, "sxal" },
                    { 221, false, false, false, 74, "sxal1" },
                    { 220, false, false, true, 74, "տեղամասային կենտրոնում" },
                    { 219, false, false, false, 73, "sxal1" },
                    { 218, false, false, true, 73, "քվեարկության օրը, այն պահին, երբ ընտրական տեղամաս են այցելում զորամասի ցուցակում ընդգրկված ընտրողները" },
                    { 217, false, false, false, 73, "sxal" },
                    { 215, false, false, false, 72, "sxal1" },
                    { 195, false, false, false, 65, "sxal" },
                    { 194, false, false, true, 65, "շրջիկ արկղով քվեարկության ժամանակ" },
                    { 193, false, false, false, 65, "sxal1" },
                    { 172, false, false, false, 58, "sxal1" },
                    { 171, false, false, false, 57, "sxal" },
                    { 170, false, false, true, 57, "տեխնիկակական սարքավորման խափանման կամ չլինելու պարագայում" },
                    { 169, false, false, false, 57, "sxal1" },
                    { 168, false, false, false, 56, "sxal" },
                    { 167, false, false, true, 56, "շրջիկ արկղով քվեարկության դեպքում " },
                    { 166, false, false, false, 56, "sxal1" },
                    { 165, false, false, false, 55, "sxal" },
                    { 164, false, false, false, 55, "sxal1" },
                    { 163, false, false, true, 55, "ոչ ուշ, քան մինչև ժամը 20:00-ն" },
                    { 162, false, false, false, 54, "sxal" },
                    { 161, false, false, false, 54, "sxal1" },
                    { 160, false, false, true, 54, "հանձնաժողովի անդամը տեղեկացնում է տեղամասային հանձնաժողովի նախագահին, որն ընտրողից վերցնում է քվեարկության ծրարը, անհապաղ մարում է՝ առանց պարունակությունը ստուգելու" },
                    { 159, false, false, false, 53, "sxal" },
                    { 158, false, false, true, 53, "ընտրական հանձնաժողովի անդամ, վստահված անձ, դիտորդ, այցելու, զանգվածային լրատվության միջոցի ներկայացուցիչ" },
                    { 173, false, false, false, 58, "sxal" },
                    { 174, false, false, true, 58, "քրեակատարողական հիմնարկում " },
                    { 175, false, false, true, 59, "միայն մեկ" },
                    { 176, false, false, false, 59, "sxal1" },
                    { 192, false, false, false, 64, "sxal" },
                    { 191, false, false, false, 64, "sxal1" },
                    { 190, false, false, true, 64, "քրեակատարողական հիմնարկում քվեարկության ժամանակ" },
                    { 189, false, false, false, 63, "sxal" },
                    { 188, false, false, true, 63, "կցվում են քվեարկության օրն ընտրական տեղամասում կազմվող ընտրողների լրացուցիչ ցուցակին" },
                    { 187, false, false, false, 63, "sxal1" },
                    { 186, false, false, false, 62, "sxal" },
                    { 232, false, false, true, 78, "ըստ առավել կողմ քվեարկված քվեաթերթիկներ ստացած կուսակցությունների " },
                    { 185, false, false, true, 62, "ձերբակալված անձանց պահելու վայրում քվեարկության օրը գտնվող ընտրողների համար" },
                    { 183, false, false, true, 61, "ստացիոնար բուժման մեջ գտնվող, քվեարկության օրը տեղամասային կենտրոն ինքնուրույն ներկայանալու հնարավորություն չունեցող անձանց համար " },
                    { 182, false, false, false, 61, "sxal1" },
                    { 181, false, false, false, 61, "sxal" },
                    { 180, false, false, false, 60, "sxal1" },
                    { 179, false, false, true, 60, "քվեարկության օրը՝ ժամը 8:00-ից հետո, բայց այն հաշվարկով, որ քվեարկությունն ավարտվի մինչև ժամը 18:00-ն" },
                    { 178, false, false, false, 60, "sxal" },
                    { 177, false, false, false, 59, "sxal" },
                    { 184, false, false, false, 62, "sxal1" },
                    { 233, false, false, false, 78, "sxal1" },
                    { 234, false, false, false, 78, "sxal" },
                    { 235, false, false, false, 79, "sxal" },
                    { 289, false, false, false, 97, "sxal1" },
                    { 288, false, false, false, 96, "sxal" },
                    { 287, false, false, false, 96, "sxal1" },
                    { 286, false, false, true, 96, "առանձին-առանձին հաշվվում են ընտրողներից ստացված տեխնիկական սարքավորման միջոցով տպված և համարակալված քվեարկության կտրոնները" },
                    { 285, false, false, false, 95, "sxal" },
                    { 284, false, false, false, 95, "sxal1" },
                    { 283, false, false, true, 95, "առանց հաշվելու փաթեթավորվում են չօգտագործված քվեաթերթիկները" },
                    { 282, false, false, false, 94, "sxal" },
                    { 281, false, false, false, 94, "sxal1" },
                    { 280, false, false, true, 94, "փաթեթավորվում են հանձնաժողովի անդամների անհատական կնիքները, փաթեթը կնքվում և տեղադրվում է ընտրական փաստաթղթերի պարկում" },
                    { 279, false, false, true, 93, "ըստ ընտրողների ցուցակում առկա ընտրողների ստորագրությունների հաշվում է քվեարկության մասնակիցների ընդհանուր թիվը" },
                    { 278, false, false, false, 93, "sxal" },
                    { 277, false, false, false, 93, "sxal1" },
                    { 276, false, false, false, 92, "sxal1" },
                    { 275, false, false, true, 92, "հաշվում է չօգտագործված ինքնասոսնձվող դրոշմանիշերը, փաթեթավորում, փաթեթը կնքում և տեղադրում է պարկում" },
                    { 290, false, false, true, 97, "տեղամասային ընտրական հանձնաժողովի մյուս անդամները և վստահված անձինք" },
                    { 291, false, false, false, 97, "sxal" },
                    { 292, false, false, false, 98, "sxal1" },
                    { 293, false, false, true, 98, "չօգտագործված քվեաթերթիկները " },
                    { 309, false, false, true, 103, "չորս օրինակից" },
                    { 308, false, false, false, 103, "sxal" },
                    { 307, false, false, false, 103, "sxal1" },
                    { 306, false, false, true, 102, "չի կարող ընդհատվել" },
                    { 305, false, false, false, 102, "sxal1" },
                    { 304, false, false, false, 102, "sxal" },
                    { 303, false, false, false, 101, "sxal" },
                    { 274, false, false, false, 92, "sxal" },
                    { 302, false, false, false, 101, "sxal1" },
                    { 300, false, false, false, 100, "sxal" },
                    { 299, false, false, true, 100, "հանձնաժողովի կնիքը" },
                    { 298, false, false, false, 100, "sxal1" },
                    { 297, false, false, false, 99, "sxal" },
                    { 296, false, false, false, 99, "sxal1" },
                    { 295, false, false, true, 99, "հանձնաժողովի գրանցամատյանը և քվեարկության արդյունքների արձանագրության երկու օրինակը" },
                    { 294, false, false, false, 98, "sxal" },
                    { 301, false, false, true, 101, "ոչ ուշ, քան 14 ժամվա ընթացքում, ներկայացնում են տարածքային ընտրական հանձնաժողով" },
                    { 157, false, false, false, 53, "sxal1" },
                    { 273, false, false, false, 91, "sxal" },
                    { 271, false, false, true, 91, "հաստատված նմուշի այն քվեաթերթիկը, որը հանվել է ծրարից, և որի վրա փակցված է այդ ընտրական տեղամասի ինքնասոսնձվող դրոշմանիշը" },
                    { 250, false, false, true, 84, "լրացուցիչ ցուցակների ընտրողների և ընտրողների ցուցակում ընդգրկված ընտրողների թվերի գումարին " },
                    { 249, false, false, false, 83, "sxal1" },
                    { 248, false, false, true, 83, "հաշվարկում ընդգրկվում է միայն ինքնասոսնձվող դրոշմանիշով քվեաթերթիկը" },
                    { 247, false, false, false, 83, "sxal" },
                    { 246, false, false, false, 82, "sxal" },
                    { 245, false, false, false, 82, "sxal1" },
                    { 244, false, false, true, 82, "քվեարկության արդյունքների արձանագրության մեկ օրինակը " },
                    { 243, false, false, false, 81, "sxal" },
                    { 242, false, false, true, 81, "հանձնաժողովի անդամների անհատական կնիքները" },
                    { 241, false, false, false, 81, "sxal1" },
                    { 240, false, false, false, 80, "sxal" },
                    { 239, false, false, false, 80, "sxal1" },
                    { 238, false, false, true, 80, "հաշվարկված և տեսակավորված քվեաթերթիկները" },
                    { 237, false, false, true, 79, "քվեաթերթիկը ծրարից չի հանվում, քվեարկության ծրարը դրանում գտնվող քվեաթերթիկի հետ անհապաղ մարվում է" },
                    { 236, false, false, false, 79, "sxal1" },
                    { 251, false, false, false, 84, "sxal1" },
                    { 252, false, false, false, 84, "sxal" },
                    { 253, false, false, true, 85, "տեղամասային ընտրական հանձնաժողովի նախագահը" },
                    { 254, false, false, false, 85, "sxal1" },
                    { 270, false, false, false, 90, "sxal" },
                    { 269, false, false, false, 90, "sxal1" },
                    { 268, false, false, true, 90, "մեկ թեկնածու քվեարկվելու դեպքում միաժամանակ «կողմ եմ» և «դեմ եմ» բառերի դիմաց նշումներ է ներառում" },
                    { 267, false, false, false, 89, "sxal" },
                    { 266, false, false, true, 89, "որևէ նշում չի ներառում" },
                    { 265, false, false, false, 89, "sxal1" },
                    { 264, false, false, false, 88, "sxal" },
                    { 272, false, false, false, 91, "sxal1" },
                    { 263, false, false, true, 88, "եթե բացի քվեարկության համար սահմանված կամ դրան նմանվող նշանից ներառում է ավելորդ գրառում" },
                    { 261, false, false, false, 87, "sxal" },
                    { 260, false, false, true, 87, "մեկից ավելի կուսակցության օգտին նշումներ է ներառում" },
                    { 259, false, false, false, 87, "sxal1" },
                    { 258, false, false, false, 86, "sxal" },
                    { 257, false, false, true, 86, "սահմանված  նմուշի քվեաթերթիկն անվավեր է, եթե ներառում է ավելորդ գրառում" },
                    { 256, false, false, false, 86, "sxal1" },
                    { 255, false, false, false, 85, "sxal" },
                    { 262, false, false, false, 88, "sxal1" },
                    { 156, false, false, false, 52, "sxal" },
                    { 210, false, false, false, 70, "sxal" },
                    { 154, false, false, false, 52, "sxal1" },
                    { 55, false, false, false, 19, "sxal1" },
                    { 54, false, false, false, 18, "sxal" },
                    { 53, false, false, true, 18, "միմյանցից առնվազն 1 մետր հեռավորությամբ և այն դիրքով, որ ընտրողը քվեարկելիս լինի հանձնաժողովին դեմքով և թիկունքով դեպի պատը" },
                    { 52, false, false, false, 18, "sxal1" },
                    { 51, false, false, true, 17, "քվեարկության սենյակում կամ դրա մուտքի մոտ" },
                    { 50, false, false, false, 17, "sxal" },
                    { 49, false, false, false, 17, "sxal1" },
                    { 48, false, false, false, 16, "sxal" },
                    { 47, false, false, false, 16, "sxal1" },
                    { 46, false, false, true, 16, "գրառվում են տեղամասային ընտրական հանձնաժողովի գրանցամատյանում" },
                    { 45, false, false, false, 15, "sxal" },
                    { 44, false, false, true, 15, "այո, եթե քվեարկության սենյակում գտնվող ընտրողների թիվն այնքան է, որ ակնհայտորեն խաթարվում է քվեարկության բնականոն ընթացքը" },
                    { 43, false, false, false, 15, "sxal1" },
                    { 42, false, false, false, 14, "sxal" },
                    { 41, false, false, false, 14, "sxal1" },
                    { 56, false, false, false, 19, "sxal" },
                    { 57, false, false, true, 19, "քվեարկության օրվանից ոչ շուտ, քան 20, և ոչ ուշ, քան 18 օր առաջ` մինչև ժամը 18:00-ն" },
                    { 58, false, false, false, 20, "sxal1" },
                    { 59, false, false, false, 20, "sxal" },
                    { 75, false, false, true, 25, "մինչև երկու վստահված անձ" },
                    { 74, false, false, false, 25, "sxal1" },
                    { 73, false, false, false, 25, "sxal" },
                    { 72, false, false, false, 24, "sxal" },
                    { 71, false, false, false, 24, "sxal1" },
                    { 70, false, false, true, 24, "յուրաքանչյուր թեկնածուի մեկ վստահված անձ" },
                    { 69, false, false, false, 23, "sxal" },
                    { 40, false, false, true, 14, "քվեարկության արդյունքների արձանագրությունը" },
                    { 68, false, false, true, 23, "կարող են լուսանկարել, տեսանկարահանել քվեարկության արդյունքների ամփոփման գործընթացը" },
                    { 66, false, false, false, 22, "sxal" },
                    { 65, false, false, false, 22, "sxal1" },
                    { 64, false, false, true, 22, "վստահված անձինք, դիտորդները, այցելուները, զանգվածային լրատվության միջոցների ներկայացուցիչներն ու վերադաս ընտրական հանձնաժողովի անդամները" },
                    { 63, false, false, false, 21, "sxal" },
                    { 62, false, false, false, 21, "sxal1" },
                    { 61, false, false, true, 21, "յուրաքանչյուր տեղական դիտորդական կազմակերպությունից 1 դիտորդ" },
                    { 60, false, false, true, 20, "յուրաքանչյուր միջազգային կազմակերպությունից մինչև 2 դիտորդ` թարգմանչի ուղեկցությամբ " },
                    { 67, false, false, false, 23, "sxal1" },
                    { 76, false, false, false, 26, "sxal" },
                    { 39, false, false, false, 13, "sxal" },
                    { 37, false, false, true, 13, "հանձնաժողովի անդամների միջև գործառույթների բաշխման" },
                    { 16, false, false, false, 6, "sxal1" },
                    { 15, false, false, false, 5, "sxal" },
                    { 14, false, false, false, 5, "sxal1" },
                    { 13, false, false, true, 5, "առնվազն 7 անդամ" },
                    { 12, false, false, false, 4, "sxal" },
                    { 11, false, false, true, 4, "քվեարկության օրը ժամը 7:00-ին` վիճակահանությամբ" },
                    { 10, false, false, false, 4, "sxal1" },
                    { 9, false, false, false, 3, "sxal" },
                    { 8, false, false, true, 3, "քվեարկության օրվանից ոչ շուտ, քան 30, և ոչ ուշ, քան 25 օր առաջ` մինչև ժամը 18:00-ն " },
                    { 7, false, false, false, 3, "sxal1" },
                    { 6, false, false, false, 2, "sxal" },
                    { 5, false, false, true, 2, "քվեարկության օրվանից 2 օր առաջ" },
                    { 4, false, false, false, 2, "sxal1" },
                    { 3, false, false, false, 1, "sxal1" },
                    { 2, false, false, true, 1, "եթե կողմ են  քվեարկել նիստին ներկա հանձնաժողովի անդամների թվի կեսից ավելին, բացառությամբ օրենքով սահմանված դեպքերի " },
                    { 17, false, false, false, 6, "sxal" },
                    { 18, false, false, true, 6, "հանձնաժողովի կազմավորման օրվանից հետո` 3-րդ օրը` ժամը 12:00-ին" },
                    { 19, false, false, true, 7, "եթե նիստին ներկա է հանձնաժողովի անդամների կեսից ավելին" },
                    { 20, false, false, false, 7, "sxal1" },
                    { 36, false, false, true, 12, "Ազգային ժողովում խմբակցություն ունեցող կուսակցությունները, կուսակցությունների դաշինքները և համապատասխան տարածքային ընտրական հանձնաժողովը" },
                    { 35, false, false, false, 12, "sxal1" },
                    { 34, false, false, false, 12, "sxal" },
                    { 33, false, false, true, 11, "կազմակերպում է ընտրությունների և հանրաքվեների քվեարկությունը, ամփոփում քվեարկության արդյունքներն ընտրական տեղամասում" },
                    { 32, false, false, false, 11, "sxal1" },
                    { 31, false, false, false, 11, "sxal" },
                    { 30, false, false, false, 10, "sxal" },
                    { 38, false, false, false, 13, "sxal1" },
                    { 29, false, false, false, 10, "sxal1" },
                    { 27, false, false, false, 9, "sxal1" },
                    { 26, false, false, false, 9, "sxal" },
                    { 25, false, false, true, 9, "քվեարկության օրվանից ոչ ուշ, քան 10 օր առաջ` մինչև ժամը 14:00-ն" },
                    { 155, false, false, true, 52, "գրառվում են տեղամասային ընտրական հանձնաժողովի գրանցամատյանում" },
                    { 23, false, false, true, 8, "միայն Ազգային ժողովի ընտրությունների ժամանակ" },
                    { 22, false, false, false, 8, "sxal" },
                    { 21, false, false, false, 7, "sxal" },
                    { 28, false, false, true, 10, "նաև նրանց նշանակող կուսակցության կամ տարածքային ընտրական հանձնաժողովի նախագահի կողմից՝ տեղամասային ընտրական հանձնաժողովի անդամի դիմումի հիման վրա" },
                    { 77, false, false, false, 26, "sxal1" },
                    { 24, false, false, false, 8, "sxal1" },
                    { 79, false, false, false, 27, "sxal1" },
                    { 133, false, false, false, 45, "sxal" },
                    { 132, false, false, false, 44, "sxal1" },
                    { 131, false, false, true, 44, "եթե ընտրողն իր անձը հաստատող որևէ փաստաթղթով արդեն իսկ մասնակցել է քվեարկությանը" },
                    { 130, false, false, false, 44, "sxal" },
                    { 129, false, false, false, 43, "sxal1" },
                    { 128, false, false, true, 43, "սոսնձվում է տեղամասային ընտրական հանձնաժողովի գրանցամատյանում" },
                    { 127, false, false, false, 43, "sxal" },
                    { 126, false, false, false, 42, "sxal" },
                    { 125, false, false, false, 42, "sxal1" },
                    { 124, false, false, true, 42, "ոչ կենսաչափական անձնագիրը " },
                    { 123, false, false, true, 41, "կենսաչափական անձնագիրը" },
                    { 122, false, false, false, 41, "sxal1" },
                    { 121, false, false, false, 41, "sxal" },
                    { 120, false, false, false, 40, "sxal1" },
                    { 119, false, false, true, 40, "նույնականացման քարտը " },
                    { 134, false, false, true, 45, "եթե ընտրողը գրանցված չէ տվյալ ընտրական տեղամասի ընտրողների ցուցակում" },
                    { 135, false, false, false, 45, "sxal1" },
                    { 136, false, false, false, 46, "sxal" },
                    { 137, false, false, false, 46, "sxal1" },
                    { 153, false, false, false, 51, "sxal" },
                    { 152, false, false, false, 51, "sxal1" },
                    { 151, false, false, true, 51, "իրավասու է իր որոշմամբ սահմանելու քվեարկության սենյակում միաժամանակյա գտնվելու իրավունք ունեցող դիտորդների և զանգվածային լրատվության միջոցների ներկայացուցիչների առավելագույն թիվը" },
                    { 150, false, false, false, 50, "sxal" },
                    { 149, false, false, true, 50, "քվեաթերթիկի վրա ինքնասոսնձվող դրոշմանիշը փակցնելուց հետո" },
                    { 148, false, false, false, 50, "sxal1" },
                    { 147, false, false, false, 49, "sxal" },
                    { 117, false, false, false, 39, "sxal1" },
                    { 146, false, false, false, 49, "sxal1" },
                    { 144, false, false, true, 48, "տվյալ տեխնիկական սարքավորման միջոցով գրանցված ընտրողների բացակայությունը հավաստող տեղեկանք" },
                    { 143, false, false, false, 48, "sxal1" },
                    { 142, false, false, false, 48, "sxal" },
                    { 141, false, false, false, 47, "sxal1" },
                    { 140, false, false, true, 47, "քվեարկության խցիկում" },
                    { 139, false, false, false, 47, "sxal" },
                    { 138, false, false, true, 46, "իր անհատական կնիքը" },
                    { 145, false, false, true, 49, "արգելվում է" },
                    { 116, false, false, true, 39, "հանձնաժողովի անդամն առանց քվեարկության ծրարը  ընտրողից վերցնելու  քվեարկության ծրարի կտրվածքի միջով ինքնասոսնձվող դրոշմանիշը   փակցնում է քվեաթերթիկին" },
                    { 118, false, false, false, 40, "sxal" },
                    { 114, false, false, false, 38, "sxal" },
                    { 95, false, false, false, 32, "sxal1" },
                    { 94, false, false, true, 32, "բողոքարկելու ընտրական հանձնաժողովների որոշումները, գործողությունները, անգործությունը" },
                    { 93, false, false, false, 31, "sxal" },
                    { 92, false, false, true, 31, "խորհրդակցական ձայնի իրավունքով մասնակցելու հանձնաժողովի նիստերին" },
                    { 91, false, false, false, 31, "sxal1" },
                    { 90, false, false, false, 30, "sxal" },
                    { 89, false, false, false, 30, "sxal1" },
                    { 115, false, false, false, 39, "sxal" },
                    { 88, false, false, true, 30, "խաթարելու ընտրական հանձնաժողովի բնականոն աշխատանքը կամ քվեարկության բնականոն ընթացքը " },
                    { 86, false, false, true, 29, "ներկա գտնվելու ընտրական հանձնաժողովի նիստերին, իսկ քվեարկության ընթացքում` նաև քվեարկության սենյակում " },
                    { 85, false, false, false, 29, "sxal1" },
                    { 84, false, false, false, 28, "sxal" },
                    { 83, false, false, true, 28, "քվեարկության արդյունքների ամփոփման նիստին ներկա գտնվելու իրավունք ունեցող անձինք" },
                    { 82, false, false, false, 28, "sxal1" },
                    { 81, false, false, false, 27, "sxal" },
                    { 80, false, false, true, 27, "չեն կարող ունենալ վստահված անձ" },
                    { 87, false, false, false, 29, "sxal" },
                    { 97, false, false, false, 33, "sxal1" },
                    { 96, false, false, false, 32, "sxal" },
                    { 99, false, false, false, 33, "sxal" },
                    { 113, false, false, false, 38, "sxal1" },
                    { 112, false, false, true, 38, "քվեարկության կտրոնը" },
                    { 111, false, false, false, 37, "sxal" },
                    { 110, false, false, true, 37, "տեղամասային ընտրական հանձնաժողովի նախագահը նրան նոր ինքնասոսնձվող դրոշմանիշեր է հանձնում նրանից քվեարկության կտրոնները ստանալուց հետո" },
                    { 109, false, false, false, 37, "sxal1" },
                    { 98, false, false, true, 33, "անձամբ" },
                    { 107, false, false, false, 36, "sxal" },
                    { 108, false, false, true, 36, "հիմք չէ նրան քվեարկության չթողնելու համար, բացառությամբ այն դեպքի, երբ տեխնիկական սարքավորումում առկա տեղեկություններից պարզվում է, որ ընտրողն ունի այլ` վավերականության ժամկետը չլրացած, անձը հաստատող փաստաթուղթ" },
                    { 105, false, false, false, 35, "sxal" },
                    { 104, false, false, true, 35, "ընտրական տեղամասում քվեարկությանը մասնակցած ընտրողների թիվը" },
                    { 103, false, false, false, 35, "sxal1" },
                    { 102, false, false, true, 34, "ընտրողների ցուցակում գտնում է ընտրողի տողը, ընտրողը ստորագրում է համապատասխան սյունակում, հաջորդ սյունակում հանձնաժողովի անդամը դնում է իր անհատական կնիքը, որից հետո անհատական կնիքով կնքում քվեարկության կտրոնը և այն փոխանցում ընտրողին " },
                    { 101, false, false, false, 34, "sxal" },
                    { 100, false, false, false, 34, "sxal1" },
                    { 106, false, false, false, 36, "sxal1" },
                    { 78, false, false, true, 26, "իրավունք ունի պահանջելու, որ իր գնահատականը արձանագրվի տեղամասային ընտրական հանձնաժողովի գրանցամատյանում" }
                });

            migrationBuilder.InsertData(
                table: "DbEmptyTextViewModel",
                columns: new[] { "Id", "AllAdditionallyDuringElDay", "AllMobileVoters", "CEC", "Community", "ForA", "ForAx", "ForAy", "ForB", "ForBm", "ForBn", "ForC", "ForCk", "ForCl", "InvalidTickets", "ListAll", "NumerableTickets", "PartMobileVoters", "Participants", "Region", "TEC", "TecGlueTickets", "TecNumerableTickets", "UnusedGlueTickets", "UnusedNumerableTickets", "VadTickets" },
                values: new object[,]
                {
                    { 5, 2, 7, 55, "Շիրակ", 40, 13, 27, 250, 150, 100, 110, 45, 65, 7, 420, 17, 5, 400, "Շիրակի", "55/1", 500, 441, 93, 424, 390 },
                    { 1, 3, 7, 55, "Շիրակ", 81, 31, 49, 52, 23, 29, 34, 27, 7, 11, 250, 5, 5, 170, "Շիրակի", "55/1", 300, 263, 122, 258, 173 },
                    { 4, 3, 5, 55, "Շիրակ", 100, 51, 49, 320, 205, 115, 72, 30, 42, 15, 720, 27, 4, 500, "Շիրակի", "55/1", 800, 756, 293, 729, 480 },
                    { 3, 2, 4, 55, "Շիրակ", 60, 20, 40, 210, 170, 40, 160, 90, 70, 6, 510, 8, 4, 430, "Շիրակի", "55/1", 600, 536, 164, 528, 428 },
                    { 2, 1, 3, 55, "Շիրակ", 120, 80, 40, 280, 150, 130, 213, 95, 118, 11, 840, 24, 3, 620, "Շիրակի", "55/1", 900, 882, 300, 858, 600 },
                    { 7, 3, 10, 55, "Շիրակ", 10, 5, 5, 40, 10, 30, 60, 40, 20, 3, 120, 18, 10, 100, "Շիրակի", "55/1", 200, 126, 87, 108, 95 },
                    { 6, 3, 10, 55, "Շիրակ", 300, 170, 130, 290, 60, 230, 236, 136, 100, 15, 960, 41, 8, 830, "Շիրակի", "55/1", 1000, 1008, 159, 967, 800 }
                });

            migrationBuilder.InsertData(
                table: "DbQuestion",
                columns: new[] { "Id", "QId", "QuestionContent" },
                values: new object[,]
                {
                    { 7, 7, "Ընտրական հանձնաժողովի նիստը ե՞րբ է համարվում իրավազոր`" },
                    { 81, 81, "Նշվածներից ի՞նչն է դրվում մեկանգամյա օգտագործման պարկի մեջ`" },
                    { 80, 80, "Նշվածներից ի՞նչն է դրվում մեկանգամյա օգտագործման պարկի մեջ`" },
                    { 79, 79, "Քվեարկության արդյունքներն ամփոփելիս ի՞նչ գործողություն է կատարում տեղամասային ընտրական հանձնաժողովը քվեարկության ծրարի վրա ավելորդ գրառում լինելու դեպքում`" },
                    { 78, 78, "Ի՞նչ հաջորդականությամբ է հաշվարկվում կուսակցության տարածքային ցուցակում ընդգրկված թեկնածուին կողմ քվեարկված քվեաթերթիկների թիվը(Ազգային ժողովի ընտրությունների ժամանակ)`" },
                    { 77, 77, "Միաժամանակ համայնքի ղեկավարի և ավագանու ընտրությունների դեպքում տեղամասային ընտրական հանձնաժողովն առաջին հերթին ամփոփում է`" },
                    { 76, 76, "Քվեարկության արդյունքներն ամփոփելիս չսահմանված նմուշի քվեաթերթիկները`" },
                    { 75, 75, "Քվեաթերթիկի վավեր (անվավեր) լինելու վերաբերյալ առարկության դեպքում քվեարկության է դրվում`" },
                    { 74, 74, "Զինծառայողները քվեարկում են`" },
                    { 73, 73, "Զորամասում հաշվառված ընտրողների ցուցակները տեղամասային ընտրական հանձնաժողովի կողմից բացվում են միայն`" },
                    { 72, 72, "Տեխնիկական սարքավորման մեջ չեն ներբեռնվում՝" },
                    { 71, 71, "Ընտրական հանձնաժողովի անդամի գործողություններն ընտրողի կողմից քվեաթերթիկը սխալ լրացնելու կամ վնասելու դեպքում`" },
                    { 70, 70, "Ընտրողի գործողությունները քվեաթերթիկը սխալ լրացնելու կամ վնասելու դեպքում`" },
                    { 69, 69, "Տեղամասային ընտրական հանձնաժողովի կազմած ընտրողների լրացուցիչ ցուցակի յուրաքանչյուր էջ ստորագրվում և կնքվում է`" },
                    { 68, 68, "Եթե ընտրողը ներկայացրել է այլ անձի անձը հաստատող փաստաթուղթ, ապա`" },
                    { 67, 67, "Մասնագետի ժամանակավոր բացակայության դեպքում, ո՞վ կարող է նրան փոխարինել`" },
                    { 66, 66, "Ո՞ր դեպքում է հանձնաժողովի անդամը լրացնում համարակալված կտրոնը`" },
                    { 65, 65, "Ո՞ր դեպքում է հանձնաժողովի անդամը լրացնում համարակալված կտրոնը`" },
                    { 64, 64, "Ո՞ր դեպքում է հանձնաժողովի անդամը լրացնում համարակալված կտրոնը`" },
                    { 63, 63, "Ընտրողին ընտրողների լրացուցիչ ցուցակում ընդգրկելու համար հիմք համարվող փաստաթղթերը`" }
                });

            migrationBuilder.InsertData(
                table: "DbQuestion",
                columns: new[] { "Id", "QId", "QuestionContent" },
                values: new object[,]
                {
                    { 62, 62, "Շրջիկ արկղով քեարկությունը կազմակերպվում է՝ " },
                    { 61, 61, "Շրջիկ արկղով քվեարկությունը կազմակերպվում է՝ " },
                    { 82, 82, "Նշվածներից ի՞նչն է դրվում մեկանգամյա օգտագործման պարկի մեջ`" },
                    { 83, 83, "Ընտրական հանձնաժողովի գործողությունները քվեարկության ծրարի մեջ մեկից ավելի քվեաթերթիկներ հայտնաբերելու դեպքում`" },
                    { 84, 84, "Ընտրական տեղամասում ընտրողների ընդհանուր թիվը հավասար է`" },
                    { 85, 85, "Տեղամասային ընտրական հանձնաժողովում մեկանգամյա օգտագործման պարկը սահմանված կարգով փակելու համար պատասխանատու է` " },
                    { 1, 1, "Ընտրական հանձնաժողովի որոշումը ե՞րբ է համարվում ընդունված`" },
                    { 2, 2, "Տեղամասային ընտրական հանձնաժողովի նախագահը ընտրողների ցուցակի օրինակը տեղամասային կենտրոնում՝ բոլորի համար տեսանելի տեղում փակցնում է`" },
                    { 3, 3, "Հերթական ընտրությունների դեպքում ե՞րբ է կազմավորվում տեղամասային ընտրական հանձնաժողովը`" },
                    { 4, 4, "Ե՞րբ է իրականացվում տեղամասային ընտրական հանձնաժողովի անդամների միջև գործառույթների բաշխումը և ի՞նչպես`" },
                    { 103, 103, "Քանի՞ օրինակից է կազմվում ընտրական տեղամասում քվեարկության արդյունքների արձանագրությունը`" },
                    { 102, 102, "Քվեարկության ավարտից հետո՝ մինչև ընտրական տեղամասում քվեարկության արդյունքների վերաբերյալ արձանագրություն կազմելը, տեղամասային ընտրական հանձնաժողովի նիստը`" },
                    { 101, 101, "Տեղամասային ընտրական հանձնաժողովի նախագահը և քարտուղարը պարկը, քվեարկության արդյունքների արձանագրության երկու օրինակը, գրանցամատյանը, հանձնաժողովի կնիքը և տեխնիկական սարքավորումը քվեարկության ավարտից հետո՝" },
                    { 100, 100, "Նշվածներից ի՞նչն է առձեռն ներկայացվում տարածքային ընտրական հանձնաժողով`" },
                    { 99, 99, "Նշվածներից ի՞նչն է առձեռն ներկայացվում տարածքային ընտրական հանձնաժողով`" },
                    { 98, 98, "Նշվածներից ի՞նչն է առձեռն ներկայացվում տարածքային ընտրական հանձնաժողով`" },
                    { 60, 60, "Ե՞րբ է անցկացվում շրջիկ արկղով քվեարկությունը`" },
                    { 97, 97, "Հանձնաժողովի նախագահից բացի, ովքե՞ր իրավունք ունեն ստորագրելու հաշվարկված և տեսակավորված քվեաթերթիկների փաթեթների վրա`" },
                    { 95, 95, "Նշվածներից ո՞ր գործողությունն է կատարվում քվեարկության արդյունքների ամփոփման նիստում` ժամը 20:00-ից մինչև քվեատուփը բացելը`" },
                    { 94, 94, "Նշվածներից ո՞ր գործողությունն է կատարվում քվեարկության արդյունքների ամփոփման նիստում` ժամը 20:00-ից մինչև քվեատուփը բացելը`" },
                    { 93, 93, "Նշվածներից ո՞ր գործողությունն է կատարվում քվեարկության արդյունքների ամփոփման նիստում` ժամը 20:00-ից մինչև քվեատուփը բացելը`" },
                    { 92, 92, "Տեղամասային ընտրական հանձնաժողովը նշվածներից ո՞ր գործողությունն է կատարում քվեարկության արդյունքների ամփոփման նիստում` ժամը 20:00-ից մինչև քվեատուփը բացելը`" },
                    { 91, 91, "Ո՞ր քվեաթերթիկն է համարվում սահմանված նմուշի՝" },
                    { 90, 90, "Համայնքի ղեկավարի և ավագանու անդամի ընտրությունների դեպքում սահմանված նմուշի քվեաթերթիկն անվավեր է, եթե`" },
                    { 89, 89, "Համայնքի ղեկավարի և ավագանու անդամի ընտրությունների դեպքում սահմանված նմուշի քվեաթերթիկն անվավեր է, եթե`" },
                    { 88, 88, "Երևանի, Գյումրու, Վանաձորի ավագանիների ընտրությունների դեպքում սահմանված նմուշի քվեաթերթիկն անվավեր է`" },
                    { 87, 87, "Երևանի, Գյումրու, Վանաձորի ավագանիների ընտրությունների դեպքում սահմանված նմուշի քվեաթերթիկն անվավեր է, եթե`" },
                    { 86, 86, "Ազգային Ժողովի ընտրությունների դեպքում ո՞ր քվեաթերթիկն է անվավեր`" },
                    { 96, 96, "Նշվածներից ո՞ր գործողությունն է կատարվում քվեարկության արդյունքների ամփոփման նիստում` ժամը 20:00-ից մինչև քվեատուփը բացելը`" },
                    { 59, 59, "Միևնույն անձը քվեաթերթիկն ինքնուրույն լրացնելու հնարավորություն չունեցող քանի՞ ընտրողի կարող է օգնել`" },
                    { 58, 58, "Ե՞րբ է ընտրողների գրանցումն իրականացվում առանց տեխնիկական սարքավորման կիրառման`" },
                    { 57, 57, "Ե՞րբ է ընտրողների գրանցումն իրականացվում առանց տեխնիկական սարքավորման կիրառման`" },
                    { 29, 29, "Դիտորդը, զանգվածային լրատվության միջոցի ներկայացուցիչը, այցելուն իրավունք ունի`" },
                    { 28, 28, "Ազգային ժողովի ընտրությունների ժամանակ քվեարկության արդյունքների արձանագրությունը ովքե՞ր կարող են լուսանկարել կամ տեսանկարահանել`" },
                    { 27, 27, "Ազգային ժողովի, Երևանի, Գյումրու, Վանաձորի ավագանիների ընտրություններին մասնակցող կուսակցությունների ընտրական ցուցակում ընդգրկված թեկնածուները`" },
                    { 26, 26, "Եթե հանձնաժողովի անդամը, վստահված անձը կամ դիտորդը գտնում է, որ քվեարկության ընթացքում տեղի է ունեցել ընտրական օրենսգրքով նախատեսված քվեարկության կարգի խախտում, ապա`" },
                    { 25, 25, "Ազգային ժողովի ընտրությունների ժամանակ ընտրական հանձնաժողովի նիստին և քվեարկության ընթացքում քվեարկության սենյակում կարող է ներկա գտնվել ընտրություններին մասնակցող յուրաքանչյուր կուսակցության, կուսակցությունների դաշինքի`" },
                    { 24, 24, "Համայնքի ղեկավարի և ավագանու անդամի ընտրությունների ժամանակ ընտրական հանձնաժողովի նիստին և քվեարկության ընթացքում քվեարկության սենյակում կարող են ներկա գտնվել`" },
                    { 23, 23, "Վստահված անձինք, դիտորդները, այցելուները, զանգվածային լրատվության միջոցների ներկայացուցիչները`" },
                    { 22, 22, "Ընտրական հանձնաժողովի անդամներից և քվեարկողներից բացի, ովքե՞ր կարող են ներկա գտնվել քվեարկության սենյակում`" },
                    { 21, 21, "Ընտրական հանձնաժողովի նիստերին, իսկ քվեարկության ընթացքում նաև քվեարկության սենյակում կարող են ներկա գտնվել`" },
                    { 20, 20, "Ընտրական հանձնաժողովի նիստերին, իսկ քվեարկության ընթացքում նաև քվեարկության սենյակում կարող են ներկա գտնվել`" },
                    { 30, 30, "Դիտորդը, զանգվածային լրատվության միջոցի ներկայացուցիչը, այցելուն իրավունք չունի`" },
                    { 19, 19, "Արտահերթ ընտրությունների դեպքում ե՞րբ է կազմավորվում տեղամասային ընտրական հանձնաժողովը`" },
                    { 5, 5, "Քանի՞ անդամ ունի տեղամասային ընտրական հանձնաժողովը`" },
                    { 16, 16, "Տեղամասային ընտրական հանձնաժողովում անցկացվող վիճակահանությունների արդյունքները`" },
                    { 15, 15, "Իրավունք ունի արդյո՞ք տեղամասային ընտրական հանձնաժողովի նախագահը սահմանափակելու քվեարկության սենյակում միաժամանակ գտնվող ընտրողների թիվը`" },
                    { 14, 14, "Հանձնաժողովի անդամը պարտավոր է  ստորագրել`" },
                    { 13, 13, "Տեղամասային ընտրական հանձնաժողովի նախագահը և քարտուղարը նշվածներից ո՞ր վիճակահանությանը չեն մասնակցում`" },
                    { 12, 12, "Ովքե՞ր են նշանակում տեղամասային ընտրական հանձնաժողովի անդամներին`" },
                    { 11, 11, "Նշվածներից ո՞րն է տեղամասային ընտրական հանձնաժողովի լիազորություն`" },
                    { 10, 10, "Ազգային ժողովի ընտրությունների ժամանակ տեղամասային ընտրական հանձնաժողովների անդամները կարող են ընդգրկվել իրենց ընտրական տեղամասի` ըստ գտնվելու վայրի ընտրողների ցուցակում՝" },
                    { 9, 9, "Ազգային ժողովի ընտրությունների ժամանակ տեղամասային ընտրական հանձնաժողովների անդամներին ըստ գտնվելու վայրի ընտրական տեղամասի ընտրողների ցուցակներում ընդգրկելու մասին դիմումը լիազոր մարմին կարող է ներկայացվել՝" },
                    { 8, 8, "Տեղամասային ընտրական հանձնաժողովների անդամները կարող են ընդգրկվել իրենց ընտրական տեղամասի` ըստ գտնվելու վայրի ընտրական տեղամասի ընտրողների ցուցակում՝" },
                    { 18, 18, "Տեղամասային կենտրոնում ինչպե՞ս են տեղադրվում քվեարկության խցիկները`" },
                    { 31, 31, "Վստահված անձն իրավունք ունի`" },
                    { 32, 32, "Վստահված անձն իրավունք ունի`" },
                    { 33, 33, "Ընտրողը քվեարկությանը մասնակցում է`" },
                    { 56, 56, "Ե՞րբ է ընտրողների գրանցումն իրականացվում առանց տեխնիկական սարքավորման կիրառման`" },
                    { 55, 55, "Տեղամասային ընտրական հանձնաժողովի նախագահը կամ վերջինիս հանձնարարությամբ հանձնաժողովի քարտուղարը ե՞րբ են բացում շրջիկ արկղը`" },
                    { 54, 54, "Եթե ընտրողը չի ներկայացնում քվեարկության կտրոն, ապա`" },
                    { 53, 53, "Քվեաթերթիկն ինքնուրույն լրացնելու հնարավորություն չունեցող ընտրողն իրավունք ունի հանձնաժողովի նախագահին տեղեկացնելուց հետո քվեարկության խցիկ հրավիրելու այլ անձի, որը չպետք է լինի`" },
                    { 52, 52, "Քվեաթերթիկն ինքնուրույն լրացնելու հնարավորություն չունեցող ընտրողին օգնող անձի տվյալները`" },
                    { 51, 51, "Եթե քվեարկության սենյակում գտնվող դիտորդների, զանգվածային լրատվության միջոցների ներկայացուցիչների թիվն այնքան է, որ ակնհայտորեն խաթարում է քվեարկության բնականոն ընթացքը, ապա տեղամասային ընտրական հանձնաժողովը`" },
                    { 50, 50, "Ինքնասոսնձվող դրոշմանիշ փակցնող և քվեատուփի համար պատասխանատու անդամը քվեարկության ծրարը քվեատուփի մեջ գցելու հնարավորություն է ընձեռում միայն` " },
                    { 49, 49, "Ընտրողի կողմից կատարած քվեարկության մասին որևէ ձևով տեղեկանալը`" },
                    { 48, 48, ". Քվեարկությունը սկսվելուց առաջ մասնագետը տեխնիկական սարքավորման միջոցով տպում է`" },
                    { 47, 47, "Ընտրողը քվեաթերթիկը լրացնում է կամ քվեաթերթիկներից մեկն ընտրում է`" },
                    { 46, 46, ". Ընտրողի գրանցումն իրականացնող հանձնաժողովի անդամն ընտրողների ցուցակի համապատասխան սյունակում և քվեարկության կտրոնի վրա դնում է`" },
                    { 45, 45, "Ո՞ր դեպքում է էկրանին հայտնվում դեղին նշան`" },
                    { 44, 44, "Ո՞ր դեպքում է էկրանին հայտնվում կարմիր նշան`" },
                    { 43, 43, "Մինչև քվեարկության սկսվելը տեխնիկական սարքավորման միջոցով տպված տեղեկանքը`" },
                    { 42, 42, "Ընտրողի համար անձը հաստատող փաստաթուղթ է համարվում`" },
                    { 41, 41, "Ընտրողի համար անձը հաստատող փաստաթուղթ է համարվում`" },
                    { 40, 40, "Ընտրողի համար անձը հաստատող փաստաթուղթ է համարվում`" },
                    { 39, 39, "Ի՞նչ կարգով է փակցվում ինքնասոսնձվող դրոշմանիշը`" },
                    { 38, 38, "Մինչև ինքնասոսնձվող դրոշմանիշը քվեաթերթիկին փակցնելը, հանձնաժողովի անդամը ընտրողից պետք է ստանա՝" },
                    { 37, 37, "Եթե հանձնաժողովի պատասխանատու անդամին հատկացված ինքնասոսնձվող դրոշմանիշերը սպառվել են,ապա՝" },
                    { 36, 36, "Ընտրողի անձը հաստատող փաստաթղթի վավերականության ժամկետի ավարտը`" },
                    { 35, 35, "Քվեարկության օրը տեղամասային ընտրական հանձնաժողովը  տարածքային ընտրական հանձնաժողովին հաղորդում է`" },
                    { 34, 34, "Ընտրողների գրանցումն իրականացնող հանձնաժողովի անդամը վերցնում է քվեարկության կտրոնը և կատարում հետևյալ բոլոր գործողությունները՝" },
                    { 6, 6, "Ե՞րբ է հրավիրվում տեղամասային ընտրական հանձնաժողովի առաջին նիստը`" },
                    { 17, 17, "Ո՞րտեղ են փակցվում ընտրություններին մասնակցող կուսակցությունների ընտրական ցուցակները՝" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DbAnswer");

            migrationBuilder.DropTable(
                name: "DbCitizenReport");

            migrationBuilder.DropTable(
                name: "DbCitizenTestResults");

            migrationBuilder.DropTable(
                name: "DbEmptyTextViewModel");

            migrationBuilder.DropTable(
                name: "DbQuestion");

            migrationBuilder.DropTable(
                name: "DbTempQuestions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
