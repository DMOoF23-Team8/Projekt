using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RallyBuilder.Components;
using RallyBuilder.Models;
using RallyBuilder.ViewModels;
using RallyBuilder.Services;
using System.Security.Claims;

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
    [Authorize]
    [HttpGet("courses/coursebuilder/")]
    public IActionResult GetNewCourse()
    {
        return View("coursebuilder");
    }

    [Authorize]
    [HttpGet("courses/newcourse")]
    public IActionResult NewRally()
    {
        CourseModel courseModel = new();
        courseModel.CreatedByUserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        return View("coursebuilder", courseModel);
    }

    //Route for viewing courses by course ID
    [Authorize]
    [HttpGet("courses/coursebuilder/{id?}")]
    public IActionResult GetCourseById(int? id)
    {
        CourseModel? courseModel = coursesService.GetCourseModelById(id);
        if(courseModel == null)
        {
            return RedirectToAction("Error", "Home");
        }
        return View("coursebuilder", courseModel);
    }
}
