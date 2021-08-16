using Infrastructure.Configuration.IdentityConfigs.Helpers.Policy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Configuration.AuthorizationConfig
{
    public static class AuthorizationConfig
    {
        public static IServiceCollection AddAuthorizationService(this IServiceCollection services, IConfiguration configuration)
        {
           
          services.AddAuthorization(options =>
            {
                
                // Roles Policy
                options.AddPolicy("SeniorProgrammer", policy => { policy.RequireRole("SeniorProgrammer"); });
                options.AddPolicy("AdminRole", policy => { policy.RequireRole("Admin"); });
                options.AddPolicy("OwnerRole", policy => { policy.RequireRole("Owner"); });
                options.AddPolicy("UserRole", policy => { policy.RequireRole("User"); });

                // Claim Policy
                options.AddPolicy("Home", policy => { policy.RequireClaim("Home"); });
                options.AddPolicy("BlogCategories", policy => { policy.RequireClaim("BlogCategories"); });
                options.AddPolicy("BlogCategoriesIndex", policy => { policy.RequireClaim("BlogCategoriesIndex"); });
                options.AddPolicy("BlogCategoriesCreate", policy => { policy.RequireClaim("BlogCategoriesCreate"); });
                options.AddPolicy("BlogCategoriesEdit", policy => { policy.RequireClaim("BlogCategoriesEdit"); });
                options.AddPolicy("BlogCategoriesDelete", policy => { policy.RequireClaim("BlogCategoriesDelete"); });
                options.AddPolicy("Blogs", policy => { policy.RequireClaim("Blogs"); });
                options.AddPolicy("BlogsIndex", policy => { policy.RequireClaim("BlogsIndex"); });
                options.AddPolicy("BlogsCreate", policy => { policy.RequireClaim("BlogsCreate"); });
                options.AddPolicy("BlogsEdit", policy => { policy.RequireClaim("BlogsEdit"); });
                options.AddPolicy("BlogsDelete", policy => { policy.RequireClaim("BlogsDelete"); });
                options.AddPolicy("BlogsActive", policy => { policy.RequireClaim("BlogsActive"); });
                options.AddPolicy("Company", policy => { policy.RequireClaim("Company"); });
                options.AddPolicy("Menus", policy => { policy.RequireClaim("Menus"); });
                options.AddPolicy("Products", policy => { policy.RequireClaim("Products"); });
                options.AddPolicy("ProductsIndex", policy => { policy.RequireClaim("ProductsIndex"); });
                options.AddPolicy("ProductsCreate", policy => { policy.RequireClaim("ProductsCreate"); });
                options.AddPolicy("ProductsEdit", policy => { policy.RequireClaim("ProductsEdit"); });
                options.AddPolicy("ProductsDelete", policy => { policy.RequireClaim("ProductsDelete"); });
                options.AddPolicy("ProductsActive", policy => { policy.RequireClaim("ProductsActive"); });
                options.AddPolicy("Sliders", policy => { policy.RequireClaim("Sliders"); });
                options.AddPolicy("Users", policy => { policy.RequireClaim("Users"); });
                options.AddPolicy("UsersIndex", policy => { policy.RequireClaim("UsersIndex"); });
                options.AddPolicy("UsersEdit", policy => { policy.RequireClaim("UsersEdit"); });
                options.AddPolicy("Factory", policy => { policy.RequireClaim("Factory"); });
                options.AddPolicy("FileManagers", policy => { policy.RequireClaim("FileManagers"); });
                options.AddPolicy("Footers", policy => { policy.RequireClaim("Footers"); });
                options.AddPolicy("AboutUs", policy => { policy.RequireClaim("AboutUs"); });
                options.AddPolicy("ContactUs", policy => { policy.RequireClaim("ContactUs"); });
                options.AddPolicy("Experts", policy => { policy.RequireClaim("Experts"); });
                // ???????? ?? ????????? ???? ?? ??? ?????? ????? ????? ???
                // ???? ????? ???? ???? ????? ????? ??? ? ???? ?????? ??? ????? ?? ?????? ?????? ????? ???
                options.AddPolicy("Cradit", policy => { policy.Requirements.Add(new UserCreditRequerment(10000)); });
            });

               // services.AddAuthentication(options =>
               // {
               //     options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
               //     options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
               //     options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
               // });
               
               
               // services.AddScoped<IUserClaimsPrincipalFactory<User>, AddMyClaims>();
               // services.AddScoped<IClaimsTransformation, AddClaim>();
               // services.AddSingleton<IAuthorizationHandler, UserCreditRequerment>();
            
            return services;
        }
    }
}