using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RallyBuilder.Services;

namespace RallyBuilder.Controllers
{

    public class RalliesController : Controller
    {
        private readonly IRallyService _rallyService;
        public RalliesController(IRallyService rallyService)
        {
            _rallyService = rallyService;
        }

        public async Task<IActionResult> Homepage()
        {
             return View("Homepage");
        }

        public async Task<IActionResult> GetRallies()
        {
            return View(
                "All",
                await _rallyService.GetRallies());
        }


        [Authorize(Roles = "Administrator, Hundefører")]
        public IActionResult GetRalliesByUser()
        {
            return View();
        }

        [Authorize(Roles = "Administrator, Hundefører")]
        public IActionResult CreateRally()
        {
            return View("New");
        }

        public IActionResult CourseBuilder()
        {
            return View();
        }

    }
}
