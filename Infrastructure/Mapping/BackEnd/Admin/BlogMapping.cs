using Application.Services.BackEnd.Admin.Blogs.Command.CreateBlogs;
using Application.Services.BackEnd.Admin.Blogs.Command.EditBlogs;
using Application.Services.BackEnd.Admin.Blogs.Queries.GetIndexBlogs;
using Application.Services.FrontEnd.Blogs.Queries;
using AutoMapper;
using Domain.Entities.Blogs;

namespace Infrastructure.Mapping.BackEnd.Admin
{
    public class BlogMappingProfile:Profile
    {
        public BlogMappingProfile()
        {
            CreateMap<CreateBlogsServicesDto, Blog>();
            CreateMap<Blog, GetIndexBlogsDto>();
            CreateMap<Blog, EditBlogsServicesDto>().ReverseMap();
            CreateMap<BlogCategory, CategoryItemDto>().ReverseMap();

        }
    }
}