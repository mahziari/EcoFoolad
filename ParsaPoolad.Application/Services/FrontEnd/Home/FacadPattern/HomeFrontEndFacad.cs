using Microsoft.Extensions.Caching.Distributed;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Application.Interfaces.FacadPatterns.FrontEnd;
using ParsaPoolad.Application.Services.FrontEnd.Home.Queries;

namespace ParsaPoolad.Application.Services.FrontEnd.Home.FacadPattern
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