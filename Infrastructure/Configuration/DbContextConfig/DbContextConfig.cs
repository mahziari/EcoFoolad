using Application.Interfaces.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;

namespace Infrastructure.Configuration.DbContextConfig
{
    public static class DbContextConfig
    {
        public static IServiceCollection AddDbContextService(this IServiceCollection services, IConfiguration configuration)
        {
           
            //------ DB Context Services
            services.AddScoped<IIdealCrmDataBaseContext, IdealCrmDataBaseContext>();
            services.AddDbContext<IdealCrmDataBaseContext>(options => options.UseSqlServer(configuration.GetConnectionString("IdealCrmConnectionString")));

            services.AddScoped<ICustomDbContext, CustomDbContext>();
            services.AddDbContext<CustomDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("SqlServer")));
            
            
            return services;
        }
    }
}
