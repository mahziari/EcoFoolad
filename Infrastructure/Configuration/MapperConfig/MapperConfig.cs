using Infrastructure.Mapping;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Configuration.MapperConfig
{
    public static class MapperConfig
    {
        public static IServiceCollection AddMapperService(this IServiceCollection services, IConfiguration configuration)
        {
            // Mapper
            services.AddAutoMapper(typeof(UserMappingProfile));
            
            return services;
        }
    }
}