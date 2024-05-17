using Microsoft.AspNetCore.Identity;
using RallyBuilder.Models;

namespace RallyBuilder.Services;

public interface IRallyService
{
    //Asynchronously gets a list of course models
    Task<List<CourseModel>> GetCourseModels();

    //Asynchronously gets a list of course signs
    Task<List<CourseSignEntry>> GetCourseSignEntries();

}
