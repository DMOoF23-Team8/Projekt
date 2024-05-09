using Microsoft.AspNetCore.Identity;
using RallyBuilder.Models;

namespace RallyBuilder.Services
{
    public interface IAdminService
    {
        //Asynchronously gets a list of application users
        Task<List<ApplicationUser>> GetApplicationUsers();

        //Asynchronously gets a list of roles
        Task<List<IdentityRole>> GetIdentityRoles();

        //Asynchronously gets a list of role claims
        Task<List<IdentityUserRole<string>>> GetIdentityUserRoles();

        //Asynchronously deletes a user
        Task DeleteApplicationuser(string userID);
    }
}
