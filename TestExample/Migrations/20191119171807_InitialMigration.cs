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
                    Result = table.Column<double>(nullable: false),
                    NumberTicket = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    TestDataTime = table.Column<DateTime>(nullable: false)
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
                    Region = table.Column<string>(nullable: false),
                    Community = table.Column<string>(nullable: false),
                    CEC = table.Column<int>(nullable: false),
                    TEC = table.Column<string>(nullable: false),
                    Participants = table.Column<int>(nullable: false),
                    AllAdditionallyDuringElDay = table.Column<int>(nullable: false),
                    PartAdditionallyDuringElDay = table.Column<int>(nullable: false),
                    AllMobileVoters = table.Column<int>(nullable: false),
                    PartMobileVoters = table.Column<int>(nullable: false),
                    AllSum = table.Column<int>(nullable: false),
                    PartSum = table.Column<int>(nullable: false),
                    VadTickets = table.Column<int>(nullable: false),
                    NumerableTickets = table.Column<int>(nullable: false),
                    AllTickets = table.Column<int>(nullable: false),
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
                table: "DbEmptyTextViewModel",
                columns: new[] { "Id", "AllAdditionallyDuringElDay", "AllMobileVoters", "CEC", "Community", "ForA", "ForAx", "ForAy", "ForB", "ForBm", "ForBn", "ForC", "ForCk", "ForCl", "InvalidTickets", "ListAll", "NumerableTickets", "PartMobileVoters", "Participants", "Region", "TEC", "TecGlueTickets", "TecNumerableTickets", "UnusedGlueTickets", "UnusedNumerableTickets", "VadTickets" },
                values: new object[,]
                {
                    { 1, 3, 7, 55, "Շիրակ", 81, 31, 49, 52, 23, 29, 34, 27, 7, 11, 250, 5, 5, 170, "Շիրակի", "55/1", 300, 263, 122, 258, 173 },
                    { 2, 1, 3, 55, "Շիրակ", 120, 80, 40, 280, 150, 130, 213, 95, 118, 11, 840, 24, 3, 620, "Շիրակի", "55/1", 900, 882, 300, 858, 600 },
                    { 3, 2, 4, 55, "Շիրակ", 60, 20, 40, 210, 170, 40, 160, 90, 70, 6, 510, 8, 4, 430, "Շիրակի", "55/1", 600, 536, 164, 528, 428 },
                    { 4, 3, 5, 55, "Շիրակ", 100, 51, 49, 320, 205, 115, 72, 30, 42, 15, 720, 27, 4, 500, "Շիրակի", "55/1", 800, 756, 293, 729, 480 },
                    { 5, 2, 7, 55, "Շիրակ", 40, 13, 27, 250, 150, 100, 110, 45, 65, 7, 420, 17, 5, 400, "Շիրակի", "55/1", 500, 441, 93, 424, 390 },
                    { 6, 3, 10, 55, "Շիրակ", 300, 170, 130, 290, 60, 230, 236, 136, 100, 15, 960, 41, 8, 830, "Շիրակի", "55/1", 1000, 1008, 159, 967, 800 },
                    { 7, 3, 10, 55, "Շիրակ", 10, 5, 5, 40, 10, 30, 60, 40, 20, 3, 120, 18, 10, 100, "Շիրակի", "55/1", 200, 126, 87, 108, 95 }
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
                name: "DbCitizenReport");

            migrationBuilder.DropTable(
                name: "DbCitizenTestResults");

            migrationBuilder.DropTable(
                name: "DbEmptyTextViewModel");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
