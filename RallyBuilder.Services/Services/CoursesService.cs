using RallyBuilder.DataAccess;
using RallyBuilder.Models;
using Microsoft.EntityFrameworkCore;

namespace RallyBuilder.Services;
public class CoursesService : ICoursesService
{
    public ApplicationDatabaseContext DbContext { get; set; }

    public CoursesService(ApplicationDatabaseContext dbContext)
    {
        DbContext = dbContext;
    }
    
    public CourseModel? GetCourseModelById(object Id)
    {
        if (!(Id is int))
        {
            return null;
        }

        int CourseModelIdToLoad = (int)Id;

        CourseModel? courseModel = DbContext.CourseModels
        .Include(cm => cm.CourseSignEntries)
        .ThenInclude(cse => cse.SignModel)
        .FirstOrDefault(cm => cm.CourseModelId == CourseModelIdToLoad);

        return courseModel;
    }
}