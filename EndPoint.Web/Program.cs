using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace EndPoint.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    // for Environment Area
                    var projectName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
                    webBuilder.UseStartup(projectName ?? string.Empty);
                    
                    
                    // Error Handling
                    webBuilder.ConfigureLogging(logger =>
                    {
                        logger.ClearProviders();
                        logger.AddDebug();
                        logger.AddEventLog();
                        logger.AddFile("/Logs/logText.txt");
                    });
                });
    }
}
