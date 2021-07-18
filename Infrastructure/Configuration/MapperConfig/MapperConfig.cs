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
            // BackeEnd
            services.AddAutoMapper(typeof(AdminMappingProfile));
            services.AddAutoMapper(typeof(BlogCategoryMappingProfile));
            services.AddAutoMapper(typeof(BlogMappingProfile));
            
            
            // FrontEnd
            services.AddAutoMapper(typeof(UserMappingProfile));
            services.AddAutoMapper(typeof(FrontEndMappingProfile));

            return services;
        }
    }
}