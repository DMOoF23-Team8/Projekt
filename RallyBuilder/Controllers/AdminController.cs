using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RallyBuilder.ViewModels;

namespace RallyBuilder.Controllers;

[Authorize(Roles = "Administrator")]
public class AdminController : Controller
{
    public AdminServiceVM ViewModel { get; set; }
    public AdminController(AdminServiceVM viewModel)
    {
        ViewModel = viewModel;
    }

    [HttpGet]
    public IActionResult Users()
    {
        return View(ViewModel);
    }


    [HttpPost]
    public async Task<IActionResult> DeleteApplicationUser(string userID)
    {
        await ViewModel._adminService.DeleteApplicationuser(userID);
        await ViewModel.RefresherAsync();

        return View("Users", ViewModel);
    }
}
