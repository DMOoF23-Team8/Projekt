﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RallyBuilder.Migrations
{
    /// <inheritdoc />
    public partial class AddedRalliesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rallies");
        }
    }
}
