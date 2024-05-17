using Microsoft.AspNetCore.Mvc;

namespace RallyBuilder.Controllers;

public class HomeController : Controller
{

    [HttpGet]
    public IActionResult Home()
    {
        return View();
    }
}
