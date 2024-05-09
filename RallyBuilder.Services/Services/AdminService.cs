using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RallyBuilder.DataAccess;
using RallyBuilder.Models;
using System.Collections.Generic;
namespace RallyBuilder.Services;

public class AdminService : IAdminService
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly IDbContextFactory<ApplicationDatabaseContext> _dbFactory;
    private readonly ApplicationDatabaseContext _databaseContext;

    public AdminService(IDbContextFactory<ApplicationDatabaseContext> dbFactory, UserManager<IdentityUser> userManager)
    {
        _userManager = userManager;
        _dbFactory = dbFactory;
        _databaseContext = _dbFactory.CreateDbContext();
    }

    public async Task<List<ApplicationUser>> GetApplicationUsers()
    {
        List<ApplicationUser> applicationUsers = await _databaseContext.ApplicationUsers.ToListAsync();

        return applicationUsers;
    }

    public async Task<List<IdentityRole>> GetIdentityRoles()
    {
        List<IdentityRole> identityRoles = await _databaseContext.IdentityRoles.ToListAsync();

        return identityRoles;
    }

    public async Task<List<IdentityUserRole<string>>> GetIdentityUserRoles()
    {
        List<IdentityUserRole<string>> identityUserRoles = await _databaseContext.IdentityUserRoles.ToListAsync();

        return identityUserRoles;
    }

    public async Task DeleteApplicationuser(string userId)
    {
        IdentityUser user = await _userManager.FindByIdAsync(userId);

        await _userManager.DeleteAsync(user);
    }
}
