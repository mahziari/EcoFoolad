using Application.Services.BackEnd.Admin.AboutUs;
using Application.Services.BackEnd.Admin.Blogs;
using Application.Services.BackEnd.Admin.Blogs.Queries.GetCreateBlogs;
using Application.Services.BackEnd.Admin.Blogs.Queries.GetEditBlogs;
using Application.Services.BackEnd.Admin.BlogsCategories;
using Application.Services.BackEnd.Admin.BlogsCategories.Command.CreateBlogsCategories;
using Application.Services.BackEnd.Admin.BlogsCategories.Command.EditBlogsCategories;
using Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetEditBlogsCategories;
using Application.Services.BackEnd.Admin.Factory.Command.CreateFactory;
using Application.Services.BackEnd.Admin.Footers;
using Application.Services.BackEnd.User.Addresses;
using Application.Services.BackEnd.User.Orders;
using Application.Services.FrontEnd.Blogs.Queries;
using AutoMapper;
using Domain.Entities.AboutUs;
using Domain.Entities.Blogs;
using Domain.Entities.Factory;
using Domain.Entities.Footer;
using Domain.Entities.IdealCrm;
using Domain.Entities.Orders;
using Domain.Entities.Users;

namespace Infrastructure.Mapping.BackEnd.Admin
{
    public class AdminMappingProfile:Profile
    {
        public AdminMappingProfile()
        {
            // Admin
            CreateMap<Factory, FactoryDto>().ReverseMap();
            CreateMap<Footer, FooterDto>().ReverseMap();
            CreateMap<Blog, BlogDto>().ReverseMap();
            CreateMap<Blog, GetEditBlogsDto>();
            CreateMap<BlogCategory, BlogCategoryDto>().ReverseMap();
            CreateMap<BlogCategory, CreateBlogCategoryDto>().ReverseMap();
            CreateMap<BlogCategory, EditBlogCategoryDto>().ReverseMap();
            CreateMap<AboutUs, AboutUsDto>().ReverseMap();

            
            // Owner
            
            
            // User
            CreateMap<UserAddress, UserAddressDto>().ReverseMap();
            CreateMap<UserAddress, Address>();
            CreateMap<Order, UserOrdersDto>().ReverseMap();
        }
        
    }
}