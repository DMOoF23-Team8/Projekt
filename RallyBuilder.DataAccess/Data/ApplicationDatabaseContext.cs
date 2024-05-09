using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RallyBuilder.Models;
using System.Collections.Generic;
using System.Linq;

namespace RallyBuilder.DataAccess
{
    public class ApplicationDatabaseContext : IdentityDbContext<IdentityUser>
    {
        //DbSets pertaining to identity functionality
        public DbSet<Rally> Rallies { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<IdentityRole> IdentityRoles { get; set; }
        public DbSet<IdentityUserRole<string>> IdentityUserRoles { get; set; }

        //DbSets pertaining to the webapplication
        public DbSet<CourseSignEntry> CourseSignEntries { get; set; }
        public DbSet<CourseModel> CourseModels { get; set; }
        public DbSet<SignModel> SignModels { get; set; }

        public ApplicationDatabaseContext(DbContextOptions<ApplicationDatabaseContext> options) : base(options)
        {
        }

        //Seed database with roles and dummy accounts for testing
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            #region seededData

            // Dummy users for testing
            PasswordHasher<ApplicationUser> passwordHasher = new();
            List<ApplicationUser> seededUsers = new()
            {
                new ApplicationUser
                {
                    Name = "Admin",

                    UserName = "administrator@test.com",
                    Email = "administrator@test.com",
                    NormalizedUserName = "administrator@test.com".ToUpper(),
                    NormalizedEmail = "administrator@test.com".ToUpper(),
                    PasswordHash = passwordHasher.HashPassword(null, "Test123."),
                },
                new ApplicationUser
                {
                    Name = "Dommer",

                    UserName = "dommer@test.com",
                    Email = "dommer@test.com",
                    NormalizedUserName = "dommer@test.com".ToUpper(),
                    NormalizedEmail = "dommer@test.com".ToUpper(),
                    PasswordHash = passwordHasher.HashPassword(null, "Test123."),
                },
                new ApplicationUser
                {
                    Name = "Instruktør",

                    UserName = "instruktør@test.com",
                    Email = "instruktør@test.com",
                    NormalizedUserName = "instruktør@test.com".ToUpper(),
                    NormalizedEmail = "instruktør@test.com".ToUpper(),
                    PasswordHash = passwordHasher.HashPassword(null, "Test123."),
                },
                new ApplicationUser
                {
                    Name = "Hundefører",

                    UserName = "hundefører@test.com",
                    Email = "hundefører@test.com",
                    NormalizedUserName = "hundefører@test.com".ToUpper(),
                    NormalizedEmail = "hundefører@test.com".ToUpper(),
                    PasswordHash = passwordHasher.HashPassword(null, "Test123."),
                }
            };

            // Roles
            List<IdentityRole> seededRoles = new()
            {
                new IdentityRole
                {
                    Name = "Administrator",
                    NormalizedName = "Administrator".ToUpper()
                },
                new IdentityRole
                {
                    Name = "Dommer",
                    NormalizedName = "Dommer".ToUpper()
                },
                new IdentityRole
                {
                    Name = "Instruktør",
                    NormalizedName = "Instruktør".ToUpper()
                },
                new IdentityRole
                {
                    Name = "Hundefører",
                    NormalizedName = "Hundefører".ToUpper()
                }
            };

            // Assign roles to users
            List<IdentityUserRole<string>> userRoles = new()
            {
                new IdentityUserRole<string>
                {
                    RoleId = seededRoles.First(r => r.Name == "Administrator").Id,
                    UserId = seededUsers.First(u => u.UserName == "administrator@test.com").Id
                },
                new IdentityUserRole<string>
                {
                    RoleId = seededRoles.First(r => r.Name == "Dommer").Id,
                    UserId = seededUsers.First(u => u.UserName == "dommer@test.com").Id
                },
                new IdentityUserRole<string>
                {
                    RoleId = seededRoles.First(r => r.Name == "Instruktør").Id,
                    UserId = seededUsers.First(u => u.UserName == "instruktør@test.com").Id
                },
                new IdentityUserRole<string>
                {
                    RoleId = seededRoles.First(r => r.Name == "Hundefører").Id,
                    UserId = seededUsers.First(u => u.UserName == "hundefører@test.com").Id
                }
            };

            modelBuilder.Entity<ApplicationUser>().HasData(seededUsers);
            modelBuilder.Entity<IdentityRole>().HasData(seededRoles);
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);

            #endregion
            
        }
    }
}