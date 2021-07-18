using System.Collections.Generic;
using Domain.Entities.Blogs;
using Microsoft.AspNetCore.Http;
using  Domain.Entities.IdealCrm;

namespace  Application.Services.BackEnd.Admin.Blogs.Queries.GetCreateBlogs
{
    public class ResultGetCreateBlogsDto
    {
        public List<GetBlogCategoryDto> BlogCategory{ get; set; }
        public List<Blog> Blogs { get; set; }
        public int BlogCategoryId { get; set; }
        public string Title { get; set; }
        public string SmallDescription { get; set; }
        public string Body { get; set; }
        public IFormFile Image { get; set; }
        public int Position { get; set; }
        public bool RequestToAuthorFav { get; set; }
    }
}