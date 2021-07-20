using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Application.Interfaces.Contexts;
using AutoMapper;
using Domain.Entities.Blogs;
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
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;
        public GetBlogsDetailsFrontEndService(ICustomDbContext customDbContext, IMapper mapper)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
        }



        public ResultGetBlogsDetailsFrontEndDto Execute(string title)
        {
            var blogModel = _customDbContext.Blogs
                .Include(b=>b.BlogCategory)
                .Where(b => b.Title == title.Replace("-"," "))
                .OrderByDescending(p=>p.Id)
                .FirstOrDefault();
            blogModel.VisitCount += 1;
            _customDbContext.SaveChanges();
            var blog = _mapper.Map<GetBlogsDto>(blogModel);

            // _context.CrmCmsNews.Single(b => b.Title == title.Replace("-", " ")).VisitCount+=1;
            
            


            var relatedBlogModel = _customDbContext.Blogs
                .Include(p=>p.BlogCategory)
                .OrderByDescending(p => p.Id)
                .Take(5);
            var relatedBlog = _mapper.Map<List<GetBlogsDto>>(relatedBlogModel);

            var blogCategory = _customDbContext.BlogCategories.Take(3).ToList();
            var footers = _customDbContext.Footers.FirstOrDefault();
            

            return new ResultGetBlogsDetailsFrontEndDto
            {
                Blog = blog,
                RelatedBlog = relatedBlog,
                BlogCategory = blogCategory,
                Footers = footers,
            };
        }
    }

    public class ResultGetBlogsDetailsFrontEndDto
    {
        public GetBlogsDto Blog { get; set; }
        public List<GetBlogsDto> RelatedBlog { get; set; }
        public List<BlogCategory> BlogCategory { get; set; }
        public Footer Footers { get; set; }
    }
}