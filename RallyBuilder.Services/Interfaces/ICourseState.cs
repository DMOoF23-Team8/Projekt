using RallyBuilder.Models;

namespace RallyBuilder.Services;
public interface ICourseState {
    SignModel Payload {get; set;}
    CourseModel CourseModel {get; set;}
    bool CourseModelIsValid();
}

