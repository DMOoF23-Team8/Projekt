using Microsoft.AspNetCore.Mvc;
using RallyBuilder.Data;
using RallyBuilder.Models;
using System.Diagnostics;

namespace RallyBuilder.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Home()
        {
            List<Rally> rallies = _db.Rallies.ToList();
            return View(rallies);
        }

        private readonly DatabaseContext _db;
        public HomeController(DatabaseContext db)
        {
            _db = db;
        }
    }
}
