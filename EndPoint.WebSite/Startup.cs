using System;
using Application.Interfaces.Contexts;
using Application.Interfaces.FacadPatterns.BackEnd.Admin;
using Application.Interfaces.FacadPatterns.BackEnd.Owner;
using Application.Interfaces.FacadPatterns.FrontEnd;
using Application.Services.BackEnd.Admin.Blogs.FacadPattern;
using Application.Services.BackEnd.Admin.BlogsCategories.FacadPattern;
using Application.Services.BackEnd.Admin.Company.FacadPattern;
using Application.Services.BackEnd.Admin.Menus.FacadPattern;
using Application.Services.BackEnd.Admin.Products.FacadPattern;
using Application.Services.BackEnd.Admin.Roles.FacadPattern;
using Application.Services.BackEnd.Admin.Sliders.FacadPattern;
using Application.Services.BackEnd.Admin.Users.FacadPattern;
using Application.Services.BackEnd.Owner.Home.FacadPattern;
using Application.Services.BackEnd.Owner.Products.FacadPattern;
using Application.Services.BackEnd.Owner.Profile.FacadPattern;
using Application.Services.FrontEnd.Blogs.FacadPattern;
using Application.Services.FrontEnd.Carts;
using Application.Services.FrontEnd.Common.Menus.FacadPattern;
using Application.Services.FrontEnd.Fainances.FacadPattern;
using Application.Services.FrontEnd.Home.FacadPattern;
using Application.Services.FrontEnd.Products.FacadPattern;
using EndPoint.Web.Areas.Auth.Helpers.Policy;
using EndPoint.WebSite.Utilities;
using Infrastructure.IdentityConfigs;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Persistence.Contexts;

namespace EndPoint.WebSite
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //------ DB Context Services
            services.AddScoped<IIdealCrmDataBaseContext, IdealCrmDataBaseContext>();
            services.AddEntityFrameworkSqlServer()
                .AddDbContext<IdealCrmDataBaseContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("IdealCrmConnectionString")));

            services.AddScoped<ICustomDbContext, CustomDbContext>();
            services.AddEntityFrameworkSqlServer()
                .AddDbContext<CustomDbContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("SqlServer")));

            services.AddIdentityService(Configuration);

            //------ Redis Services
            services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = Configuration.GetConnectionString("Redis");
                options.InstanceName = "RedisDb";
            });
            
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
            
            //------ Interface Services
            services.AddScoped<IMenusFrontEndFacad, MenusFrontEndFacad>();
            services.AddScoped<IHomeFrontEndFacad, HomeFrontEndFacad>();
            services.AddScoped<IBlogsFrontEndFacad, BlogsFrontEndFacad>();
            services.AddScoped<IProductsFrontEndFacad, ProductsFrontEndFacad>();
            services.AddScoped<ICartFrontEndService, CartFrontEndService>();
            services.AddScoped<CookiesManeger, CookiesManeger>();
            services.AddScoped<IFinancesFrontEndFacad, FinancesFrontEndFacad>();
            //------ Admin Panel Services
            services.AddScoped<IMenusFacad, MenusFacad>();
            services.AddScoped<IProductsFacad, ProductsFacad>();
            services.AddScoped<IBlogsCategoriesFacad, BlogsCategoriesFacad>();
            services.AddScoped<IBlogsFacad, BlogsFacad>();
            services.AddScoped<IRolesFacad, RolesFacad>();
            services.AddScoped<IUsersFacad, UsersFacad>();
            services.AddScoped<ISlidersFacad, SlidersFacad>();
            services.AddScoped<ICompanyFacad, CompanyFacad>();
            //------ Owner Panel Services
            services.AddScoped<IOwnerProductsFacad, OwnerProductsFacad>();
            services.AddScoped<IOwnerHomeFacad, OwnerHomeFacad>();
            services.AddScoped<IOwnerProfileFacad, OwnerProfileFacad>();
            
            //------ Sessions Services
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(10);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
            // services.AddScoped<IUserClaimsPrincipalFactory<User>, AddMyClaims>();
            // services.AddScoped<IClaimsTransformation, AddClaim>();
            // services.AddSingleton<IAuthorizationHandler, UserCreditRequerment>();
            services.AddMvc();
            services.AddRouting(options => options.LowercaseUrls = true);
            services.AddResponseCompression();

            // load Project Ui WithOut Rebuilding When Change in Ui
            var mvcBuilder = services.AddControllersWithViews();
            #if DEBUG
            mvcBuilder.AddRazorRuntimeCompilation();
            #endif
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseStatusCodePagesWithReExecute("/Error/{0}");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseSession();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}").RequireAuthorization();
            });
        }
    }
}