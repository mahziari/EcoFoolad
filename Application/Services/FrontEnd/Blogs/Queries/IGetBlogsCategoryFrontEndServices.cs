using System;
using System.Collections.Generic;
using System.Linq;
using Application.Interfaces.Contexts;
using AutoMapper;
using Domain.Entities.Blogs;
using Domain.Entities.Footer;
using Domain.Entities.IdealCrm;
using Microsoft.EntityFrameworkCore;
 

namespace  Application.Services.FrontEnd.Blogs.Queries
{
    public interface IGetBlogsCategoryFrontEndService
    {
        ResultGetBlogsCategoryFrontEndDto Execute(string category, int page);
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



        public ResultGetBlogsCategoryFrontEndDto Execute(string category, int page)
        {

            var resultInEachPage = 16;
            int skip = (page - 1) * resultInEachPage;
            int count = _customDbContext.Blogs
                .Where(b=>b.BlogCategory.Slug == category)
                .Where(g => g.IsVerified)
                .Where(s => s.Position == 0)
                .Where(s => s.RequestToAuthorFav!=true)
                .Count(b => b.Position == 0);
            var pageId = page;
            var pageCount = (int)Math.Ceiling(count / (double)resultInEachPage);


            var catrgoriesBlogsModel = _customDbContext.Blogs
                .Include(b=>b.BlogCategory)
                .Where(b => b.BlogCategory.Slug == category.Replace('-',' '))
                .Where(g => g.IsVerified)
                .Where(s => s.Position == 0)
                .Where(s => s.RequestToAuthorFav!=true)
                .OrderByDescending(b=>b.Id)
               .Skip(skip).Take(resultInEachPage).ToList();
            var catrgoriesBlogs = _mapper.Map<List<Blog>>(catrgoriesBlogsModel);

            var categoryItemModel = _customDbContext.BlogCategories
                .Where(b => b.Slug == category.Replace('-',' '));
            var categoryItem = _mapper.Map<CategoryItemDto>(categoryItemModel);



            var footers = _customDbContext.Footers.FirstOrDefault();
            
            return new ResultGetBlogsCategoryFrontEndDto
            {
                CatrgoriesBlogs =catrgoriesBlogs,
                PageId =pageId,
                PageCount =pageCount,
                CategoryItem =categoryItem,
                Footers =footers,
            };
        }
    }

    public class ResultGetBlogsCategoryFrontEndDto
    {
        public List<Blog> CatrgoriesBlogs { get; set; }
        public Footer Footers { get; set; }
        public CategoryItemDto CategoryItem { get; set; }
        public int PageId { get; set; }
        public int PageCount { get; set; }
    }


    public class GetBlogsCatrgoryDto
    {
        public int Id { get; set; }
        public int NewsGroupId { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string InsertTime { get; set; }
        public bool IsVerified { get; set; }
        public int Position { get; set; }
        public int BlogCategoryId { get; set; }
        public string BlogCategoryName { get; set; }
        public string BlogCategorySlug { get; set; }
        public string Slug { get; set; }
        public string SmallDescription { get; set; }
        public string Body { get; set; }
    }

    public class CategoryItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string SmallDescription { get; set; }
        public bool IsActive { get; set; }
        public string RegisterUserId { get; set; }
        public string Color { get; set; }
        public string FaIcon { get; set; }
        public string LocalTime { get; set; }
        public string Image { get; set; }

    }
}