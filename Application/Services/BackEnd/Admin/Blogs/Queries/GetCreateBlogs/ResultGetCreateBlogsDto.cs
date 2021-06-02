using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using  Domain.Entities.IdealCrm;

namespace  Application.Services.BackEnd.Admin.Blogs.Queries.GetCreateBlogs
{
    public class ResultGetCreateBlogsDto
    {
        public List<GetBlogsGroupsDto> BlogsGroup { get; set; }
        public List<CrmCmsNews> Blogs { get; set; }
        public int NewsGroupId { get; set; }
        public string Title { get; set; }
        public string NewsSummery { get; set; }
        public string NewsBody { get; set; }
        public IFormFile Images { get; set; }
        public int Position { get; set; }
    }
}