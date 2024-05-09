using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RallyBuilder.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
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
                name: "Rallies",
                columns: table => new
                {
                    RallyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RallyName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rallies", x => x.RallyId);
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
                    { "2b1dc6d9-01e3-4e2f-8e37-bd5f59949f6d", null, "Administrator", "ADMINISTRATOR" },
                    { "774150f1-64f3-41e3-b634-9ed412dd0e22", null, "Instruktør", "INSTRUKTØR" },
                    { "e6ce3858-625a-4ff8-8061-d9d22e67e4c0", null, "Hundefører", "HUNDEFØRER" },
                    { "fd2c0fbf-063b-4f11-9a33-60f993ebb223", null, "Dommer", "DOMMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Location", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6253e240-f04d-4dc0-81c8-9726e145221c", 0, "318708c9-154e-48a8-9d4b-e3aa3cba9bd6", "ApplicationUser", "administrator@test.com", false, null, false, null, "Admin", "ADMINISTRATOR@TEST.COM", "ADMINISTRATOR@TEST.COM", "AQAAAAIAAYagAAAAEEYB90eVO5WHb2d8b4cRjjb5+pBdNxGb2bIbjyC1gnN8cRuFMd+URsfA/ykmFg25aA==", null, false, "f2471d6f-88ed-4379-a60a-6acabe2e19a1", false, "administrator@test.com" },
                    { "96b6c59d-64f3-4513-bd3f-6f4b905a52a6", 0, "11ca109a-7f3e-4d06-8a51-0bad7a7f6f8b", "ApplicationUser", "hundefører@test.com", false, null, false, null, "Hundefører", "HUNDEFØRER@TEST.COM", "HUNDEFØRER@TEST.COM", "AQAAAAIAAYagAAAAEGfsujG6H+ca1MVglH/pfNZLFg2KzDLXAPN/FpWsbLOwgq8/uwE4Dwd2j4Mb12rKGQ==", null, false, "b6223e3a-4bd7-46c1-b563-62875835afa4", false, "hundefører@test.com" },
                    { "a7174963-6b35-4c04-8133-a45abf4914d8", 0, "778a5e51-85f9-4f67-a219-641bdfeea9ae", "ApplicationUser", "instruktør@test.com", false, null, false, null, "Instruktør", "INSTRUKTØR@TEST.COM", "INSTRUKTØR@TEST.COM", "AQAAAAIAAYagAAAAEJL2QCTEaVzUj3Ku2JLssgE0IJzsEuXtY9qlGSMd6/31InfuBF7PJgGLK0p1pWYskQ==", null, false, "62d3a90f-06df-442b-b00e-3a3ba3e58f5f", false, "instruktør@test.com" },
                    { "e57fc725-7672-4e47-bfbf-58f9cbf8ca69", 0, "8118d86f-8439-4759-8d8b-c256639aa2dd", "ApplicationUser", "dommer@test.com", false, null, false, null, "Dommer", "DOMMER@TEST.COM", "DOMMER@TEST.COM", "AQAAAAIAAYagAAAAEJbt2ScHUzAD/ZNIaNaTSp+xugRn8rIfBSdfsRPqcr1yf7jCKXEO35j5iewn//Rx9A==", null, false, "355c8428-64a5-4dec-8633-1565dd380fec", false, "dommer@test.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2b1dc6d9-01e3-4e2f-8e37-bd5f59949f6d", "6253e240-f04d-4dc0-81c8-9726e145221c" },
                    { "e6ce3858-625a-4ff8-8061-d9d22e67e4c0", "96b6c59d-64f3-4513-bd3f-6f4b905a52a6" },
                    { "774150f1-64f3-41e3-b634-9ed412dd0e22", "a7174963-6b35-4c04-8133-a45abf4914d8" },
                    { "fd2c0fbf-063b-4f11-9a33-60f993ebb223", "e57fc725-7672-4e47-bfbf-58f9cbf8ca69" }
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
                name: "Rallies");

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
