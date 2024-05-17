using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RallyBuilder.ViewModels;

namespace RallyBuilder.Controllers;

[Authorize(Roles = "Administrator")]
public class AdminController : Controller
{
    private readonly AdminServiceVM _vm;
    public AdminController(AdminServiceVM viewModel)
    {
        _vm = viewModel;
    }

    [HttpGet]
    public IActionResult Users()
    {
        return View(_vm);
    }


    [HttpPost]
    public async Task<IActionResult> DeleteApplicationUser(string userID)
    {
        await _vm._adminService.DeleteApplicationuser(userID);
        await _vm.RefresherAsync();

        return View("Users", _vm);
    }
}
