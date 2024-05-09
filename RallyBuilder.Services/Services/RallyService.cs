using Microsoft.EntityFrameworkCore;
using RallyBuilder.DataAccess;
using RallyBuilder.Models;

namespace RallyBuilder.Services
{
    public class RallyService : IRallyService
    {
        private readonly IDbContextFactory<ApplicationDatabaseContext> _dbFactory;
        public RallyService(IDbContextFactory<ApplicationDatabaseContext> dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<List<Rally>> GetRallies()
        {
            ApplicationDatabaseContext context = _dbFactory.CreateDbContext();
            List<Rally> rallies = await context.Rallies.ToListAsync();

            return rallies;
        }
    }
}
