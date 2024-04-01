using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RallyBuilder.Models;

namespace RallyBuilder.DataAccess
{
    public class ApplicationDatabaseContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDatabaseContext(DbContextOptions<ApplicationDatabaseContext> options) : base(options)
        {
        }

        public DbSet<Rally> Rallies { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

    }
}
