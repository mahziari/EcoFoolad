using System;
using System.Collections.Generic;
using System.Linq;
using Application.Interfaces.Contexts;
using AutoMapper;
using Common.Extentions;
using Domain.Entities.Blogs;
using Domain.Entities.Footer;
using Domain.Entities.IdealCrm;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using X.PagedList;


namespace  Application.Services.FrontEnd.Blogs.Queries
{
    public interface IGetBlogsCategoryFrontEndService
    {
        ResultGetBlogsCategoryFrontEndDto Execute(string category, int pageNumber);
    }

    public class GetBlogsCategoryFrontEndService: IGetBlogsCategoryFrontEndService
    {
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;

        public GetBlogsCategoryFrontEndService(ICustomDbContext customDbContext, IMapper mapper)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
        }



        public ResultGetBlogsCategoryFrontEndDto Execute(string category, int pageNumber)
        {
            var blogsModel = _customDbContext.Blogs
                .Include(b=>b.BlogCategory)
                .Where(b => b.BlogCategory.Slug == category.Replace('-',' '))
                .Where(g => g.IsVerified)
                .Where(s => s.Position == 0)
                .OrderByDescending(b=>b.Id);
            var mapedBlogs = _mapper.Map<List<GetBlogsDto>>(blogsModel);
            var blogs = mapedBlogs.ToPagedList(pageNumber, 1);
            
          

            
            var categoryItemModel = _customDbContext.BlogCategories
                .FirstOrDefault(b => b.Slug == category.Replace('-',' '));
            var categoryItem = _mapper.Map<GetBlogCategoryDto>(categoryItemModel);



            var footers = _customDbContext.Footers.Single();
            
            return new ResultGetBlogsCategoryFrontEndDto
            {
                Blogs =blogs,
                // PageId =pageId,
                // PageCount =pageCount,
                CategoryItem =categoryItem,
                Footers =footers,
            };
        }
    }

    public class ResultGetBlogsCategoryFrontEndDto
    {
        public IPagedList<GetBlogsDto> Blogs { get; set; }
        public Footer Footers { get; set; }
        public GetBlogCategoryDto CategoryItem { get; set; }
    }
}