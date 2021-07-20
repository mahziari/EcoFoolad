using Application.Services.BackEnd.Admin.Blogs;
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
          
            // CreateMap<BlogCategory, CategoryItemDto>().ReverseMap();

        }
    }
}