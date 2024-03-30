using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RallyBuilder.DataAccess;
using Microsoft.EntityFrameworkCore;
using RallyBuilder.Models;

namespace RallyBuilder.Services.Services
{
    public class RallyService : IRallyService
    {
        private readonly IDbContextFactory<ApplicationDatabaseContext> _dbFactory;

        public RallyService(IDbContextFactory<ApplicationDatabaseContext> dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<List<Rally>> GetAllRallies()
        {
            ApplicationDatabaseContext context = _dbFactory.CreateDbContext();
            List<Rally> rallies = await context.Rallies.ToListAsync();

            return rallies;
        }
    }
}
