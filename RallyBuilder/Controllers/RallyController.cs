using Microsoft.AspNetCore.Mvc;
using RallyBuilder.Models;
using RallyBuilder.Services;

namespace RallyBuilder.Controllers
{
    public class RallyController : Controller
    {
        
        public IActionResult Create()
        {
            return View();
        }
        /*
        [HttpPost]
        public IActionResult Create(Rally rally)
        {
            return View();
        }
        */
        private readonly IRallyService _rallyService;
        public RallyController(IRallyService rallyService)
        {
            _rallyService = rallyService;
        }
    }
}
