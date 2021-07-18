using System;
using System.Net.Http;
using Application.Interfaces.Contexts;
using AutoMapper;
using Common.Utilities;
using Domain.Entities.Blogs;
using  Domain.Entities.IdealCrm;
using Microsoft.AspNetCore.Http;

namespace  Application.Services.BackEnd.Admin.BlogsCategories.Command.CreateBlogsCategories
{
    public class CreateBlogsCategoriesServices : ICreateBlogsCategoriesServices
    {
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;

        public CreateBlogsCategoriesServices(ICustomDbContext customDbContext, IMapper mapper, IHttpContextAccessor httpContext)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
            _httpContext = httpContext;
        }


        public ResultCreateBlogsCategoriesDto Execute(CreateBlogsCategoriesServicesDto createBlogsCategoriesServicesDto)
        {
            var blogCategories = _mapper.Map<BlogCategory>(createBlogsCategoriesServicesDto);
            
            blogCategories.LocalTime = DateTime.Now.ToString("s") + "+" + TimeZoneInfo.Local.BaseUtcOffset.ToHHMM();
            blogCategories.RegisterUserId = ClaimUtility.GetUserId(_httpContext.HttpContext?.User);
            blogCategories.IsActive = true;
            
            _customDbContext.BlogCategories.Add(blogCategories);
            _customDbContext.SaveChanges();

            return new ResultCreateBlogsCategoriesDto
            {
                IsSuccess = true,
                Message = "دسته بندی بلاگ با موفقیت اضافه شد"
            };

        }
    }
}