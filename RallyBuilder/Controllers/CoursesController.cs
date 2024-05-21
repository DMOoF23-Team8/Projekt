using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RallyBuilder.Components;
using RallyBuilder.Models;
using RallyBuilder.ViewModels;
using RallyBuilder.Services;

namespace RallyBuilder.Controllers;


public class CoursesController : Controller
{
    private readonly RallyServiceVM vm;
    private readonly ICoursesService coursesService;

    public CoursesController(RallyServiceVM viewModel, ICoursesService coursesService)
    {
        vm = viewModel;
        this.coursesService = coursesService;
    }

    //Route for viewing all courses
    [HttpGet("courses")]
    public IActionResult GetAllCourses()
    {
        return View("courses", vm);
    }

    //Route for creating a new course (opening the course builder)
    [HttpGet("courses/coursebuilder/")]
    public IActionResult GetNewCourse()
    {
        return View("coursebuilder");
    }

    //Route for viewing courses by course ID
    [HttpGet("courses/coursebuilder/{id?}")]
    public IActionResult GetCourseById(int? id)
    {
        CourseModel? courseModel = coursesService.GetCourseModelById(id);
        if(courseModel == null)
        {
            return RedirectToAction("Error", "Home");
        }
        return View("coursebuilder", courseModel);
        // switch (id)
        // {
        //     case null:
        //     case 0:
        //         return RedirectToAction("GetNewCourse");

        //     case not null:
        //         return View("coursebuilder", id);
        // }
    }
}
