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
                .Where(b => b.Title == title.Replace("-"," "))
                .Include(b=>b.BlogCategory)
                .OrderByDescending(p=>p.Id)
                .SingleOrDefault();
            blogModel.VisitCount += 1;
            _customDbContext.SaveChanges();
            var blog = _mapper.Map<GetBlogsCatrgoryDto>(blogModel);

            // _context.CrmCmsNews.Single(b => b.Title == title.Replace("-", " ")).VisitCount+=1;
            
            


            var relatedBlogModel = _customDbContext.Blogs
                .OrderByDescending(p => p.Id)
                .Take(5).ToList();
            var relatedBlog = _mapper.Map<GetBlogsCatrgoryDto>(relatedBlogModel);

            var blogsGroup = _customDbContext.BlogCategories.Take(3).ToList();
            var footers = _customDbContext.Footers.FirstOrDefault();
            

            return new ResultGetBlogsDetailsFrontEndDto
            {
                Blog = blog,
                RelatedBlog = relatedBlog,
                BlogsGroup = blogsGroup,
                Footers = footers,
            };
        }
    }

    public class ResultGetBlogsDetailsFrontEndDto
    {
        public GetBlogsCatrgoryDto Blog { get; set; }
        public GetBlogsCatrgoryDto RelatedBlog { get; set; }
        public List<BlogCategory> BlogsGroup { get; set; }
        public Footer Footers { get; set; }
    }


    public class GetBlogsDetailsDto
    {
        public int BlogCategoryId { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string SmallDescription { get; set; }
        public string Body { get; set; }
        public bool IsVerified { get; set; }
        public string RegisterUserId { get; set; }
        public int Position { get; set; }
        public string LocalTime { get; set; }
        public int VisitCount { get; set; }
        public bool RequestToAuthorFav { get; set; }
        public bool IsVideoClip { get; set; }
        public string VideoClipDuration { get; set; }
    }
}