using System;
using System.Collections.Generic;
using System.Linq;
using Application.Interfaces.Contexts;
using AutoMapper;
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
        private readonly IIdealCrmDataBaseContext _context;
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;

        public GetBlogsCategoryFrontEndService(IIdealCrmDataBaseContext context, ICustomDbContext customDbContext, IMapper mapper)
        {
            _context = context;
            _customDbContext = customDbContext;
            _mapper = mapper;
        }



        public ResultGetBlogsCategoryFrontEndDto Execute(string category, int page)
        {

            var resultInEachPage = 12;
            int skip = (page - 1) * resultInEachPage;
            int count = _context.CrmCmsNews
                .Where(b=>b.NewsGroup.en_GroupName == category)
                .Where(b=>b.IsVerified)
                .Count(b => b.Position == 0);
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
                    Title = b.Title.Replace(" ", "-"),
                    NewsBody=b.NewsBody,
                    NewsSummery=b.NewsSummery,
                    DateTime= b.RegisterDate.ToPersianDateTime().ToString("yyyy/MM/d hh:mm"),
                    IsVerified = b.IsVerified,
                    Position=b.Position,
                    HeadLine=b.HeadLine,
                }).Skip(skip).Take(resultInEachPage).ToList();


            var model = _context.CrmCmsNewsGroups
                .Single(b => b.en_GroupName == category);
            var categoryItem = _mapper.Map<CategoryItemDto>(model);



            var footers = _customDbContext.Footers.FirstOrDefault();
            
            return new ResultGetBlogsCategoryFrontEndDto
            {
                BlogsCatrgory =blogsCatrgory,
                PageId =pageId,
                PageCount =pageCount,
                CategoryItem =categoryItem,
                Footers =footers,
            };
        }
    }

    public class ResultGetBlogsCategoryFrontEndDto
    {
        public List<GetBlogsCatrgoryDto> BlogsCatrgory { get; set; }
        public Footer Footers { get; set; }
        public CategoryItemDto CategoryItem { get; set; }
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
        public string DateTime { get; set; }
        public bool IsVerified { get; set; }
        public int Position { get; set; }
    }

    public class CategoryItemDto
    {
        public string GroupName { get; set; }
        public string en_GroupName { get; set; }
        public string Description { get; set; }
        public string LocalTime { get; set; }
    }
}