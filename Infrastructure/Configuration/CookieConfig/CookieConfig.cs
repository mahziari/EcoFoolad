using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Configuration.CookieConfig
{
    public static class CookieConfig
    {
        public static IServiceCollection AddCookieService(this IServiceCollection services, IConfiguration configuration)
        {

            //------ Sessions Services
            // To Migrate Table Search "https://www.nuget.org/packages/dotnet-sql-cache"
            //And Migrate "dotnet sql-cache create "Data Source=.;Initial Catalog=EcoFoolad;Integrated Security=True;" dbo Cache"
            services.AddDistributedSqlServerCache(options =>
            {
                options.ConnectionString = configuration.GetConnectionString("SqlServer");
                  options.SchemaName = "dbo";
                  options.TableName = "Cache";
            });
            
            // services.AddStackExchangeRedisCache(options =>
            // {
            //     options.Configuration = configuration.GetConnectionString("Redis");
            //     options.InstanceName = "RedisDb";
            // });
            
            
            
            services.ConfigureApplicationCookie(options =>
            {
                // cookie setting
                options.ExpireTimeSpan = TimeSpan.FromMinutes(120);
                options.LoginPath = "/users/auth/checkout";
                options.AccessDeniedPath = "/Error/AccessDenied";
                options.SlidingExpiration = true;
            });
            services.Configure<SecurityStampValidatorOptions>(option =>
                option.ValidationInterval = TimeSpan.FromSeconds(10));
            
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(10);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
            
            
            return services;
        }
    }
}