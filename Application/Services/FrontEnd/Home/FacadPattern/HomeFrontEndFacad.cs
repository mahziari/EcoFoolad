using Application.Interfaces.Contexts;
using Microsoft.Extensions.Caching.Distributed;
 
using  Application.Interfaces.FacadPatterns.FrontEnd;
using  Application.Services.FrontEnd.Home.Queries;

namespace  Application.Services.FrontEnd.Home.FacadPattern
{
    public class HomeFrontEndFacad: IHomeFrontEndFacad
    {
        private readonly IDistributedCache _cache;
        private readonly IIdealCrmDataBaseContext _idealCrmContext;
        private readonly ICustomDbContext _context;

  
        
        private IGetHomeFrontEndService _getHomeFrontEndService;

        public HomeFrontEndFacad(IDistributedCache cache, IIdealCrmDataBaseContext idealCrmContext, ICustomDbContext context)
        {
            _cache = cache;
            _idealCrmContext = idealCrmContext;
            _context = context;
        }

        public IGetHomeFrontEndService GetHomeFrontEndService
        {
            get
            {
                return _getHomeFrontEndService ??= new GetHomeFrontEndService(_cache,_idealCrmContext,_context);
            }
        }
    }
}