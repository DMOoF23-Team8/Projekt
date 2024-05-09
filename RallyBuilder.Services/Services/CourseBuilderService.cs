using RallyBuilder.Models;

namespace RallyBuilder.Services;
public class CourseBuilderService : ICourseBuilderService
{
    public SignModel Payload { get; set; } = new SignModel();
    public CourseModel CourseModel {get; set;} = new CourseModel();

    public CourseBuilderService()
    {
        CourseModel.CourseSignEntries = new List<CourseSignEntry>();
    }
}