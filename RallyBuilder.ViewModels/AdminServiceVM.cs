using RallyBuilder.Models;
using RallyBuilder.Services;
using Microsoft.AspNetCore.Identity;
using System.Linq;


namespace RallyBuilder.ViewModels;

public class AdminServiceVM
{
    //Service exposed for functionality
    public IAdminService _adminService;

    public List<ApplicationUser>? ApplicationUsers { get; set; }
    public List<IdentityRole>? IdentityRoles { get; set; }
    public List<IdentityUserRole<string>>? IdentityUserRoles { get; set; }

    public AdminServiceVM(IAdminService adminService)
    {
        _adminService = adminService;

        RefresherAsync().GetAwaiter().GetResult();
    }

    public async Task RefresherAsync()
    {
        ApplicationUsers = await _adminService.GetApplicationUsers();
        IdentityRoles = await _adminService.GetIdentityRoles();
        IdentityUserRoles = await _adminService.GetIdentityUserRoles();
    }
}
