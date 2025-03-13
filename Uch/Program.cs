using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static Uch.Database;
using static Uch.Logger;

namespace Uch;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        var logFilePath = "log.txt";
        var connectionString = "Data Source=database.db";

        var services = new ServiceCollection();
        services.AddLogging(builder =>
        {
            builder.AddProvider(new FileLoggerProvider(logFilePath));

        });
        services.AddDbContext<AppDbContext>(builder =>
        {
            builder.UseSqlite(connectionString);
        }, ServiceLifetime.Singleton);

        var provider = services.BuildServiceProvider();
        var logger = provider.GetRequiredService<ILogger<Application>>();

        using (var scope = provider.CreateScope())
        {
            var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

            db.Database.EnsureCreated();

            logger.LogInformation("Database created");
        }

        logger.LogInformation("Start application");

        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm(provider));
    }
}