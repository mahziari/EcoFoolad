using Application.Services.FrontEnd.Products.Queries;
using Application.Services.FrontEnd.Products.Queries.GetProductsCategory;
using Application.Services.FrontEnd.Products.Queries.GetProductsCategory.Dto;
using AutoMapper;
using Domain.Entities.Factory;
using Domain.Entities.IdealCrm;

namespace Infrastructure.Mapping.FrontEnd
{
    public class FrontEndMappingFactory:Profile
    {
        public FrontEndMappingFactory()
        {
            CreateMap<Factory, FactoriesDto>().ReverseMap();
            CreateMap<CrmCompany, CompanyDto>().ReverseMap();
        }
    }
}