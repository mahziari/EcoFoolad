using Application.Interfaces.Contexts;
using Application.Interfaces.FacadPatterns.BackEnd.Admin;
using AutoMapper;

namespace Application.Services.BackEnd.Admin.AboutUs.FacadPattern
{
    public class AboutUsFacad:IAboutUsFacad
    {
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;

        public AboutUsFacad(ICustomDbContext customDbContext, IMapper mapper)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
        }
        
        
        private IAboutUsServices _aboutUsServices;
        public IAboutUsServices AboutUsServices
        {
            get
            {
                return _aboutUsServices ??= new AboutUsServices(_customDbContext,_mapper);
            }
        }
    }
}