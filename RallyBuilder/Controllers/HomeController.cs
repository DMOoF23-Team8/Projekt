using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using RallyBuilder.Services;

namespace RallyBuilder.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRallyService _rallyService;
        public HomeController(IRallyService rallyService)
        {
            _rallyService = rallyService;
        }

        [HttpGet]
        public async Task<IActionResult> Home()
        {
            return View(await _rallyService.GetAllRallies());
        }
    }
}
