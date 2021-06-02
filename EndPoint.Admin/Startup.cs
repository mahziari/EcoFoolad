using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces.Contexts;
using Application.Interfaces.FacadPatterns.BackEnd.Admin;
using Application.Services.BackEnd.Admin.Blogs.FacadPattern;
using Application.Services.BackEnd.Admin.BlogsCategories.FacadPattern;
using Application.Services.BackEnd.Admin.Company.FacadPattern;
using Application.Services.BackEnd.Admin.Menus.FacadPattern;
using Application.Services.BackEnd.Admin.Products.FacadPattern;
using Application.Services.BackEnd.Admin.Roles.FacadPattern;
using Application.Services.BackEnd.Admin.Sliders.FacadPattern;
using Application.Services.BackEnd.Admin.Users.FacadPattern;
using Infrastructure.IdentityConfigs;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace EndPoint.Admin
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
            services.AddControllersWithViews();
            
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
            services.AddAuthentication();
            
            services.Configure<SecurityStampValidatorOptions>(option =>
                option.ValidationInterval = TimeSpan.FromSeconds(10));

            services.ConfigureApplicationCookie(option =>
            {
                // cookie setting
                option.ExpireTimeSpan = TimeSpan.FromMinutes(120);
                option.LoginPath = "/users/auth/checkout";
                option.AccessDeniedPath = "/Error/AccessDenied";
                option.SlidingExpiration = true;
            });
            
            services.AddControllersWithViews();
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

            
            //------ Admin Panel Services
            services.AddScoped<IMenusFacad, MenusFacad>();
            services.AddScoped<IProductsFacad, ProductsFacad>();
            services.AddScoped<IBlogsCategoriesFacad, BlogsCategoriesFacad>();
            services.AddScoped<IBlogsFacad, BlogsFacad>();
            services.AddScoped<IRolesFacad, RolesFacad>();
            services.AddScoped<IUsersFacad, UsersFacad>();
            services.AddScoped<ISlidersFacad, SlidersFacad>();
            services.AddScoped<ICompanyFacad, CompanyFacad>();
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
