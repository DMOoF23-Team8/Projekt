using RallyBuilder.DataAccess;
using Microsoft.EntityFrameworkCore;
using RallyBuilder.Services;
using Microsoft.AspNetCore.Identity;
using RallyBuilder.Utilities;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace RallyBuilder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
            {
                builder.Services.AddControllersWithViews();
                builder.Services.AddDbContextFactory<ApplicationDatabaseContext>(
                    options => options.UseSqlServer(
                        builder.Configuration.GetConnectionString("DefaultConnection"),
                        assembly => assembly.MigrationsAssembly("RallyBuilder.DataAccess"))
                    );
                builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDatabaseContext>();
                builder.Services.AddRazorPages();
                builder.Services.AddScoped<IRallyService, RallyService>();
                builder.Services.AddScoped<IEmailSender, EmailSender>();
            }


            WebApplication app = builder.Build();
            {
                switch (app.Environment.IsDevelopment())
                {
                    case true:
                    case false:
                        app.UseHsts();
                        break;
                }

                app.UseHttpsRedirection();
                app.UseStaticFiles();
                app.UseRouting();
                app.UseAuthentication();
                app.UseAuthorization();
                app.MapRazorPages();
                app.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Home}");
                app.Run();
            }
        }
    }
}
