
using Application.Services.FrontEnd.AboutUs;
using Application.Services.FrontEnd.Blogs.Queries;
using Application.Services.FrontEnd.Common.Footers.Queries;
using Application.Services.FrontEnd.Products.Queries.GetProductsCategory.Dto;
using AutoMapper;
using Domain.Entities.AboutUs;
using Domain.Entities.Blogs;
using Domain.Entities.Experts;
using Domain.Entities.Factory;
using Domain.Entities.Footer;
using Domain.Entities.IdealCrm;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Mapping.FrontEnd
{
    public class FrontEndMappingProfile:Profile
    {
        public FrontEndMappingProfile()
        {
            CreateMap<Factory, FactoriesDto>().ReverseMap();
            CreateMap<CrmCompany, CompanyDto>().ReverseMap();
            CreateMap<Footer, FooterFrontEndDto>().ReverseMap();
            CreateMap<Footer, SiteSettingFrontEndDto>();
            CreateMap<Blog, GetBlogsDto>();
            // CreateMap<Blog, GetBlogsDto>().ForMember(d => d.CreatedAt, opt => opt.MapFrom(src =>EF.Property<DateTime>(src, "InsertTime")));
            CreateMap<BlogCategory, GetBlogCategoryDto>();
            CreateMap<AboutUs, AboutUsFrontEndDto>();
            CreateMap<Expert, ExpertsDto>();
        }
    }
}