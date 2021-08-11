using System;
using System.Collections.Generic;
using System.Net.Http;
using Application.Interfaces.Contexts;
using Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetEditBlogsCategories;
using AutoMapper;
using Common.Utilities;
using Domain.Entities;
using Domain.Entities.Blogs;
using Domain.Entities.Dtos;
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


        public BaseDto<CreateBlogCategoryDto> Execute(CreateBlogCategoryDto createBlogCategoryDto)
        {
            createBlogCategoryDto.LocalTime = DateTime.Now.ToString("s") + "+" + TimeZoneInfo.Local.BaseUtcOffset.ToHHMM();
            createBlogCategoryDto.RegisterUserId = ClaimUtility.GetUserId(_httpContext.HttpContext?.User);
            createBlogCategoryDto.IsActive = true;
            
            var blogCategories = _mapper.Map<BlogCategory>(createBlogCategoryDto);
            
            _customDbContext.BlogCategories.Add(blogCategories);
            _customDbContext.SaveChanges();

            return new BaseDto<CreateBlogCategoryDto>
            (
                true,
                new List<string> {"دسته بندی مجله با موفقیت اضافه شد"},
                _mapper.Map<CreateBlogCategoryDto>(blogCategories)
            );

        }
    }
}