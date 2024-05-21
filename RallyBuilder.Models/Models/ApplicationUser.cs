using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
namespace RallyBuilder.Models;

public class ApplicationUser : IdentityUser
{
    //Relevant data for custom users
    public string? Location { get; set; }
}
