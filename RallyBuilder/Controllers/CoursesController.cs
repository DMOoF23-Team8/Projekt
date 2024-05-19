using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RallyBuilder.Components;
using RallyBuilder.Models;
using RallyBuilder.ViewModels;

namespace RallyBuilder.Controllers;


public class CoursesController : Controller
{
    private readonly RallyServiceVM vm;

    public CoursesController(RallyServiceVM viewModel)
    {
        vm = viewModel;
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
        switch (id)
        {
            case null:
            case 0:
                return RedirectToAction("GetNewCourse");

            case not null:
                return View("coursebuilder", id);
        }
    }
}
