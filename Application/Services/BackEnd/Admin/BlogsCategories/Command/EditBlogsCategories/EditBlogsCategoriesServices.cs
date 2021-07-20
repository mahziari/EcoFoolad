 
using System;
using System.Collections.Generic;
using Application.Interfaces.Contexts;
using Application.Services.BackEnd.Admin.Blogs.Command.EditBlogs;
using  Application.Services.BackEnd.Admin.BlogsCategories.Command.CreateBlogsCategories;
using Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetEditBlogsCategories;
using AutoMapper;
using Common.Utilities;
using Domain.Entities;
using  Domain.Entities.IdealCrm;
using Microsoft.AspNetCore.Http;

namespace  Application.Services.BackEnd.Admin.BlogsCategories.Command.EditBlogsCategories
{
    public class EditBlogsCategoriesServices:IEditBlogsCategoriesServices 
    {
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;

        public EditBlogsCategoriesServices(ICustomDbContext customDbContext, IMapper mapper, IHttpContextAccessor httpContext)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
            _httpContext = httpContext;
        }
        public BaseDto<BlogCategoryDto> Execute(BlogCategoryDto blogsCategoryDto)
        {
            blogsCategoryDto.LocalTime = DateTime.Now.ToString("s") + "+" + TimeZoneInfo.Local.BaseUtcOffset.ToHHMM();
            blogsCategoryDto.RegisterUserId=ClaimUtility.GetUserId(_httpContext.HttpContext?.User);
            blogsCategoryDto.IsActive = true;
            
            
            var blogCategoryModel = _customDbContext.BlogCategories.Find(blogsCategoryDto.Id);
            _mapper.Map(blogsCategoryDto,blogCategoryModel);
            _customDbContext.SaveChanges();
            
            return new BaseDto<BlogCategoryDto>
            (
                true,
                new List<string> {"دسته بندی بلاگ با موفقیت ویرایش شد"},
                _mapper.Map<BlogCategoryDto>(blogCategoryModel)
            );
        }
    }
}