using System;
using EndPoint.Web.Areas.Auth.Helpers;
using EndPoint.Web.Areas.Auth.Helpers.Policy;
using ParsaPoolad.Persistence.Contexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Application.Services.BackEnd.Admin.Blogs.FacadPattern;
using ParsaPoolad.Application.Services.BackEnd.Admin.Menus.FacadPattern;
using ParsaPoolad.Application.Services.BackEnd.Admin.Products.FacadPattern;
using ParsaPoolad.Application.Services.BackEnd.Admin.Users.FacadPattern;
using ParsaPoolad.Application.Services.FrontEnd.Common.Menus.FacadPattern;
using ParsaPoolad.Application.Interfaces.FacadPatterns.BackEnd.Admin;
using ParsaPoolad.Application.Interfaces.FacadPatterns.FrontEnd;
using ParsaPoolad.Application.Services.BackEnd.Admin.BlogsCategories.FacadPattern;
using ParsaPoolad.Application.Services.BackEnd.Admin.Company.FacadPattern;
using ParsaPoolad.Application.Services.BackEnd.Admin.Roles.FacadPattern;
using ParsaPoolad.Application.Services.BackEnd.Admin.Sliders.FacadPattern;
using ParsaPoolad.Application.Services.FrontEnd.Blogs.FacadPattern;
using ParsaPoolad.Application.Services.FrontEnd.Home.FacadPattern;
using ParsaPoolad.Application.Services.FrontEnd.Products.FacadPattern;
using ParsaPoolad.Domain.Entities.Identity;

namespace EndPoint.Web
{
    public class StartupStaging
    {
        public StartupStaging(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //------ DB Context Services
            services.AddEntityFrameworkSqlServer()
                .AddDbContext<DataBaseContext>(options => options
                    .UseSqlServer(Configuration.GetConnectionString("connectionString")));
            services.AddScoped<IDataBaseContext, DataBaseContext>();

            services.AddEntityFrameworkSqlServer()
                .AddDbContext<IdentityDataBaseContext>(options => options
                    .UseSqlServer(Configuration.GetConnectionString("connectionStringIdentity")));
            services.AddScoped<IIdentityDataBaseContext, IdentityDataBaseContext>();


            services.AddControllersWithViews();

            //------ Auth Services
            services.AddIdentity<User, Role>()
                .AddEntityFrameworkStores<IdentityDataBaseContext>()
                .AddDefaultTokenProviders()
                .AddRoles<Role>()
                .AddErrorDescriber<CustomIdentityError>()
                .AddPasswordValidator<PasswordValidator>();


            services.AddAuthorization(options =>
            {
                // Roles Policy
                options.AddPolicy("SeniorProgrammer", policy => { policy.RequireRole("SeniorProgrammer"); });
                options.AddPolicy("Admins", policy => { policy.RequireRole("Admin"); });
                options.AddPolicy("Owners", policy => { policy.RequireRole("Owner"); });
                options.AddPolicy("Users", policy => { policy.RequireRole("User"); });
                // Claim Policy
                // options.AddPolicy("ProgrammerAdmin", policy => { policy.RequireClaim("ProgrammerAdmin"); });
                // options.AddPolicy("BooldType", policy => { policy.RequireClaim("Boold", "AB", "Ap"); });
                // کاربرانی که اعتبارشون کمتر از این مقداره بتونن احراز بشن
                // باید یدونه کلیم برای کاربر تعریف کنم و مبلغ اعتبار اون کاربر رو درکلیم کریدیت اضافه کنم
                options.AddPolicy("Cradit", policy => { policy.Requirements.Add(new UserCreditRequerment(10000)); });
            });

            services.Configure<IdentityOptions>(option =>
            {
                //UserSetting
                //option.User.AllowedUserNameCharacters = "abcd123";
                option.User.RequireUniqueEmail = false;
                //Password Setting
                option.Password.RequireDigit = true;
                option.Password.RequireLowercase = true;
                option.Password.RequireNonAlphanumeric = false; //!@#$%^&*()_+
                option.Password.RequireUppercase = true;
                option.Password.RequiredLength = 8;
                option.Password.RequiredUniqueChars = 1;
                //Lokout Setting
                option.Lockout.MaxFailedAccessAttempts = 4;
                option.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                //SignIn Setting
                option.SignIn.RequireConfirmedAccount = false;
                option.SignIn.RequireConfirmedEmail = false;
                option.SignIn.RequireConfirmedPhoneNumber = true;
            });

            services.ConfigureApplicationCookie(option =>
            {
                // cookie setting
                option.ExpireTimeSpan = TimeSpan.FromMinutes(120);
                option.LoginPath = "/users/auth/checkout";
                option.AccessDeniedPath = "/users/auth/AccessDenied";
                option.SlidingExpiration = true;
            });
            //------ User Interface Services
            services.AddScoped<IMenusFrontEndFacad, MenusFrontEndFacad>();
            services.AddScoped<IHomeFrontEndFacad, HomeFrontEndFacad>();
            services.AddScoped<IBlogsFrontEndFacad, BlogsFrontEndFacad>();
            services.AddScoped<IProductsFrontEndFacad, ProductsFrontEndFacad>();
            //------ Admin Panel Services
            services.AddScoped<IMenusFacad, MenusFacad>();
            services.AddScoped<IProductsFacad, ProductsFacad>();
            services.AddScoped<IBlogsCategoriesFacad, BlogsCategoriesFacad>();
            services.AddScoped<IBlogsFacad, BlogsFacad>();
            services.AddScoped<IRolesFacad, RolesFacad>();
            services.AddScoped<IUsersFacad, UsersFacad>();
            services.AddScoped<ISlidersFacad, SlidersFacad>();
            services.AddScoped<ICompanyFacad, CompanyFacad>();
            services.AddControllersWithViews();
            //------ Sessions Services
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(10);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
            //services.AddScoped<IUserClaimsPrincipalFactory<User>, AddMyClaims>();
            // services.AddScoped<IClaimsTransformation, AddClaim>();
            // services.AddSingleton<IAuthorizationHandler, UserCreditRequerment>();
            services.AddMvc();
            services.AddRouting(options => options.LowercaseUrls = true);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
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
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}