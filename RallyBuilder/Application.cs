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
                options => options.UseMySql(
                    webApplicationBuilder.Configuration.GetConnectionString("DefaultConnection"),
                    new MySqlServerVersion(new Version(10, 11, 6)),
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
            webApplicationBuilder.Services.AddScoped<RallyServiceVM>();
            webApplicationBuilder.Services.AddScoped<IAdminService, AdminService>();
            webApplicationBuilder.Services.AddScoped<IRallyService, RallyService>();
            webApplicationBuilder.Services.AddScoped<ICourseState, CourseState>();
            webApplicationBuilder.Services.AddScoped<ICoursesService, CoursesService>();

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
                pattern: "{controller=Home}/{action=Home}");

            //Seed Database
            SeedData.EnsurePopulated(webApplication);

            //Run
            webApplication.Run();
        }
        
    }
    
}
