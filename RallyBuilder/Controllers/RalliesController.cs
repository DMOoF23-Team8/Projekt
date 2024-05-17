using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RallyBuilder.Services;
using RallyBuilder.DataAccess;
using RallyBuilder.Models;
using Microsoft.EntityFrameworkCore;

namespace RallyBuilder.Controllers
{

    public class RalliesController : Controller
    {
        private readonly IRallyService _rallyService;
        private readonly ApplicationDatabaseContext _dbContext;
        public RalliesController(IRallyService rallyService, ApplicationDatabaseContext dbContext)
        {
            _rallyService = rallyService;
            _dbContext = dbContext;
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
            CourseModel? courseModel = _dbContext.CourseModels
                .Include(cm => cm.CourseSignEntries)
                .ThenInclude(cse => cse.SignModel)
                .FirstOrDefault(cm => cm.CourseModelId == 10);

            return View(courseModel);
        }

    }
}
