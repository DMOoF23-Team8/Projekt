using Microsoft.EntityFrameworkCore;
using RallyBuilder.DataAccess;
using RallyBuilder.Models;

namespace RallyBuilder.Services;

public class RallyService : IRallyService
{
    private readonly IDbContextFactory<ApplicationDatabaseContext> _dbFactory;
    private readonly ApplicationDatabaseContext _databaseContext;

    public RallyService(IDbContextFactory<ApplicationDatabaseContext> dbFactory)
    {
        _dbFactory = dbFactory;
        _databaseContext = _dbFactory.CreateDbContext();
    }

    public async Task<List<CourseModel>> GetCourseModels()
    {
        List<CourseModel> courseModels = await _databaseContext.CourseModels.ToListAsync();

        return courseModels;
    }

    public async Task<List<CourseSignEntry>> GetCourseSignEntries()
    {
        List<CourseSignEntry> courseSignEntries = await _databaseContext.CourseSignEntries.ToListAsync();

        return courseSignEntries;
    }
}
