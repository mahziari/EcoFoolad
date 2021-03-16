using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ParsaPoolad.Application.Interfaces.Contexts;

namespace ParsaPoolad.Application.Services.FrontEnd.Blogs.Queries
{
    public interface IGetBlogsCategoryFrontEndService
    {
        ResultGetBlogsCategoryFrontEndDto Execute(string category, int page);
    }

    public class GetBlogsCategoryFrontEndService: IGetBlogsCategoryFrontEndService
    {
        private readonly IIdealCrmDataBaseContext _context;

        public GetBlogsCategoryFrontEndService(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }



        public ResultGetBlogsCategoryFrontEndDto Execute(string category, int page)
        {

            var resultInEachPage = 1;
            int skip = (page - 1) * resultInEachPage;
            int count = _context.CrmCmsNews
                .Where(b => b.NewsGroup.en_GroupName == category)
                .Where(b=>b.IsVerified)
                .Where(b=>b.Position == 0)
                .Count();
            var pageId = page;
            var pageCount = (int)Math.Ceiling(count / (double)resultInEachPage);


            var blogsCatrgory = _context.CrmCmsNews
                .Include(b=>b.NewsGroup)
                .Where(b => b.NewsGroup.en_GroupName == category)
                .Where(b=>b.IsVerified)
                .Where(b=>b.Position == 0)
                .OrderByDescending(b=>b.NewsId)
                .Select(b => new GetBlogsCatrgoryDto
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
                }).Skip(skip).Take(resultInEachPage).ToList();

            
            
            
            return new ResultGetBlogsCategoryFrontEndDto
            {
                BlogsCatrgory =blogsCatrgory,
                PageId =pageId,
                PageCount =pageCount,
            };
        }
    }

    public class ResultGetBlogsCategoryFrontEndDto
    {
        public List<GetBlogsCatrgoryDto> BlogsCatrgory { get; set; }
        public int PageId { get; set; }
        public int PageCount { get; set; }
    }


    public class GetBlogsCatrgoryDto
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
        public DateTime PublishDateTime { get; set; }
        // public string PublishDateTime { get; set; }
        public bool IsVerified { get; set; }
        public int Position { get; set; }
    }
}