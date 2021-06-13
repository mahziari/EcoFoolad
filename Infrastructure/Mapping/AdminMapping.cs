using Application.Services.BackEnd.Admin.Factory.Command.CreateFactory;
using AutoMapper;
using Domain.Entities.Factory;

namespace Infrastructure.Mapping
{
    public class AdminMappingFactory:Profile
    {
        public AdminMappingFactory()
        {
            CreateMap<Factory, FactoryDto>().ReverseMap();
        }
        
    }
}