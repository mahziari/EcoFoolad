using Application.Interfaces.Contexts;
using Application.Interfaces.FacadPatterns.FrontEnd;
using Application.Services.FrontEnd.Common.Footers.Queries;
using AutoMapper;

namespace Application.Services.FrontEnd.Common.Footers.FacadPattern
{
    public class FootersFrontEndFacad:IFootersFrontEndFacad
    {
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;

        public FootersFrontEndFacad(ICustomDbContext customDbContext, IMapper mapper)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
        }

        private IGetFootersFrontEndService _getFootersFrontEndService;
        public IGetFootersFrontEndService GetFootersFrontEndService
        {
            get
            {
                return _getFootersFrontEndService ??= new GetFootersFrontEndService(_customDbContext,_mapper);
            }
        }
    }
}