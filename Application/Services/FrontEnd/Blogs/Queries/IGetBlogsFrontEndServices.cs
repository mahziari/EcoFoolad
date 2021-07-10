using System;
using System.Collections.Generic;
using System.Linq;
using Application.Interfaces.Contexts;
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
        private readonly IIdealCrmDataBaseContext _context;
        private readonly ICustomDbContext _customDbContext;

        public GetBlogsFrontEndService(IIdealCrmDataBaseContext context, ICustomDbContext customDbContext)
        {
            _context = context;
            _customDbContext = customDbContext;
        }



        public ResultGetBlogsFrontEndDto Execute()
        {
            var blogs = _context.CrmCmsNews
                .Include(s => s.NewsGroup)
                .Where(g => g.IsVerified)
                .Where(s => s.Position == 0)
                .Where(s => s.RequestToAuthorFav!=true)
                .OrderByDescending(s => s.NewsId)
                .Select(s => new GetBlogsDto
                {
                    NewsId = s.NewsId,
                    NewsGroupId = s.NewsGroupId,
                    NewsGroupName = s.NewsGroup.GroupName,
                    en_NewsGroupName = s.NewsGroup.en_GroupName,
                    HeadLine = s.HeadLine,
                    Title = s.Title,
                    NewsSummery = s.NewsSummery,
                    DateTime = s.RegisterDate.ToPersianDateTime().ToString("yyyy/MM/d"),
                    IsVerified = s.IsVerified,
                    Position = s.Position,
                }).Take(16).ToList();

            var blogsFav = _context.CrmCmsNews
                .Include(s => s.NewsGroup)
                .Where(s => s.IsVerified)
                .Where(s => s.Position != 0)
                .OrderByDescending(s => s.NewsId)
                .Select(s => new GetBlogsDto
                {
                    NewsId = s.NewsId,
                    NewsGroupId = s.NewsGroupId,
                    NewsGroupName = s.NewsGroup.GroupName,
                    en_NewsGroupName = s.NewsGroup.en_GroupName,
                    HeadLine = s.HeadLine,
                    Title = s.Title,
                    NewsSummery = s.NewsSummery,
                    DateTime = s.RegisterDate.ToPersianDateTime().ToString("yyyy/MM/d"),
                    IsVerified = s.IsVerified,
                    Position = s.Position,
                }).ToList();


            var blogsAuthorFav = _context.CrmCmsNews
                .Include(s => s.NewsGroup)
                .Where(s => s.IsVerified)
                .Where(s => s.Position == 0)
                .Where(s => s.RequestToAuthorFav)
                .OrderByDescending(s => s.NewsId)
                .Select(s => new GetBlogsDto
                {
                    NewsId = s.NewsId,
                    NewsGroupId = s.NewsGroupId,
                    NewsGroupName = s.NewsGroup.GroupName,
                    en_NewsGroupName = s.NewsGroup.en_GroupName,
                    HeadLine = s.HeadLine,
                    Title = s.Title,
                    NewsSummery = s.NewsSummery,
                    DateTime = s.RegisterDate.ToPersianDateTime().ToString("yyyy/MM/d"),
                    IsVerified = s.IsVerified,
                    Position = s.Position,
                }).ToList();


            var blogsLeftPanelMostVisited = _context.CrmCmsNewsGroups
                .OrderByDescending(s => s.CrmCmsNews.Sum(crmCmsNews => crmCmsNews.VisitCount))
                .Select(s => new GetMostVisitedGroupBlogsDto
                {
                    NewsGroupId = s.NewsGroupId,
                    GroupName = s.GroupName,
                    en_GroupName = s.en_GroupName,
                    MostVisitedBlogs = s.CrmCmsNews
                        .Where(g => g.IsVerified)
                        .Where(s => s.Position == 0)
                        .Where(s => s.RequestToAuthorFav!=true)
                        .OrderByDescending(g => g.VisitCount)
                        .Select(g => new GetBlogsDto
                        {
                            NewsId = g.NewsId,
                            NewsGroupId = g.NewsGroupId,
                            NewsGroupName = s.GroupName,
                            en_NewsGroupName = s.en_GroupName,
                            HeadLine = g.HeadLine,
                            Title = g.Title,
                            NewsSummery = g.NewsSummery,
                            DateTime =s.RegisterDate.ToPersianDateTime().ToString("yyyy/MM/d"),
                            IsVerified = g.IsVerified,
                            Position = g.Position,
                        }).Take(4).ToList(),
                }).Take(3).ToList();

            var blogsGroup = _context.CrmCmsNewsGroups.ToList();

            var footers = _customDbContext.Footers.FirstOrDefault();

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
        public List<GetMostVisitedGroupBlogsDto> BlogsLeftPanelMostVisited { get; set; }
        public List<CrmCmsNewsGroups> BlogsGroup { get; set; }
        public Footer Footers { get; set; }
    }


    public class GetBlogsDto
    {
        public int NewsId { get; set; }
        public int NewsGroupId { get; set; }
        public string Title { get; set; }
        public string NewsGroupName { get; set; }
        public string en_NewsGroupName { get; set; }
        public string NewsSummery { get; set; }
        public string HeadLine { get; set; }
        public string DateTime { get; set; }
        public bool IsVerified { get; set; }
        public int Position { get; set; }
    }

    public class GetMostVisitedGroupBlogsDto
    {
        public int NewsGroupId { get; set; }
        public string GroupName { get; set; }
        public string en_GroupName { get; set; }
        public List<GetBlogsDto> MostVisitedBlogs { get; set; }
    }
}