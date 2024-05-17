using Microsoft.AspNetCore.Identity;
using RallyBuilder.Models;
using RallyBuilder.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RallyBuilder.ViewModels;

public class RallyServiceVM
{
    public IRallyService _rallyService;

    public List<CourseModel> CourseModels { get; set; }
    public List<CourseSignEntry> CourseSignEntries { get; set; }

    public RallyServiceVM(IRallyService rallyService)
    {
        _rallyService = rallyService;

        RefresherAsync().GetAwaiter().GetResult();
    }

    public async Task RefresherAsync()
    {
        CourseModels = await _rallyService.GetCourseModels();
        CourseSignEntries = await _rallyService.GetCourseSignEntries();
    }
}
