using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RallyBuilder.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ResetMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourseModels",
                columns: table => new
                {
                    CourseModelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseModels", x => x.CourseModelId);
                });

            migrationBuilder.CreateTable(
                name: "SignModels",
                columns: table => new
                {
                    SignModelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: true),
                    IconPath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignModels", x => x.SignModelId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "CourseSignEntries",
                columns: table => new
                {
                    CourseSignEntryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SignModelId = table.Column<int>(type: "int", nullable: false),
                    SignNumberOnCourse = table.Column<int>(type: "int", nullable: true),
                    SquareNumber = table.Column<int>(type: "int", nullable: false),
                    CourseModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseSignEntries", x => x.CourseSignEntryId);
                    table.ForeignKey(
                        name: "FK_CourseSignEntries_CourseModels_CourseModelId",
                        column: x => x.CourseModelId,
                        principalTable: "CourseModels",
                        principalColumn: "CourseModelId");
                    table.ForeignKey(
                        name: "FK_CourseSignEntries_SignModels_SignModelId",
                        column: x => x.SignModelId,
                        principalTable: "SignModels",
                        principalColumn: "SignModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0bf1a9c0-544e-4b04-a3e0-fc2a9c2c9eaf", null, "Hundefører", "HUNDEFØRER" },
                    { "3aa08b6c-36ac-4726-bf19-bcae77962c35", null, "Dommer", "DOMMER" },
                    { "56890e2b-5b33-48d5-9ff6-a64607a25089", null, "Administrator", "ADMINISTRATOR" },
                    { "9e6a024e-3002-4ed6-94d7-b5988fec3bfb", null, "Instruktør", "INSTRUKTØR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Location", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "03f7b721-95ac-4c20-a2d0-ed099f4e7997", 0, "d8b8d276-5748-4088-a046-357e321429ec", "ApplicationUser", "administrator@test.com", false, null, false, null, "Admin", "ADMINISTRATOR@TEST.COM", "ADMINISTRATOR@TEST.COM", "AQAAAAIAAYagAAAAEGsiUuSWMeRJx4zXsFgIJfS82z7wQtDgdYLboohkQEZHL5d5xp23AVAxHAv6itVf6Q==", null, false, "cfb1bcd1-177c-4710-af1a-370345b809df", false, "administrator@test.com" },
                    { "70bf3f06-9243-43af-afbe-3a3af69b0184", 0, "03383a40-f4db-4699-8269-14a6868b8fcc", "ApplicationUser", "instruktør@test.com", false, null, false, null, "Instruktør", "INSTRUKTØR@TEST.COM", "INSTRUKTØR@TEST.COM", "AQAAAAIAAYagAAAAEPBMlS1FhyA5aeuLgO4QO71RqbQF91xPFutkxtq7iXk8Le/iyezVKZCl0ZaXbdkt2w==", null, false, "56baf073-b425-4957-9a04-fca395915340", false, "instruktør@test.com" },
                    { "723e62ec-b654-4934-825f-49827aa47525", 0, "4ab80a7b-f5b9-41bb-9dad-4034892c78a8", "ApplicationUser", "dommer@test.com", false, null, false, null, "Dommer", "DOMMER@TEST.COM", "DOMMER@TEST.COM", "AQAAAAIAAYagAAAAEOvDs3x2FIUFgNE6SdYdo262B263FIns4E7ydVt4UvCQ/8cvSJexr2KNoA9cN/KvCQ==", null, false, "19a2fa0c-a879-4d99-b1a3-dbb0c61e0027", false, "dommer@test.com" },
                    { "881e6eef-7615-4edd-860a-6b2cd8855561", 0, "18fc8397-caf5-4821-a246-af73cc268954", "ApplicationUser", "hundefører@test.com", false, null, false, null, "Hundefører", "HUNDEFØRER@TEST.COM", "HUNDEFØRER@TEST.COM", "AQAAAAIAAYagAAAAEFkOQs2PWF5Ur6V7MSnURAf9my/exBeCHZvj0FVnPAbVe/eMA3e7obUE3DMJl1k9Vg==", null, false, "e7605ef5-4a70-480d-b7bd-d2a50ef3ed31", false, "hundefører@test.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "56890e2b-5b33-48d5-9ff6-a64607a25089", "03f7b721-95ac-4c20-a2d0-ed099f4e7997" },
                    { "9e6a024e-3002-4ed6-94d7-b5988fec3bfb", "70bf3f06-9243-43af-afbe-3a3af69b0184" },
                    { "3aa08b6c-36ac-4726-bf19-bcae77962c35", "723e62ec-b654-4934-825f-49827aa47525" },
                    { "0bf1a9c0-544e-4b04-a3e0-fc2a9c2c9eaf", "881e6eef-7615-4edd-860a-6b2cd8855561" }
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

            migrationBuilder.CreateIndex(
                name: "IX_CourseSignEntries_CourseModelId",
                table: "CourseSignEntries",
                column: "CourseModelId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSignEntries_SignModelId",
                table: "CourseSignEntries",
                column: "SignModelId");
        }

        /// <inheritdoc />
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
                name: "CourseSignEntries");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CourseModels");

            migrationBuilder.DropTable(
                name: "SignModels");
        }
    }
}
