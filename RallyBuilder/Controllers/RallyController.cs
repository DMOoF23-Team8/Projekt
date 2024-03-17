using Microsoft.AspNetCore.Mvc;
using RallyBuilder.Data;
using RallyBuilder.Models;

namespace RallyBuilder.Controllers
{
    public class RallyController : Controller
    {

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Rally rally)
        {
            if (ModelState.IsValid)
            {
                _db.Rallies.Add(rally);
                _db.SaveChanges();
                return RedirectToAction("Home", "Home");
            }
            return View();
        }

        private readonly DatabaseContext _db;
        public RallyController(DatabaseContext db)
        {
            _db = db;
        }
    }
}
