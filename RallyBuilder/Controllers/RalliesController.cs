using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RallyBuilder.Models;
using RallyBuilder.ViewModels;

namespace RallyBuilder.Controllers;

public class RalliesController : Controller
{
    private readonly RallyServiceVM _vm;

    public RalliesController(RallyServiceVM viewModel)
    {
        _vm = viewModel;
    }

    [HttpGet]
    public IActionResult All()
    {
        return View(_vm);
    }


    [Authorize(Roles = "Administrator, Hundefører")]
    public IActionResult CreateRally()
    {
        return View("New");
    }

    [HttpGet]
    public IActionResult CourseBuilder()
    {
        return View();
    }

    [HttpGet]
    public IActionResult CourseBuilder(CourseModel courseModel)
    {
        return View();
    }
}
