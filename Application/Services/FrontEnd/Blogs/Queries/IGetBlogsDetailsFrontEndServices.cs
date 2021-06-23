using System;
using System.Linq;
using System.Web;
using Application.Interfaces.Contexts;
using Domain.Entities.Footer;
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
                    DateTime =b.RegisterDate.ToPersianDateTime().ToString("yyyy/MM/d hh:mm"),
                    LocalTime=b.LocalTime,
                    IsVerified = b.IsVerified,
                    Position=b.Position,
                    HeadLine=b.HeadLine
                }).FirstOrDefault();
            blog.VisitCount ++;
            _context.SaveChanges();
            
            var footers = _customDbContext.Footers.FirstOrDefault();

            return new ResultGetBlogsDetailsFrontEndDto
            {
                Blog = blog,
                Footers = footers,
            };
        }
    }

    public class ResultGetBlogsDetailsFrontEndDto
    {
        public GetBlogsDetailsDto Blog { get; set; }
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