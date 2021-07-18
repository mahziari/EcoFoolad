using Application.Services.BackEnd.Admin.Factory.Command.CreateFactory;
using Application.Services.BackEnd.Admin.Footers;
using Application.Services.FrontEnd.Blogs.Queries;
using AutoMapper;
using Domain.Entities.Factory;
using Domain.Entities.Footer;
using Domain.Entities.IdealCrm;

namespace Infrastructure.Mapping.BackEnd.Admin
{
    public class AdminMappingProfile:Profile
    {
        public AdminMappingProfile()
        {
            CreateMap<Factory, FactoryDto>().ReverseMap();
            CreateMap<Footer, FooterDto>().ReverseMap();
        }
        
    }
}