using Application.Interfaces.Contexts;
using Application.Interfaces.FacadPatterns.FrontEnd;
using Application.Services.FrontEnd.Common.Footers.Queries;
using AutoMapper;
using Microsoft.Extensions.Caching.Distributed;

namespace Application.Services.FrontEnd.Common.Footers.FacadPattern
{
    public class FootersFrontEndFacad:IFootersFrontEndFacad
    {
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;
        private readonly IDistributedCache _cache;

        public FootersFrontEndFacad(ICustomDbContext customDbContext, IMapper mapper, IDistributedCache cache)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
            _cache = cache;
        }

        private IGetFootersFrontEndService _getFootersFrontEndService;
        public IGetFootersFrontEndService GetFootersFrontEndService
        {
            get
            {
                return _getFootersFrontEndService ??= new GetFootersFrontEndService(_customDbContext,_mapper,_cache);
            }
        }
    }
}