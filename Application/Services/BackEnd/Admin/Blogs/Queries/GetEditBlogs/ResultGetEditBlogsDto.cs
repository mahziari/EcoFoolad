using System.Collections.Generic;
using Domain.Entities.Blogs;
using  Domain.Entities.IdealCrm;

namespace  Application.Services.BackEnd.Admin.Blogs.Queries.GetEditBlogs
{
    public class ResultGetEditBlogsDto
    {
        public GetEditBlogsDto Blog { get; set; }
        public List<BlogCategory> BlogsGroup { get; set; }
        
        public string Title { get; set; }
        public string SmallDescription { get; set; }
        public string Body { get; set; }
        public int BlogCategoryId { get; set; }
        // public IFormFile Images { get; set; }
        
        public int Position { get; set; }
        public bool RequestToAuthorFav { get; set; }
    }
}