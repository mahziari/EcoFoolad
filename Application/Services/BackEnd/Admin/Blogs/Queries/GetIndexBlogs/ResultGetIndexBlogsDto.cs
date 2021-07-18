using System.Collections.Generic;
using  Domain.Entities.IdealCrm;

namespace  Application.Services.BackEnd.Admin.Blogs.Queries.GetIndexBlogs
{
    public class ResultGetIndexBlogsDto
    {
        public List<GetIndexBlogsDto> Blogs { get; set; }
    }
}