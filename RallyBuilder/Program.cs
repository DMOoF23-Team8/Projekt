using RallyBuilder.Data;
using Microsoft.EntityFrameworkCore;

namespace RallyBuilder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            // Allows the application to use the MVC pattern
            builder.Services.AddControllersWithViews();

            // Allows the application to persist and get data to and from a database
            builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // Builds the application
            var app = builder.Build();


            // Configure the HTTP request pipeline.
            // The HTTP pipeline consists of stepwise calls to middleware functiosn by the use of an async method
            // And a RequestDelegate
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            // Allows the application to use HTTPS
            app.UseHttpsRedirection();

            // Allows the application to use static resources
            app.UseStaticFiles();

            // Allows the application to use routing (mapping different endpoints for different requests)
            app.UseRouting();

            // Allows the application to handle authorization in the form of a login
            app.UseAuthorization();

            // Routes the different controllers for the application
            // Routes the default path for the startup page
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Home}");

            // Runs the application
            app.Run();
        }
    }
}
