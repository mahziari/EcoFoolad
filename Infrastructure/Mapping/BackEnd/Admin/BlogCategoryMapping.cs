using Application.Services.BackEnd.Admin.BlogsCategories.Command.CreateBlogsCategories;
using Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetCreateBlogsCategories;
using Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetEditBlogsCategories;
using Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetIndexBlogsCategories;
using Application.Services.FrontEnd.Blogs.Queries;
using AutoMapper;
using Domain.Entities.Blogs;

namespace Infrastructure.Mapping.BackEnd.Admin
{
    public class BlogCategoryMappingProfile:Profile
    {
        public BlogCategoryMappingProfile()
        {
            CreateMap<BlogCategory, GetIndexBlogsCategoriesDto>();
            CreateMap<BlogCategory, GetEditBlogsCategoriesDto>().ReverseMap();
            CreateMap<BlogCategory, CreateBlogsCategoriesServicesDto>().ReverseMap();
            CreateMap<CreateBlogsCategoriesServicesDto, BlogCategory>().ReverseMap();


        }
    }
}