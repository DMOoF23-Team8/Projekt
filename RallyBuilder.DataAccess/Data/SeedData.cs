using RallyBuilder.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;


namespace RallyBuilder.DataAccess;
public static class SeedData
{
    public static void EnsurePopulated(WebApplication app)
    {
        var serviceScope = app.Services.GetRequiredService<IServiceScopeFactory>().CreateScope();
        var context = serviceScope.ServiceProvider.GetRequiredService<ApplicationDatabaseContext>();
        // ApplicationDatabaseContext context = app.Services
        // .CreateScope().ServiceProvider
        // .GetRequiredService<ApplicationDatabaseContext>();

        //Add all signs
        if (!context.SignModels.Any())
        {
            var levels = new List<(Level level, int start, int end)>
        {
            (Level.Begynder, 1, 47),
            (Level.Oevet, 100, 133),
            (Level.Ekspert, 200, 229),
            (Level.Champion, 300, 319)
        };

            foreach (var (level, start, end) in levels)
            {
                for (int i = start; i <= end; i++)
                {
                    context.SignModels.Add(new SignModel
                    {
                        Number = i,
                        Name = $"{i}",
                        Level = level,
                        IconPath = $"images/Skilte/{i}.jpg"
                    });
                }
            }
            context.SaveChanges();
        }
        if(!context.CourseModels.Any())
        {
            context.CourseModels.Add(new CourseModel() {Author = "Medivh", Level = Level.Begynder});
            context.SaveChanges();
        }
    }
}