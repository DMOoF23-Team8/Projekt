using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RallyBuilder.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CourseModelUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "14a05f98-9bf7-4bda-b979-91670c01ea26", "5b0cbe9d-093f-451b-baf6-80b7c1dc4c3a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de601428-ee33-456e-b266-8591132063af", "7d668b26-6482-4f87-bfb9-bcc38004ab8f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "308a5bfc-4f83-4c06-a8e7-0d03d7bd715f", "b72a0a1c-f7ae-468f-a40b-85f4362a0ed3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4d5187c9-0237-4ff6-bff1-25cb2312b122", "d25d06ca-7e08-46f7-bd1d-e2a72604ce88" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14a05f98-9bf7-4bda-b979-91670c01ea26");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "308a5bfc-4f83-4c06-a8e7-0d03d7bd715f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d5187c9-0237-4ff6-bff1-25cb2312b122");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de601428-ee33-456e-b266-8591132063af");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b0cbe9d-093f-451b-baf6-80b7c1dc4c3a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7d668b26-6482-4f87-bfb9-bcc38004ab8f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b72a0a1c-f7ae-468f-a40b-85f4362a0ed3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d25d06ca-7e08-46f7-bd1d-e2a72604ce88");

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "CourseModels",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "02dd646c-f4f9-480a-b125-ffbf44312e3d", null, "Hundefører", "HUNDEFØRER" },
                    { "75bbc373-d29a-4ed6-b322-de46f4312551", null, "Dommer", "DOMMER" },
                    { "ed24eb0e-a8f0-4e3a-93b7-909df4954b82", null, "Administrator", "ADMINISTRATOR" },
                    { "f86b9f3f-929c-4030-bd2f-dce4ce5c8351", null, "Instruktør", "INSTRUKTØR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Location", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3651b661-441e-4afa-b38a-42085002c141", 0, "b00e076e-cf18-4adf-aaee-a05857057f54", "ApplicationUser", "dommer@test.com", false, null, false, null, "DOMMER@TEST.COM", "DOMMER@TEST.COM", "AQAAAAIAAYagAAAAEA21cQcIj/WrKK+biT8g4Ii+KuAJ9XYk5mJ8JytTm0QAjW6tiA5bkmjuzl7pPw6J1g==", null, false, "bf31e48c-863c-48fc-b18b-3729c3941e8e", false, "dommer@test.com" },
                    { "6eb46dfe-6dfb-42bf-afbc-39fa23173a05", 0, "03b5d9ef-fb7a-492e-9250-85acde44d385", "ApplicationUser", "instruktør@test.com", false, null, false, null, "INSTRUKTØR@TEST.COM", "INSTRUKTØR@TEST.COM", "AQAAAAIAAYagAAAAEGe9xJjeV605UIJCP2uVMc8UxXNrUx2aIm6b++Q5u/CuWIBYxNBnroNXeugOKBgI0A==", null, false, "dd1eb87c-522e-442d-bf95-007b98d90010", false, "instruktør@test.com" },
                    { "6f3db85d-7e42-443e-b90a-356452f9b2ea", 0, "8dcd42fd-8f6c-4b93-924a-79c271b2831c", "ApplicationUser", "administrator@test.com", false, null, false, null, "ADMINISTRATOR@TEST.COM", "ADMINISTRATOR@TEST.COM", "AQAAAAIAAYagAAAAEKv8AbHhT/AycQDWE1QDfaAxoi7396Jm0TwfO2g8RlnWJIfrDm7CSVwDjzp3wSZKTQ==", null, false, "ab66ae5b-f2c4-4db8-a10b-1b0761bb856b", false, "administrator@test.com" },
                    { "c46e8c25-1a36-4a9f-b472-7c7733d15f7c", 0, "47890515-47ef-4ac9-bee9-595f6fc9a688", "ApplicationUser", "hundefører@test.com", false, null, false, null, "HUNDEFØRER@TEST.COM", "HUNDEFØRER@TEST.COM", "AQAAAAIAAYagAAAAEEd2bvS4GvPjD7W+SotRtxBf9Kv2DUwlWZJMmUBPwjp/c1YUNu7qQkbPSWQkS3+wuA==", null, false, "9850b553-f6e4-4057-8089-084573f92f17", false, "hundefører@test.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "75bbc373-d29a-4ed6-b322-de46f4312551", "3651b661-441e-4afa-b38a-42085002c141" },
                    { "f86b9f3f-929c-4030-bd2f-dce4ce5c8351", "6eb46dfe-6dfb-42bf-afbc-39fa23173a05" },
                    { "ed24eb0e-a8f0-4e3a-93b7-909df4954b82", "6f3db85d-7e42-443e-b90a-356452f9b2ea" },
                    { "02dd646c-f4f9-480a-b125-ffbf44312e3d", "c46e8c25-1a36-4a9f-b472-7c7733d15f7c" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "75bbc373-d29a-4ed6-b322-de46f4312551", "3651b661-441e-4afa-b38a-42085002c141" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f86b9f3f-929c-4030-bd2f-dce4ce5c8351", "6eb46dfe-6dfb-42bf-afbc-39fa23173a05" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ed24eb0e-a8f0-4e3a-93b7-909df4954b82", "6f3db85d-7e42-443e-b90a-356452f9b2ea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "02dd646c-f4f9-480a-b125-ffbf44312e3d", "c46e8c25-1a36-4a9f-b472-7c7733d15f7c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02dd646c-f4f9-480a-b125-ffbf44312e3d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75bbc373-d29a-4ed6-b322-de46f4312551");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed24eb0e-a8f0-4e3a-93b7-909df4954b82");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f86b9f3f-929c-4030-bd2f-dce4ce5c8351");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3651b661-441e-4afa-b38a-42085002c141");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6eb46dfe-6dfb-42bf-afbc-39fa23173a05");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f3db85d-7e42-443e-b90a-356452f9b2ea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c46e8c25-1a36-4a9f-b472-7c7733d15f7c");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "CourseModels");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "14a05f98-9bf7-4bda-b979-91670c01ea26", null, "Instruktør", "INSTRUKTØR" },
                    { "308a5bfc-4f83-4c06-a8e7-0d03d7bd715f", null, "Dommer", "DOMMER" },
                    { "4d5187c9-0237-4ff6-bff1-25cb2312b122", null, "Hundefører", "HUNDEFØRER" },
                    { "de601428-ee33-456e-b266-8591132063af", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Location", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5b0cbe9d-093f-451b-baf6-80b7c1dc4c3a", 0, "a62b0094-7a87-4ce0-aa80-933532fc7c61", "ApplicationUser", "instruktør@test.com", false, null, false, null, "INSTRUKTØR@TEST.COM", "INSTRUKTØR@TEST.COM", "AQAAAAIAAYagAAAAEAziu8O0JMjVWBMzh9k9XMCxjrSjADUqO/TqT5buVXq/Zsl0t2g3/2bknvI+xBzosQ==", null, false, "597d111e-84a2-42e4-859c-d098ba255944", false, "instruktør@test.com" },
                    { "7d668b26-6482-4f87-bfb9-bcc38004ab8f", 0, "73bf7fc3-8000-4af8-b322-7f8d1c2c0304", "ApplicationUser", "administrator@test.com", false, null, false, null, "ADMINISTRATOR@TEST.COM", "ADMINISTRATOR@TEST.COM", "AQAAAAIAAYagAAAAEOThL9VOAdJOFwXz3n9gVcaaG+m47SyhOKrpe4SM9HtIoFI+oG1UvwtzmxYLFelrwA==", null, false, "15909559-7ffa-4d56-bf1e-6de23bc4df42", false, "administrator@test.com" },
                    { "b72a0a1c-f7ae-468f-a40b-85f4362a0ed3", 0, "cae98b8a-4627-4d99-b9ef-f4e8d661aa86", "ApplicationUser", "dommer@test.com", false, null, false, null, "DOMMER@TEST.COM", "DOMMER@TEST.COM", "AQAAAAIAAYagAAAAEIbCWQt/szLKAMmXF21m1EZ1qg1SB0bvcg9pQb7AVEUUZNCfKUEx5xGcp1yKhAIRCA==", null, false, "b971c27a-2a8b-489a-93fe-c443940a0728", false, "dommer@test.com" },
                    { "d25d06ca-7e08-46f7-bd1d-e2a72604ce88", 0, "d6f68ae4-1c82-4285-9308-8464c4a3b07b", "ApplicationUser", "hundefører@test.com", false, null, false, null, "HUNDEFØRER@TEST.COM", "HUNDEFØRER@TEST.COM", "AQAAAAIAAYagAAAAEFEznDFPVlPocaTZJlcWWmr/FtOoZe50JygKPTBczpmPB00pGl6b0Qajsz1Hzk4p8A==", null, false, "c2c74da4-8540-4d1c-86d4-ddbb5bf46dfb", false, "hundefører@test.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "14a05f98-9bf7-4bda-b979-91670c01ea26", "5b0cbe9d-093f-451b-baf6-80b7c1dc4c3a" },
                    { "de601428-ee33-456e-b266-8591132063af", "7d668b26-6482-4f87-bfb9-bcc38004ab8f" },
                    { "308a5bfc-4f83-4c06-a8e7-0d03d7bd715f", "b72a0a1c-f7ae-468f-a40b-85f4362a0ed3" },
                    { "4d5187c9-0237-4ff6-bff1-25cb2312b122", "d25d06ca-7e08-46f7-bd1d-e2a72604ce88" }
                });
        }
    }
}
