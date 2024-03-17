using Microsoft.EntityFrameworkCore;
using RallyBuilder.Models;
namespace RallyBuilder.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Rally> Rallies { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
    }
}
