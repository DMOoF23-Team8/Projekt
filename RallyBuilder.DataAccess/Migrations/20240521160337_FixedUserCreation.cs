using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RallyBuilder.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FixedUserCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "73e2dc24-d9b0-43e3-923a-673e06f56218", "0b3da8c6-91dc-4e5a-a07e-f5c549f8f3c5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8cc8938b-ce7b-4092-83bc-88649bbaaec3", "21a297dd-a832-4895-866a-5726f2699094" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9fb7ad05-271f-445f-bbf9-43a7855b8086", "3c0ef874-90ee-4a2c-880f-a7bc6a3414f4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4297dc45-9415-4a96-81ae-ca476e1ab04e", "8f8be20c-d345-4561-8cc6-e55df62478aa" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4297dc45-9415-4a96-81ae-ca476e1ab04e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73e2dc24-d9b0-43e3-923a-673e06f56218");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cc8938b-ce7b-4092-83bc-88649bbaaec3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fb7ad05-271f-445f-bbf9-43a7855b8086");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b3da8c6-91dc-4e5a-a07e-f5c549f8f3c5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21a297dd-a832-4895-866a-5726f2699094");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c0ef874-90ee-4a2c-880f-a7bc6a3414f4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f8be20c-d345-4561-8cc6-e55df62478aa");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Name",
                table: "AspNetUsers",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4297dc45-9415-4a96-81ae-ca476e1ab04e", null, "Administrator", "ADMINISTRATOR" },
                    { "73e2dc24-d9b0-43e3-923a-673e06f56218", null, "Dommer", "DOMMER" },
                    { "8cc8938b-ce7b-4092-83bc-88649bbaaec3", null, "Hundefører", "HUNDEFØRER" },
                    { "9fb7ad05-271f-445f-bbf9-43a7855b8086", null, "Instruktør", "INSTRUKTØR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Location", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0b3da8c6-91dc-4e5a-a07e-f5c549f8f3c5", 0, "66233997-7174-4cfe-8e45-4f34d9cdc137", "ApplicationUser", "dommer@test.com", false, null, false, null, "Dommer", "DOMMER@TEST.COM", "DOMMER@TEST.COM", "AQAAAAIAAYagAAAAEF8v4ZpGHm004rCmPl8jadr5B4RimE84gb9VjcZXxOqeEEYv/LBPbeucy7M1fQWgTQ==", null, false, "d7424981-b4a1-4079-8ced-9d840b3c4214", false, "dommer@test.com" },
                    { "21a297dd-a832-4895-866a-5726f2699094", 0, "022a39dd-02da-400c-b245-bb983b1b4996", "ApplicationUser", "hundefører@test.com", false, null, false, null, "Hundefører", "HUNDEFØRER@TEST.COM", "HUNDEFØRER@TEST.COM", "AQAAAAIAAYagAAAAEGlUkdklEIHjzvizaeMrTqnXIkj6sAXjVBXdZnUDdc/7NOvvn0EzmGwTcuG4Kk2tsw==", null, false, "59b9dbce-96cb-4348-8bd6-c0a6133af5e4", false, "hundefører@test.com" },
                    { "3c0ef874-90ee-4a2c-880f-a7bc6a3414f4", 0, "5b061724-088c-457b-963e-ebeb08a2bdce", "ApplicationUser", "instruktør@test.com", false, null, false, null, "Instruktør", "INSTRUKTØR@TEST.COM", "INSTRUKTØR@TEST.COM", "AQAAAAIAAYagAAAAEEwj2zSRQ28IusV7Fmp8/hQIjqSYOWC64JFZVjtgtJPA9HJPX7TLsR3Bies3cZ5djA==", null, false, "e0705719-c913-4975-8ca2-31106d07a09c", false, "instruktør@test.com" },
                    { "8f8be20c-d345-4561-8cc6-e55df62478aa", 0, "cce7fb20-9bf1-4904-ac8b-dde9f462518c", "ApplicationUser", "administrator@test.com", false, null, false, null, "Admin", "ADMINISTRATOR@TEST.COM", "ADMINISTRATOR@TEST.COM", "AQAAAAIAAYagAAAAEEHAtwDDGn2lOb9Eqya1aexvkY2Ci9prcY7RBuAV44+D7lFdlfQTMMWBHFDkyRKRYw==", null, false, "5710ce12-7b4a-4feb-8e63-6ec9ba6d6b13", false, "administrator@test.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "73e2dc24-d9b0-43e3-923a-673e06f56218", "0b3da8c6-91dc-4e5a-a07e-f5c549f8f3c5" },
                    { "8cc8938b-ce7b-4092-83bc-88649bbaaec3", "21a297dd-a832-4895-866a-5726f2699094" },
                    { "9fb7ad05-271f-445f-bbf9-43a7855b8086", "3c0ef874-90ee-4a2c-880f-a7bc6a3414f4" },
                    { "4297dc45-9415-4a96-81ae-ca476e1ab04e", "8f8be20c-d345-4561-8cc6-e55df62478aa" }
                });
        }
    }
}
