using System.Collections.Generic;
using  Domain.Entities.IdealCrm;

namespace  Application.Services.BackEnd.Admin.Blogs.Queries.GetEditBlogs
{
    public class ResultGetEditBlogsDto
    {
        public GetEditBlogsDto Blog { get; set; }
        public List<CrmCmsNewsGroups> BlogsGroup { get; set; }
        
        public string Title { get; set; }
        public string NewsSummery { get; set; }
        public string NewsBody { get; set; }
        public int NewsGroupId { get; set; }
        // public IFormFile Images { get; set; }
        
        public int Position { get; set; }
    }
}