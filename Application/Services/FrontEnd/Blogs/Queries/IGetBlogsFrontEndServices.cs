using System;
using System.Collections.Generic;
using System.Linq;
using Application.Interfaces.Contexts;
using Domain.Entities.Footer;
using Microsoft.EntityFrameworkCore;
 
using  Domain.Entities.IdealCrm;

namespace  Application.Services.FrontEnd.Blogs.Queries
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
                .Include(s=>s.NewsGroup)
                .Where(s=>s.IsVerified)
                .Where(s => s.Position == 0)
                .OrderByDescending(s=>s.NewsId)
                .Select(s=> new GetBlogsDto
                {
                    NewsId =s.NewsId,
                    NewsGroupId = s.NewsGroupId,
                    NewsGroupName = _context.CrmCmsNewsGroups
                        .Where(g=>g.NewsGroupId==s.NewsGroupId)
                        .Select(g=>g.GroupName)
                        .FirstOrDefault(),
                    en_NewsGroupName = _context.CrmCmsNewsGroups
                        .Where(g=>g.NewsGroupId==s.NewsGroupId)
                        .Select(g=>g.en_GroupName)
                        .FirstOrDefault(),
                    HeadLine=s.HeadLine,
                    Title = s.Title,
                    NewsSummery = s.NewsSummery,
                    DateTime = s.RegisterDate.ToPersianDateTime().ToString("yyyy/MM/d hh:mm"),
                    IsVerified = s.IsVerified,
                    Position=s.Position,
                }).Take(16)
                .ToList();

            var blogsFav = _context.CrmCmsNews
                .Include(s=>s.NewsGroup)
                .Where(s=>s.IsVerified)
                .Where(s => s.Position != 0)
                .OrderByDescending(s=>s.NewsId)
                .Select(s=> new GetBlogsDto
                {
                    NewsId =s.NewsId,
                    NewsGroupId = s.NewsGroupId,
                    NewsGroupName = _context.CrmCmsNewsGroups
                        .Where(g=>g.NewsGroupId==s.NewsGroupId)
                        .Select(g=>g.GroupName)
                        .FirstOrDefault(),
                    en_NewsGroupName = _context.CrmCmsNewsGroups
                        .Where(g=>g.NewsGroupId==s.NewsGroupId)
                        .Select(g=>g.en_GroupName)
                        .FirstOrDefault(),
                    HeadLine=s.HeadLine,
                    Title = s.Title,
                    NewsSummery = s.NewsSummery,
                    DateTime = s.RegisterDate.ToPersianDateTime().ToString("yyyy/MM/d hh:mm"),
                    IsVerified = s.IsVerified,
                    Position=s.Position,
                }).ToList();

            var blogsGroup = _context.CrmCmsNewsGroups.ToList();

            var footers = _customDbContext.Footers.FirstOrDefault();

            return new ResultGetBlogsFrontEndDto
            {
                Blogs = blogs,
                BlogsFav = blogsFav,
                BlogsGroup = blogsGroup,
                Footers = footers,
            };
        }
    }

    public class ResultGetBlogsFrontEndDto
    {
        public List<GetBlogsDto> Blogs { get; set; }
        public List<GetBlogsDto> BlogsFav { get; set; }
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
}