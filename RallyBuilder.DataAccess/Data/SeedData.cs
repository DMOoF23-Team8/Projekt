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

        //Add all signs
        if (!context.SignModels.Any())
        {
            context.SignModels.Add(new SignModel {Number = 1234, Name = "Start", Level = Level.NA, IconPath = "Images/Misc/start.jpg"});
            context.SignModels.Add(new SignModel {Number = 4321, Name = "Maal", Level = Level.NA, IconPath = "Images/Misc/maal.jpg"});
            
            var levels = new List<(Level level, int start, int end)>
            {
                (Level.Begynder, 3, 47),
                (Level.Oevet, 100, 133),
                (Level.Ekspert, 200, 229),
                (Level.Champion, 300, 319),
                (Level.NA, 1, 27),
            };

            foreach (var (level, start, end) in levels)
            {
                if (level == Level.NA)
                {
                    for (int i = start; i <= end; i++)
                    {
                        context.SignModels.Add(new SignModel
                        {
                            Number = 400 + i,
                            Name = "derp",
                            Level = level,
                            IconPath = $"Images/Misc/{i}.png"
                        });
                    }
                }
                else
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