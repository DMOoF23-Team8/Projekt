using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
namespace RallyBuilder.Models;

public class ApplicationUser : IdentityUser
{
    public string? Name { get; set; }

    public string? Location { get; set; }
}
