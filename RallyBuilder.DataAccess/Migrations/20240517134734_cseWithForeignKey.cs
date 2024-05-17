using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RallyBuilder.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class cseWithForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseSignEntries_CourseModels_CourseModelId",
                table: "CourseSignEntries");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2b1dc6d9-01e3-4e2f-8e37-bd5f59949f6d", "6253e240-f04d-4dc0-81c8-9726e145221c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e6ce3858-625a-4ff8-8061-d9d22e67e4c0", "96b6c59d-64f3-4513-bd3f-6f4b905a52a6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "774150f1-64f3-41e3-b634-9ed412dd0e22", "a7174963-6b35-4c04-8133-a45abf4914d8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fd2c0fbf-063b-4f11-9a33-60f993ebb223", "e57fc725-7672-4e47-bfbf-58f9cbf8ca69" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b1dc6d9-01e3-4e2f-8e37-bd5f59949f6d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "774150f1-64f3-41e3-b634-9ed412dd0e22");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6ce3858-625a-4ff8-8061-d9d22e67e4c0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd2c0fbf-063b-4f11-9a33-60f993ebb223");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6253e240-f04d-4dc0-81c8-9726e145221c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96b6c59d-64f3-4513-bd3f-6f4b905a52a6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7174963-6b35-4c04-8133-a45abf4914d8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e57fc725-7672-4e47-bfbf-58f9cbf8ca69");

            migrationBuilder.AlterColumn<int>(
                name: "CourseModelId",
                table: "CourseSignEntries",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "04c6d4c6-212c-4e34-bf61-3a8b0c36bb72", null, "Instruktør", "INSTRUKTØR" },
                    { "2eff42ec-0df0-46cd-9f24-bc40d4772529", null, "Hundefører", "HUNDEFØRER" },
                    { "d819933b-4ee1-435c-84a3-90c0ac09ade7", null, "Administrator", "ADMINISTRATOR" },
                    { "f889aa3d-503a-4ff2-bde3-4351007845da", null, "Dommer", "DOMMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Location", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "02a3c053-4dc6-4792-a5a6-c9cc4f866d7b", 0, "f337beb3-9d0a-4269-baa0-d7b2ca2abf17", "ApplicationUser", "instruktør@test.com", false, null, false, null, "Instruktør", "INSTRUKTØR@TEST.COM", "INSTRUKTØR@TEST.COM", "AQAAAAIAAYagAAAAEBLfAxYewXm9jZ2/1wycU0GXN7FIB4H9tiwTGreQwntNpWc691fUuJQjcQda0v/Qqg==", null, false, "5b330981-30d4-483f-921e-dbd3aeda9c39", false, "instruktør@test.com" },
                    { "84e4f980-2ca8-4b62-a792-050e0dc0c60c", 0, "7c19c33a-53f3-4221-8f11-c9feb6473297", "ApplicationUser", "hundefører@test.com", false, null, false, null, "Hundefører", "HUNDEFØRER@TEST.COM", "HUNDEFØRER@TEST.COM", "AQAAAAIAAYagAAAAEMWZSZN82weRnc95z7IuUoUjbTWg2hjv0pPvmoLfMuP7XNVYf91gYPfIKEDqT1tBiA==", null, false, "27a2500c-a9b7-4fe5-a1fb-128c850eb48b", false, "hundefører@test.com" },
                    { "ba9d8ab8-a2db-4d89-bc62-63e98db2a358", 0, "a810d9e5-6cf3-4d25-9a8a-eece5e302111", "ApplicationUser", "administrator@test.com", false, null, false, null, "Admin", "ADMINISTRATOR@TEST.COM", "ADMINISTRATOR@TEST.COM", "AQAAAAIAAYagAAAAEAOjvuHHp6r0ksl9t3/MeY5VCi0prJ5YBdsU9jl2LhQmHWKdtc8lTNCQye1gENqnGA==", null, false, "6f46c078-30a9-4f2a-936d-780560a6ba17", false, "administrator@test.com" },
                    { "f90773b9-8145-4df2-851f-644b60eb5fc7", 0, "2f0f97e3-4822-42ac-b8b3-d9d9b19022b0", "ApplicationUser", "dommer@test.com", false, null, false, null, "Dommer", "DOMMER@TEST.COM", "DOMMER@TEST.COM", "AQAAAAIAAYagAAAAEIL6EAyMNW+x8W9ldgGXbiKvWGqTZW/DlnXwE2je6RWr4/b7I/Hxe/igIa1sESlTfw==", null, false, "a7876432-ecf0-49a5-8d19-135676394496", false, "dommer@test.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "04c6d4c6-212c-4e34-bf61-3a8b0c36bb72", "02a3c053-4dc6-4792-a5a6-c9cc4f866d7b" },
                    { "2eff42ec-0df0-46cd-9f24-bc40d4772529", "84e4f980-2ca8-4b62-a792-050e0dc0c60c" },
                    { "d819933b-4ee1-435c-84a3-90c0ac09ade7", "ba9d8ab8-a2db-4d89-bc62-63e98db2a358" },
                    { "f889aa3d-503a-4ff2-bde3-4351007845da", "f90773b9-8145-4df2-851f-644b60eb5fc7" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CourseSignEntries_CourseModels_CourseModelId",
                table: "CourseSignEntries",
                column: "CourseModelId",
                principalTable: "CourseModels",
                principalColumn: "CourseModelId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseSignEntries_CourseModels_CourseModelId",
                table: "CourseSignEntries");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "04c6d4c6-212c-4e34-bf61-3a8b0c36bb72", "02a3c053-4dc6-4792-a5a6-c9cc4f866d7b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2eff42ec-0df0-46cd-9f24-bc40d4772529", "84e4f980-2ca8-4b62-a792-050e0dc0c60c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d819933b-4ee1-435c-84a3-90c0ac09ade7", "ba9d8ab8-a2db-4d89-bc62-63e98db2a358" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f889aa3d-503a-4ff2-bde3-4351007845da", "f90773b9-8145-4df2-851f-644b60eb5fc7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04c6d4c6-212c-4e34-bf61-3a8b0c36bb72");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2eff42ec-0df0-46cd-9f24-bc40d4772529");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d819933b-4ee1-435c-84a3-90c0ac09ade7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f889aa3d-503a-4ff2-bde3-4351007845da");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02a3c053-4dc6-4792-a5a6-c9cc4f866d7b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84e4f980-2ca8-4b62-a792-050e0dc0c60c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba9d8ab8-a2db-4d89-bc62-63e98db2a358");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f90773b9-8145-4df2-851f-644b60eb5fc7");

            migrationBuilder.AlterColumn<int>(
                name: "CourseModelId",
                table: "CourseSignEntries",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_CourseSignEntries_CourseModels_CourseModelId",
                table: "CourseSignEntries",
                column: "CourseModelId",
                principalTable: "CourseModels",
                principalColumn: "CourseModelId");
        }
    }
}
