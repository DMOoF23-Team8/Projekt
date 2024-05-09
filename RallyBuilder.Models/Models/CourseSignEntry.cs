namespace RallyBuilder.Models;
public class CourseSignEntry
{
    public int CourseSignEntryId {get; set;}
    public SignModel SignModel {get; set;}
    public int? SignNumberOnCourse {get; set;}
    public int SquareNumber {get; set;}
}