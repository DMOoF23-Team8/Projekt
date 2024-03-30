using Microsoft.EntityFrameworkCore;
using RallyBuilder.Models;

namespace RallyBuilder.DataAccess
{
    public class ApplicationDatabaseContext : DbContext
    {
        public ApplicationDatabaseContext(DbContextOptions<ApplicationDatabaseContext> options) : base(options)
        {
        }
        public DbSet<Rally> Rallies { get; set; }
    }
}
