﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RallyBuilder.Data;

#nullable disable

namespace RallyBuilder.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240305132141_AddedRalliesTable")]
    partial class AddedRalliesTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.1.24081.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RallyBuilder.Models.Rally", b =>
                {
                    b.Property<int>("RallyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RallyId"));

                    b.Property<string>("RallyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RallyId");

                    b.ToTable("Rallies");
                });
#pragma warning restore 612, 618
        }
    }
}
