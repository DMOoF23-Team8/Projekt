﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RallyBuilder.DataAccess;

#nullable disable

namespace RallyBuilder.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDatabaseContext))]
    partial class ApplicationDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "56890e2b-5b33-48d5-9ff6-a64607a25089",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "3aa08b6c-36ac-4726-bf19-bcae77962c35",
                            Name = "Dommer",
                            NormalizedName = "DOMMER"
                        },
                        new
                        {
                            Id = "9e6a024e-3002-4ed6-94d7-b5988fec3bfb",
                            Name = "Instruktør",
                            NormalizedName = "INSTRUKTØR"
                        },
                        new
                        {
                            Id = "0bf1a9c0-544e-4b04-a3e0-fc2a9c2c9eaf",
                            Name = "Hundefører",
                            NormalizedName = "HUNDEFØRER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "03f7b721-95ac-4c20-a2d0-ed099f4e7997",
                            RoleId = "56890e2b-5b33-48d5-9ff6-a64607a25089"
                        },
                        new
                        {
                            UserId = "723e62ec-b654-4934-825f-49827aa47525",
                            RoleId = "3aa08b6c-36ac-4726-bf19-bcae77962c35"
                        },
                        new
                        {
                            UserId = "70bf3f06-9243-43af-afbe-3a3af69b0184",
                            RoleId = "9e6a024e-3002-4ed6-94d7-b5988fec3bfb"
                        },
                        new
                        {
                            UserId = "881e6eef-7615-4edd-860a-6b2cd8855561",
                            RoleId = "0bf1a9c0-544e-4b04-a3e0-fc2a9c2c9eaf"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("RallyBuilder.Models.CourseModel", b =>
                {
                    b.Property<int>("CourseModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseModelId"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.HasKey("CourseModelId");

                    b.ToTable("CourseModels");
                });

            modelBuilder.Entity("RallyBuilder.Models.CourseSignEntry", b =>
                {
                    b.Property<int>("CourseSignEntryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseSignEntryId"));

                    b.Property<int?>("CourseModelId")
                        .HasColumnType("int");

                    b.Property<int>("SignModelId")
                        .HasColumnType("int");

                    b.Property<int?>("SignNumberOnCourse")
                        .HasColumnType("int");

                    b.Property<int>("SquareNumber")
                        .HasColumnType("int");

                    b.HasKey("CourseSignEntryId");

                    b.HasIndex("CourseModelId");

                    b.HasIndex("SignModelId");

                    b.ToTable("CourseSignEntries");
                });

            modelBuilder.Entity("RallyBuilder.Models.SignModel", b =>
                {
                    b.Property<int>("SignModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SignModelId"));

                    b.Property<string>("IconPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("SignModelId");

                    b.ToTable("SignModels");
                });

            modelBuilder.Entity("RallyBuilder.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ApplicationUser");

                    b.HasData(
                        new
                        {
                            Id = "03f7b721-95ac-4c20-a2d0-ed099f4e7997",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d8b8d276-5748-4088-a046-357e321429ec",
                            Email = "administrator@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMINISTRATOR@TEST.COM",
                            NormalizedUserName = "ADMINISTRATOR@TEST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEGsiUuSWMeRJx4zXsFgIJfS82z7wQtDgdYLboohkQEZHL5d5xp23AVAxHAv6itVf6Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "cfb1bcd1-177c-4710-af1a-370345b809df",
                            TwoFactorEnabled = false,
                            UserName = "administrator@test.com",
                            Name = "Admin"
                        },
                        new
                        {
                            Id = "723e62ec-b654-4934-825f-49827aa47525",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4ab80a7b-f5b9-41bb-9dad-4034892c78a8",
                            Email = "dommer@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "DOMMER@TEST.COM",
                            NormalizedUserName = "DOMMER@TEST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEOvDs3x2FIUFgNE6SdYdo262B263FIns4E7ydVt4UvCQ/8cvSJexr2KNoA9cN/KvCQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "19a2fa0c-a879-4d99-b1a3-dbb0c61e0027",
                            TwoFactorEnabled = false,
                            UserName = "dommer@test.com",
                            Name = "Dommer"
                        },
                        new
                        {
                            Id = "70bf3f06-9243-43af-afbe-3a3af69b0184",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "03383a40-f4db-4699-8269-14a6868b8fcc",
                            Email = "instruktør@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "INSTRUKTØR@TEST.COM",
                            NormalizedUserName = "INSTRUKTØR@TEST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEPBMlS1FhyA5aeuLgO4QO71RqbQF91xPFutkxtq7iXk8Le/iyezVKZCl0ZaXbdkt2w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "56baf073-b425-4957-9a04-fca395915340",
                            TwoFactorEnabled = false,
                            UserName = "instruktør@test.com",
                            Name = "Instruktør"
                        },
                        new
                        {
                            Id = "881e6eef-7615-4edd-860a-6b2cd8855561",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "18fc8397-caf5-4821-a246-af73cc268954",
                            Email = "hundefører@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "HUNDEFØRER@TEST.COM",
                            NormalizedUserName = "HUNDEFØRER@TEST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEFkOQs2PWF5Ur6V7MSnURAf9my/exBeCHZvj0FVnPAbVe/eMA3e7obUE3DMJl1k9Vg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e7605ef5-4a70-480d-b7bd-d2a50ef3ed31",
                            TwoFactorEnabled = false,
                            UserName = "hundefører@test.com",
                            Name = "Hundefører"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RallyBuilder.Models.CourseSignEntry", b =>
                {
                    b.HasOne("RallyBuilder.Models.CourseModel", null)
                        .WithMany("CourseSignEntries")
                        .HasForeignKey("CourseModelId");

                    b.HasOne("RallyBuilder.Models.SignModel", "SignModel")
                        .WithMany()
                        .HasForeignKey("SignModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SignModel");
                });

            modelBuilder.Entity("RallyBuilder.Models.CourseModel", b =>
                {
                    b.Navigation("CourseSignEntries");
                });
#pragma warning restore 612, 618
        }
    }
}
