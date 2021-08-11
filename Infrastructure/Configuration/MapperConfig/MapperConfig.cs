using Infrastructure.Mapping;
using Infrastructure.Mapping.BackEnd.Admin;
using Infrastructure.Mapping.FrontEnd;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Configuration.MapperConfig
{
    public static class MapperConfig
    {
        public static IServiceCollection AddMapperService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(typeof(AdminMappingProfile));
            services.AddAutoMapper(typeof(FrontEndMappingProfile));

            return services;
        }
    }
}