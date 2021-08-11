using System.Text.Encodings.Web;
using System.Text.Unicode;
using FluentValidation.AspNetCore;
using GoogleReCaptcha.V3;
using GoogleReCaptcha.V3.Interface;
using Infrastructure.Configuration.AuthorizationConfig;
using Infrastructure.Configuration.ConfigResponseCompression;
using Infrastructure.Configuration.CookieConfig;
using Infrastructure.Configuration.DbContextConfig;
using Infrastructure.Configuration.FacadConfig;
using Infrastructure.Configuration.FluentValidationConfig;
using Infrastructure.Configuration.HtmlMinifyConfig;
using Infrastructure.Configuration.IdentityConfigs;
using Infrastructure.Configuration.MapperConfig;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebMarkupMin.AspNetCore5;

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
            services.AddDbContextService(Configuration);
            services.AddSingleton(Configuration);
            services.AddIdentityService(Configuration);
            services.AddAuthorizationService(Configuration);
            services.AddFacadService(Configuration);
            services.AddCookieService(Configuration);
            services.AddMapperService(Configuration);
            services.AddResponseCompressionServices(Configuration);
            services.AddWebMarkupMinService(Configuration);
            services.AddFluentValidationService(Configuration);
            services.AddHttpClient<ICaptchaValidator, GoogleReCaptchaValidator>();

            services.AddMvc();
            services.AddResponseCompression();
            services.AddRouting(options => options.LowercaseUrls = true);
            services.AddSingleton(HtmlEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Arabic));
            
            // load Project Ui WithOut Rebuilding When Change in Ui
            var mvcBuilder = services.AddControllersWithViews().AddFluentValidation();
            #if DEBUG
            mvcBuilder.AddRazorRuntimeCompilation();
            #endif
     
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
            app.UseResponseCompression();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseSession();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseWebMarkupMin();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}