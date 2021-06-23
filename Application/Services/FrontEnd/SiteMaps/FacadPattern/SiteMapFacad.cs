using Application.Interfaces.Contexts;
using Application.Interfaces.FacadPatterns.FrontEnd;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;

namespace Application.Services.FrontEnd.SiteMaps.FacadPattern
{
    public class SiteMapFacad:ISiteMapFacad
    {
        private readonly ICustomDbContext _customDbContext;
        private readonly IIdealCrmDataBaseContext _idealCrmDataBaseContext;
        private readonly IDistributedCache _cache;
        private readonly IHttpContextAccessor _httpContext;
        private readonly IConfiguration _configuration;

        public SiteMapFacad(ICustomDbContext customDbContext, IIdealCrmDataBaseContext idealCrmDataBaseContext,
            IDistributedCache cache, IHttpContextAccessor httpContext, IConfiguration configuration)
        {
            _customDbContext = customDbContext;
            _idealCrmDataBaseContext = idealCrmDataBaseContext;
            _cache = cache;
            _httpContext = httpContext;
            _configuration = configuration;
        }
        
        
        
        private ISiteMapServices _siteMapServices;
        public ISiteMapServices SiteMapServices
        {
            get
            {
                return _siteMapServices ??= new SiteMapServices(_customDbContext,_idealCrmDataBaseContext,_cache,_httpContext,_configuration);
            }
        }
    }
}