using System;
using System.Collections.Generic;
using System.Linq;
using Application.Interfaces.Contexts;
using AutoMapper;
using Domain.Entities.Blogs;
using Domain.Entities.Footer;
using Microsoft.EntityFrameworkCore;
 
using  Domain.Entities.IdealCrm;

namespace Application.Services.FrontEnd.Blogs.Queries
{
    public interface IGetBlogsFrontEndService
    {
        ResultGetBlogsFrontEndDto Execute();
    }

    public class GetBlogsFrontEndService : IGetBlogsFrontEndService
    {
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;
        public GetBlogsFrontEndService(ICustomDbContext customDbContext, IMapper mapper)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
        }



        public ResultGetBlogsFrontEndDto Execute()
        {
            var blogsModel = _customDbContext.Blogs
                .Include(s => s.BlogCategory)
                .Where(g => g.IsVerified)
                .Where(s => s.Position == 0)
                .Where(s => s.RequestToAuthorFav!=true)
                .OrderByDescending(s => s.Id)
                .Take(18);
            var blogs = _mapper.Map<List<GetBlogsDto>>(blogsModel);
            

            
            var blogsFavModel = _customDbContext.Blogs
                .Include(s => s.BlogCategory)
                .Where(s => s.IsVerified)
                .Where(s => s.Position != 0)
                .OrderByDescending(s => s.Id);
            var blogsFav = _mapper.Map<List<GetBlogsDto>>(blogsFavModel);

            
            var blogsAuthorFavModel = _customDbContext.Blogs
                .Include(s => s.BlogCategory)
                .Where(s => s.IsVerified)
                .Where(s => s.Position == 0)
                .Where(s => s.RequestToAuthorFav)
                .OrderByDescending(s => s.Id);
            var blogsAuthorFav = _mapper.Map<List<GetBlogsDto>>(blogsAuthorFavModel);
            
            
            
            var blogsLeftPanelMostVisitedModel = _customDbContext.BlogCategories
                .Include(s=>s.Blog)
                .OrderByDescending(s => s.Blog.Sum(crmCmsNews => crmCmsNews.VisitCount))
                .Take(3);
            var blogsLeftPanelMostVisited = _mapper.Map<List<GetBlogCategoryDto>>(blogsLeftPanelMostVisitedModel);
            

            var blogsGroupModel = _customDbContext.BlogCategories;
            var blogsGroup = _mapper.Map<List<GetBlogCategoryDto>>(blogsGroupModel);

            var footers = _customDbContext.Footers.SingleOrDefault();

            return new ResultGetBlogsFrontEndDto
            {
                Blogs = blogs,
                BlogsFav = blogsFav,
                BlogsAuthorFav = blogsAuthorFav,
                BlogsLeftPanelMostVisited = blogsLeftPanelMostVisited,
                BlogsGroup = blogsGroup,
                Footers = footers,
            };
        }
    }

    public class ResultGetBlogsFrontEndDto
    {
        public List<GetBlogsDto> Blogs { get; set; }
        public List<GetBlogsDto> BlogsFav { get; set; }
        public List<GetBlogsDto> BlogsAuthorFav { get; set; }
        public List<GetBlogCategoryDto> BlogsLeftPanelMostVisited { get; set; }
        public List<GetBlogCategoryDto> BlogsGroup { get; set; }
        public Footer Footers { get; set; }
    }


    public class GetBlogsDto
    {
        public int Id { get; set; }
        public int BlogCategoryId { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string ImageUrl { get; set; }
        public string SmallDescription { get; set; }
        public string Body { get; set; }
        public bool IsVerified { get; set; }
        public string RegisterUserId { get; set; }
        public int Position { get; set; }
        public string LocalTime { get; set; }
        public int VisitCount { get; set; }
        public bool RequestToAuthorFav { get; set; }
        public bool IsVideoClip { get; set; }
        public string VideoClipDuration { get; set; }
        public string Author { get; set; }
        public BlogCategory BlogCategory { get; set; }
    }

    public class GetBlogCategoryDto
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
        public string ImageUrl { get; set; }
        public DateTime InsertTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public List<Blog> Blog { get; set; }
    }
}