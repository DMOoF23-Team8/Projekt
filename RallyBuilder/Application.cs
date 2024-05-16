using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using RallyBuilder.DataAccess;
using RallyBuilder.Services;
using RallyBuilder.ViewModels;
using static Microsoft.AspNetCore.Builder.WebApplication;

namespace RallyBuilder;

public class Application
{
    public static void Main(string[] args)
    {
        WebApplicationBuilder webApplicationBuilder = CreateBuilder(args);
        {
            //Default services
            webApplicationBuilder.Services.AddControllersWithViews();
            webApplicationBuilder.Services.AddRazorPages();
            webApplicationBuilder.Services.AddServerSideBlazor();

            //Data access
            webApplicationBuilder.Services.AddDbContextFactory<ApplicationDatabaseContext>(
                options => options.UseSqlServer(
                    webApplicationBuilder.Configuration.GetConnectionString("DefaultConnection"),
                    assembly => assembly.MigrationsAssembly("RallyBuilder.DataAccess"))
                );


            //Identity and authorized routing
            webApplicationBuilder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDatabaseContext>().AddDefaultTokenProviders();
            webApplicationBuilder.Services.AddScoped<IEmailSender, EmailSender>();
            webApplicationBuilder.Services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = $"/Identity/Account/Login";
                options.LogoutPath = $"/Identity/Account/Logout";
                options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
            });

            //Custom services
            webApplicationBuilder.Services.AddScoped<AdminServiceVM>();
            webApplicationBuilder.Services.AddScoped<IAdminService, AdminService>();
            webApplicationBuilder.Services.AddScoped<IRallyService, RallyService>();
            webApplicationBuilder.Services.AddScoped<ICourseState, CourseState>();

        }

        WebApplication webApplication = webApplicationBuilder.Build();
        {
            //Pipeline
            switch (webApplication.Environment.IsDevelopment())
            {
                case true:
                case false:
                    webApplication.UseHsts();
                    break;
            }

            //Middleware
            webApplication.UseHttpsRedirection();
            webApplication.UseStaticFiles();
            webApplication.UseRouting();
            webApplication.UseAuthentication();
            webApplication.UseAuthorization();
            webApplication.MapRazorPages();
            webApplication.MapBlazorHub();

            //Default route
            webApplication.MapControllerRoute(
                name: "default",
                pattern: "{controller=Rallies}/{action=Homepage}");

            //Seed Database
            SeedData.EnsurePopulated(webApplication);

            //Run
            webApplication.Run();
        }
        
    }
    
}
