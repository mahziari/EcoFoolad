using System;
using System.Collections.Generic;
using System.Linq;
using Application.Interfaces.Contexts;
using AutoMapper;
using Domain.Entities.Footer;
using Microsoft.EntityFrameworkCore;
 

namespace  Application.Services.FrontEnd.Blogs.Queries
{
    public interface IGetAllBlogsFrontEndService
    {
        ResultGetAllBlogsFrontEndDto Execute(int page);
    }

    public class GetAllBlogsFrontEndService: IGetAllBlogsFrontEndService
    {
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;

        public GetAllBlogsFrontEndService(ICustomDbContext customDbContext, IMapper mapper)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
        }



        public ResultGetAllBlogsFrontEndDto Execute(int page)
        {

            var resultInEachPage = 2;
            int skip = (page - 1) * resultInEachPage;
            int count = _customDbContext.Blogs
                .Where(g => g.IsVerified)
                .Where(s => s.RequestToAuthorFav!=true)
                .Count(b => b.Position == 0);
            var pageId = page;
            var pageCount = (int)Math.Ceiling(count / (double)resultInEachPage);


            var blogsModel = _customDbContext.Blogs
                .Include(b=>b.BlogCategory)
                .Where(g => g.IsVerified)
                .Where(s => s.Position == 0)
                .OrderByDescending(b=>b.Id)
                .Skip(skip).Take(resultInEachPage);

            var blogs = _mapper.Map<List<GetBlogsDto>>(blogsModel);


            var footers = _customDbContext.Footers.Single();
            
            return new ResultGetAllBlogsFrontEndDto
            {
                Blogs =blogs,
                PageId =pageId,
                PageCount =pageCount,
                Footers =footers,
            };
        }
    }

    public class ResultGetAllBlogsFrontEndDto
    {
        public List<GetBlogsDto> Blogs { get; set; }
        public Footer Footers { get; set; }
        public GetBlogCategoryDto CategoryItem { get; set; }
        public int PageId { get; set; }
        public int PageCount { get; set; }
    }
}