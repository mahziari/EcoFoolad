using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Domain.Entities;

namespace ParsaPoolad.Application.Services.FrontEnd.Blogs.Queries
{
    public interface IGetBlogsFrontEndService
    {
        ResultGetBlogsFrontEndDto Execute();
    }

    public class GetBlogsFrontEndService : IGetBlogsFrontEndService
    {
        private readonly IDataBaseContext _context;
        private readonly IIdentityDataBaseContext _parsapooladContext;

        public GetBlogsFrontEndService(IDataBaseContext context,IIdentityDataBaseContext parsapooladContext)
        {
            _context = context;
            _parsapooladContext = parsapooladContext;
        }



        public ResultGetBlogsFrontEndDto Execute()
        {
            var blogs = _context.CrmCmsNews
                .Where(s=>s.IsVerified==true)
                .Include(s=>s.NewsGroup)
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
                    RegisterDatePersian =s.RegisterDate.ToPersianDigitalDateTimeString(),
                    IsVerified = s.IsVerified,
                    Position=s.Position,
                }).ToList();

            var blogsGroup = _context.CrmCmsNewsGroups.ToList();



            return new ResultGetBlogsFrontEndDto
            {
                Blogs = blogs,
                BlogsGroup = blogsGroup,
            };
        }
    }

    public class ResultGetBlogsFrontEndDto
    {
        public List<GetBlogsDto> Blogs { get; set; }
        public List<CrmCmsNewsGroups> BlogsGroup { get; set; }
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
        public string RegisterDatePersian { get; set; }
        public bool IsVerified { get; set; }
        public int Position { get; set; }
    }
}