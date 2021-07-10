using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Application.Interfaces.Contexts;
using Domain.Entities.Footer;
using Domain.Entities.IdealCrm;
using Microsoft.EntityFrameworkCore;
 

namespace  Application.Services.FrontEnd.Blogs.Queries
{
    public interface IGetBlogsDetailsFrontEndService
    {
        ResultGetBlogsDetailsFrontEndDto Execute(string title);
    }

    public class GetBlogsDetailsFrontEndService: IGetBlogsDetailsFrontEndService
    {
        private readonly IIdealCrmDataBaseContext _context;
        private readonly ICustomDbContext _customDbContext;

        public GetBlogsDetailsFrontEndService(IIdealCrmDataBaseContext context, ICustomDbContext customDbContext)
        {
            _context = context;
            _customDbContext = customDbContext;
        }



        public ResultGetBlogsDetailsFrontEndDto Execute(string title)
        {
            var blog = _context.CrmCmsNews
                .Where(b => b.Title == title.Replace("-"," "))
                .Include(b=>b.NewsGroup)
                .OrderByDescending(p=>p.NewsId)
                .Select(b => new GetBlogsDetailsDto
                {
                    NewsId=b.NewsId,
                    NewsGroupId=b.NewsGroupId,
                    NewsGroupName = b.NewsGroup.GroupName,
                    en_NewsGroupName = b.NewsGroup.en_GroupName,
                    Title = b.Title,
                    NewsBody=b.NewsBody,
                    NewsSummery=b.NewsSummery,
                    DateTime =b.RegisterDate.ToPersianDateTime().ToString("yyyy/MM/d"),
                    LocalTime=b.LocalTime,
                    IsVerified = b.IsVerified,
                    Position=b.Position,
                    HeadLine=b.HeadLine,
                    VisitCount=b.VisitCount,
                }).SingleOrDefault();

            _context.CrmCmsNews.Single(b => b.Title == title.Replace("-", " ")).VisitCount+=1;
            _context.SaveChanges();


            var relatedBlog = _context.CrmCmsNews
                .OrderByDescending(p => p.NewsId)
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
                }).Take(5).ToList();

            var blogsGroup = _context.CrmCmsNewsGroups.Take(3).ToList();
            var footers = _customDbContext.Footers.FirstOrDefault();
            

            return new ResultGetBlogsDetailsFrontEndDto
            {
                Blog = blog,
                RelatedBlog = relatedBlog,
                BlogsGroup = blogsGroup,
                Footers = footers,
            };
        }
    }

    public class ResultGetBlogsDetailsFrontEndDto
    {
        public GetBlogsDetailsDto Blog { get; set; }
        public List<GetBlogsDto> RelatedBlog { get; set; }
        public List<CrmCmsNewsGroups> BlogsGroup { get; set; }
        public Footer Footers { get; set; }
    }


    public class GetBlogsDetailsDto
    {
        public int NewsId { get; set; }
        public int NewsGroupId { get; set; }
        public string Title { get; set; }
        public string NewsGroupName { get; set; }
        public string en_NewsGroupName { get; set; }
        public string NewsSummery { get; set; }
        public string NewsBody { get; set; }
        public string HeadLine { get; set; }
        public string DateTime { get; set; }
        public string LocalTime { get; set; }
        public bool IsVerified { get; set; }
        public int Position { get; set; }
        public int VisitCount { get; set; }
    }
}