using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace EndPoint.Web
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        
        

        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    // for Environment Area-> This Code request create 3 startup.cs for env
                    // var projectName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
                    // webBuilder.UseStartup(projectName ?? string.Empty);
                    
                    webBuilder.UseStartup<Startup>();
                    
                    
                    // Error Handling
                    if (OperatingSystem.IsMacOS())
                    {
                        webBuilder.ConfigureLogging(logger =>
                        {
                            logger.ClearProviders();
                            logger.AddDebug();
                            logger.AddFile("wwwroot/Logs/logText.txt");
                        });
                    }
                    else if(OperatingSystem.IsWindows())
                    {
                        webBuilder.ConfigureLogging(logger =>
                        {
                            logger.ClearProviders();
                            logger.AddDebug();
                            
                            // Store Logs in Windows 10 Event, How to Access This? Please Search Event in windows Search
                            // logger.AddEventLog();
                            logger.AddFile("wwwroot/Logs/logText.txt");
                        });
                    }
                });
    }
}