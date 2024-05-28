using RallyBuilder.DataAccess;
using RallyBuilder.Models;

namespace RallyBuilder.Services;
public interface ICoursesService
{
    CourseModel? GetCourseModelById(object Id);
}