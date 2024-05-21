using RallyBuilder.DataAccess;
using RallyBuilder.Models;

namespace RallyBuilder.Services;
public interface ICoursesService
{
    ApplicationDatabaseContext DbContext {get; set;}
    CourseModel? GetCourseModelById(object Id);
}