using System;
using System.Collections.Generic;
using System.Linq;
using Application.Interfaces.Contexts;
using AutoMapper;
using Domain.Entities.Footer;
using Microsoft.EntityFrameworkCore;
using X.PagedList;


namespace  Application.Services.FrontEnd.Blogs.Queries
{
    public interface IGetArchiveBlogsFrontEndService
    {
        ResultGetArchiveBlogsFrontEndDto Execute(int pageNumber);
    }

    public class GetArchiveBlogsFrontEndService: IGetArchiveBlogsFrontEndService
    {
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;

        public GetArchiveBlogsFrontEndService(ICustomDbContext customDbContext, IMapper mapper)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
        }



        public ResultGetArchiveBlogsFrontEndDto Execute(int pageNumber)
        {
            var blogsModel = _customDbContext.Blogs
                .Include(b=>b.BlogCategory)
                .Where(g => g.IsVerified)
                .Where(s => s.Position == 0)
                .OrderByDescending(b=>b.Id);
            var mapedBlogs = _mapper.Map<List<GetBlogsDto>>(blogsModel);
            var blogs = mapedBlogs.ToPagedList(pageNumber, 1);


            var footers = _customDbContext.Footers.Single();
            
            return new ResultGetArchiveBlogsFrontEndDto
            {
                Blogs =blogs,
                Footers =footers,
            };
        }
    }

    public class ResultGetArchiveBlogsFrontEndDto
    {
        public IPagedList<GetBlogsDto> Blogs { get; set; }
        public Footer Footers { get; set; }
        public GetBlogCategoryDto CategoryItem { get; set; }
    }
}