using RallyBuilder.DataAccess;
using Microsoft.EntityFrameworkCore;
using RallyBuilder.Services;
using RallyBuilder.Services.Services;

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

                        //TIL MIGRATIONS I ANDEN FOLDER
                        assembly => assembly.MigrationsAssembly("RallyBuilder.DataAccess"))
                    );

                builder.Services.AddScoped<IRallyService, RallyService>();
            }

            WebApplication app = builder.Build();
            {
                if (!app.Environment.IsDevelopment())
                {
                    app.UseExceptionHandler("/Home/Error");
                    app.UseHsts();
                }

                app.UseHttpsRedirection();
                app.UseStaticFiles();
                app.UseRouting();
                app.UseAuthorization();
                app.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Home}");
                app.Run();
            }
        }
    }
}
