using RallyBuilder.Models;

namespace RallyBuilder.Services;
public interface ICourseBuilderService {
    SignModel Payload {get; set;}
    CourseModel CourseModel {get; set;}
}
