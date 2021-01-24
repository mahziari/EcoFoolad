using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ParsaPoolad.Application.Interfaces.Contexts;

namespace ParsaPoolad.Application.Services.FrontEnd.Blogs.Queries
{
    public interface IGetBlogsDetailsFrontEndService
    {
        ResultGetBlogsDetailsFrontEndDto Execute(string title);
    }

    public class GetBlogsDetailsFrontEndService: IGetBlogsDetailsFrontEndService
    {
        private readonly IDataBaseContext _context;

        public GetBlogsDetailsFrontEndService(IDataBaseContext context)
        {
            _context = context;
        }



        public ResultGetBlogsDetailsFrontEndDto Execute(string title)
        {
            var blog = _context.CrmCmsNews
                .Where(b => b.Title == title.Replace("-"," "))
                .Include(b=>b.NewsGroup)
                .Select(b => new GetBlogsDetailsDto
                {
                    NewsId=b.NewsId,
                    NewsGroupId=b.NewsGroupId,
                    NewsGroupName = b.NewsGroup.GroupName,
                    en_NewsGroupName = b.NewsGroup.en_GroupName,
                    Title = b.Title,
                    NewsBody=b.NewsBody,
                    NewsSummery=b.NewsSummery,
                    RegisterDatePersian =b.RegisterDate.ToPersianDigitalDateTimeString(),
                    IsVerified = b.IsVerified,
                    Position=b.Position,
                    HeadLine=b.HeadLine
                }).FirstOrDefault();

            return new ResultGetBlogsDetailsFrontEndDto
            {
                Blog = blog,
            };
        }
    }

    public class ResultGetBlogsDetailsFrontEndDto
    {
        public GetBlogsDetailsDto Blog { get; set; }
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
        public string RegisterDatePersian { get; set; }
        public bool IsVerified { get; set; }
        public int Position { get; set; }
    }
}