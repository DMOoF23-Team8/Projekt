using RallyBuilder.DataAccess;
using RallyBuilder.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace RallyBuilder.Services;
public class CoursesService : ICoursesService
{
    private readonly ApplicationDatabaseContext _dbContext;

    public CoursesService(ApplicationDatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public CourseModel? GetCourseModelById(object Id)
    {
        if (!(Id is int))
        {
            return null;
        }

        int CourseModelIdToLoad = (int)Id;

        CourseModel? courseModel = _dbContext.CourseModels
        .Include(cm => cm.CourseSignEntries)
            .ThenInclude(cse => cse.SignModel)
        .FirstOrDefault(cm => cm.CourseModelId == CourseModelIdToLoad);

        return courseModel;
    }
}