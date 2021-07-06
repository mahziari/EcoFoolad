using System;
using EndPoint.Web;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace EndPoint.WebSite
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .ConfigureLogging(options =>
                {
                    options.ClearProviders();

                     // Error Handling
                     options.AddDebug();
                    options.AddFile("wwwroot/Logs/logText.txt");
                     // Store Logs in Windows 10 Event, How to Access This? Please Search Event in windows Search
                     // logger.AddEventLog();
                 });
    }
}