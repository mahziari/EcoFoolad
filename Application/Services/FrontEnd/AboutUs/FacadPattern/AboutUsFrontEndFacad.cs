using Application.Interfaces.Contexts;
using Application.Interfaces.FacadPatterns.FrontEnd;
using AutoMapper;

namespace Application.Services.FrontEnd.AboutUs.FacadPattern
{
    public class AboutUsFrontEndFacad:IAboutUsFrontEndFacad
    {
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;

        public AboutUsFrontEndFacad(ICustomDbContext customDbContext, IMapper mapper)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
        }
        
        
        private IAboutUsFrontEndServices _aboutUsFrontEndServices;
        public IAboutUsFrontEndServices AboutUsFrontEndServices
        {
            get
            {
                return _aboutUsFrontEndServices ??= new AboutUsFrontEndServices(_customDbContext,_mapper);
            }
        }
    }
}