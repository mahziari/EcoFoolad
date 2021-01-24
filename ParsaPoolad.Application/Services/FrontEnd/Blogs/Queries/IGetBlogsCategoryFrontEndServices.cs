using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ParsaPoolad.Application.Interfaces.Contexts;

namespace ParsaPoolad.Application.Services.FrontEnd.Blogs.Queries
{
    public interface IGetBlogsCategoryFrontEndService
    {
        ResultGetBlogsCategoryFrontEndDto Execute(string category);
    }

    public class GetBlogsCategoryFrontEndService: IGetBlogsCategoryFrontEndService
    {
        private readonly IDataBaseContext _context;

        public GetBlogsCategoryFrontEndService(IDataBaseContext context)
        {
            _context = context;
        }



        public ResultGetBlogsCategoryFrontEndDto Execute(string category)
        {
            var blogsCatrgory = _context.CrmCmsNews
                .Include(b=>b.NewsGroup)
                .Where(b => b.NewsGroup.en_GroupName == category)
                .Where(b=>b.Position == 0)
                .Select(b => new GetBlogsCatrgoryDto
                {
                    NewsId=b.NewsId,
                    NewsGroupId=b.NewsGroupId,
                    NewsGroupName = b.NewsGroup.GroupName,
                    en_NewsGroupName = b.NewsGroup.en_GroupName,
                    Title = b.Title,
                    NewsBody=b.NewsBody,
                    NewsSummery=b.NewsSummery,
                    RegisterDatePersian = b.FirstRegisterDatePersian,
                    IsVerified = b.IsVerified,
                    Position=b.Position,
                    HeadLine=b.HeadLine
                }).ToList();

            return new ResultGetBlogsCategoryFrontEndDto
            {
                BlogsCatrgory =blogsCatrgory,
            };
        }
    }

    public class ResultGetBlogsCategoryFrontEndDto
    {
        public List<GetBlogsCatrgoryDto> BlogsCatrgory { get; set; }
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