using System;
using Domain.Entities.Users;
using Infrastructure.Configuration.IdentityConfigs.Helpers;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;

namespace Infrastructure.Configuration.IdentityConfigs
{
    public static class IdentityConfig
    {
        public static IServiceCollection AddIdentityService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<IdentityDatabaseContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("SqlServer")));
            
            //------ Auth Services
            services.AddIdentity<User, Role>()
                .AddEntityFrameworkStores<IdentityDatabaseContext>()
                .AddDefaultTokenProviders()
                .AddRoles<Role>()
                .AddErrorDescriber<CustomIdentityError>()
                .AddPasswordValidator<PasswordValidator>();

            services.Configure<IdentityOptions>(option =>
            {
                //UserSetting
                //option.User.AllowedUserNameCharacters = "abcd123";
                option.User.RequireUniqueEmail = false;
                //Password Setting
                option.Password.RequireDigit = true;
                option.Password.RequireLowercase = false;
                option.Password.RequireNonAlphanumeric = false; //!@#$%^&*()_+
                option.Password.RequireUppercase = false;
                option.Password.RequiredLength = 8;
                option.Password.RequiredUniqueChars = 1;
                //Lockout Setting
                option.Lockout.MaxFailedAccessAttempts = 6;
                option.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1);
                //SignIn Setting
                option.SignIn.RequireConfirmedAccount = false;
                option.SignIn.RequireConfirmedEmail = false;
                option.SignIn.RequireConfirmedPhoneNumber = true;
            });

            return services;
        }
    }
}
