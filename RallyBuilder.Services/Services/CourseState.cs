using RallyBuilder.Models;

namespace RallyBuilder.Services;
public class CourseState : ICourseState
{
    public SignModel Payload { get; set; } = new SignModel();
    public CourseModel CourseModel {get; set;} = new CourseModel();
    

    public CourseState()
    {
        CourseModel.CourseSignEntries = new List<CourseSignEntry>();
    }

    public bool CourseModelIsValid()
    {
        switch (CourseModel.Level)
        {
            case Level.Begynder : return BegynderCourseModelIsValid(); 
            case Level.Oevet : return OevetCourseModelIsValid(); 
            case Level.Ekspert : return EkspertCourseModelIsValid(); 
            case Level.Champion : return ChampionCourseModelIsValid(); 
            default : return false;
        }
    }
    private bool BegynderCourseModelIsValid()
    {
        int totalSigns = CourseModel.CourseSignEntries.Count(cse => cse.SignModel.Level != Level.NA);
        if(totalSigns > 9 && totalSigns <16)
        {
            return true;
        }
        return false;
    }
    private bool OevetCourseModelIsValid()
    {
        int totalSigns = CourseModel.CourseSignEntries.Count(cse => cse.SignModel.Level != Level.NA);
        int NumberOfOevetSigns = CourseModel.CourseSignEntries.Count(cse => cse.SignModel.Level == Level.Oevet);
        if(totalSigns > 11 && totalSigns < 18 && NumberOfOevetSigns > 4)
        {
            return true;
        }
        return false;
    }
    private bool EkspertCourseModelIsValid()
    {
        int totalSigns = CourseModel.CourseSignEntries.Count(cse => cse.SignModel.Level != Level.NA);
        int NumberOfOevetSigns = CourseModel.CourseSignEntries.Count(cse => cse.SignModel.Level == Level.Oevet);
        int NumberOfEkspertSigns = CourseModel.CourseSignEntries.Count(cse => cse.SignModel.Level == Level.Ekspert);
        if (totalSigns > 15 && totalSigns < 21 && NumberOfOevetSigns > 4 && NumberOfEkspertSigns > 2)
        {
            return true;
        }
        return false;
    }
    private bool ChampionCourseModelIsValid()
    {
        int totalSigns = CourseModel.CourseSignEntries.Count(cse => cse.SignModel.Level != Level.NA);
        int NumberOfOevetSigns = CourseModel.CourseSignEntries.Count(cse => cse.SignModel.Level == Level.Oevet);
        int NumberOfEkspertSigns = CourseModel.CourseSignEntries.Count(cse => cse.SignModel.Level == Level.Ekspert);
        int NumberOfChampionSigns = CourseModel.CourseSignEntries.Count(cse => cse.SignModel.Level == Level.Champion);
        if (totalSigns > 17 && totalSigns < 21 && NumberOfOevetSigns > 4 && NumberOfEkspertSigns > 0 && NumberOfChampionSigns > 4)
        {
            return true;
        }
        return false;
    }
        
}