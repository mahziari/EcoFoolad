using Application.Services.FrontEnd.Products.Queries;
using AutoMapper;
using Domain.Entities.Factory;

namespace Infrastructure.Mapping.FrontEnd
{
    public class FrontEndMappingFactory:Profile
    {
        public FrontEndMappingFactory()
        {
            CreateMap<Factory, FactoriesDto>().ReverseMap();
        }
    }
}