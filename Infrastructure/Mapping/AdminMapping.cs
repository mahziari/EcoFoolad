using Application.Services.BackEnd.Admin.Factory.Command.CreateFactory;
using Application.Services.BackEnd.Admin.Footers;
using Application.Services.FrontEnd.Blogs.Queries;
using AutoMapper;
using Domain.Entities.Factory;
using Domain.Entities.Footer;
using Domain.Entities.IdealCrm;

namespace Infrastructure.Mapping
{
    public class AdminMappingFactory:Profile
    {
        public AdminMappingFactory()
        {
            CreateMap<Factory, FactoryDto>().ReverseMap();
            CreateMap<Footer, FooterDto>().ReverseMap();
            CreateMap<CrmCmsNewsGroups, CategoryItemDto>().ReverseMap();
        }
        
    }
}