 
using System;
using System.Collections.Generic;
using Application.Interfaces.Contexts;
using Application.Services.BackEnd.Admin.Blogs.Command.EditBlogs;
using  Application.Services.BackEnd.Admin.BlogsCategories.Command.CreateBlogsCategories;
using Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetEditBlogsCategories;
using AutoMapper;
using Common.Utilities;
using Domain.Entities;
using Domain.Entities.Dtos;
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
        public BaseDto<EditBlogCategoryDto> Execute(EditBlogCategoryDto editBlogCategoryDto)
        {
            editBlogCategoryDto.LocalTime = DateTime.Now.ToString("s") + "+" + TimeZoneInfo.Local.BaseUtcOffset.ToHHMM();
            editBlogCategoryDto.RegisterUserId=ClaimUtility.GetUserId(_httpContext.HttpContext?.User);
            editBlogCategoryDto.IsActive = true;
            
            
            var blogCategoryModel = _customDbContext.BlogCategories.Find(editBlogCategoryDto.Id);
            _mapper.Map(editBlogCategoryDto,blogCategoryModel);
            _customDbContext.SaveChanges();
            
            return new BaseDto<EditBlogCategoryDto>
            (
                true,
                new List<string> {"دسته بندی مجله با موفقیت ویرایش شد"},
                _mapper.Map<EditBlogCategoryDto>(blogCategoryModel)
            );
        }
    }
}