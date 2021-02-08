using Microsoft.Extensions.Caching.Distributed;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Application.Interfaces.FacadPatterns.FrontEnd;
using ParsaPoolad.Application.Services.FrontEnd.Home.Queries;

namespace ParsaPoolad.Application.Services.FrontEnd.Home.FacadPattern
{
    public class HomeFrontEndFacad: IHomeFrontEndFacad
    {
        private readonly IDistributedCache cache;
        private readonly IDataBaseContext _context;
        private readonly IIdentityDataBaseContext _parsapooladContext;

        public HomeFrontEndFacad(IDataBaseContext context,
            IIdentityDataBaseContext parsapooladContext, IDistributedCache cache)
        {
            _context = context;
            _parsapooladContext = parsapooladContext;
            this.cache = cache;
        }
        
        private IGetHomeFrontEndService _getHomeFrontEndService;
        public IGetHomeFrontEndService GetHomeFrontEndService
        {
            get
            {
                return _getHomeFrontEndService ??= new GetHomeFrontEndService(_context,_parsapooladContext,cache);
            }
        }
    }
}