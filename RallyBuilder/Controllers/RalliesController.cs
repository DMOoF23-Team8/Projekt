using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RallyBuilder.Models;
using RallyBuilder.Services;
using RallyBuilder.Utilities;

namespace RallyBuilder.Controllers
{
    public class RalliesController : Controller
    {
        private readonly IRallyService _rallyService;
        public RalliesController(IRallyService rallyService)
        {
            _rallyService = rallyService;
        }

        [Route ("/Rallies/")]
        [HttpGet]
        public async Task<IActionResult> All()
        {
            return View(await _rallyService.GetRallies());
        }

        [Authorize(Roles = SD.Role_User)]
        [Authorize(Roles = SD.Role_Admin)]
        public IActionResult New()
        {
            return View();
        }

        [Authorize(Roles = SD.Role_User)]
        [Authorize(Roles = SD.Role_Admin)]
        public IActionResult UserRallies()
        {
            return View();
        }
    }
}
