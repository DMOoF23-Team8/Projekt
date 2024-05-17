using System.ComponentModel;

namespace RallyBuilder.Models;
public class CourseModel {
    public int CourseModelId {get; set;}
    public string Author {get; set;} = "Dr Jones";
    public Level Level {get; set;} = Level.Begynder;
    public List<CourseSignEntry> CourseSignEntries {get; set;} = new List<CourseSignEntry>();
}