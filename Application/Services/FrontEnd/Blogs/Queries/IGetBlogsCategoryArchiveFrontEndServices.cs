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
    public interface IGetBlogsCategoryArchiveFrontEndServices
    {
        ResultGetBlogsCategoryArchiveFrontEndDto Execute(string category,int pageNumber);
    }


    public class GetBlogsCategoryArchiveFrontEndServices: IGetBlogsCategoryArchiveFrontEndServices
    {
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;

        public GetBlogsCategoryArchiveFrontEndServices(ICustomDbContext customDbContext, IMapper mapper)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
        }



        public ResultGetBlogsCategoryArchiveFrontEndDto Execute(string category,int pageNumber)
        {
            var blogsModel = _customDbContext.Blogs
                .Include(b=>b.BlogCategory)
                .Where(b => b.BlogCategory.Slug == category.Replace('-',' '))
                .Where(g => g.IsVerified)
                .Where(s => s.Position == 0)
                .OrderByDescending(b=>b.Id);
            var mapedBlogs = _mapper.Map<List<GetBlogsDto>>(blogsModel);
            var blogs = mapedBlogs.ToPagedList(pageNumber, 1);


            var footers = _customDbContext.Footers.Single();
            
            return new ResultGetBlogsCategoryArchiveFrontEndDto
            {
                Blogs =blogs,
                Footers =footers,
            };
        }
    }

    public class ResultGetBlogsCategoryArchiveFrontEndDto
    {
        public IPagedList<GetBlogsDto> Blogs { get; set; }
        public Footer Footers { get; set; }
        public GetBlogCategoryDto CategoryItem { get; set; }
    }
}