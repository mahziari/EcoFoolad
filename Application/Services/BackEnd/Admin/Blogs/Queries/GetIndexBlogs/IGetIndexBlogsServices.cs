using System.Collections.Generic;
using System.Numerics;
using Domain.Entities;

namespace  Application.Services.BackEnd.Admin.Blogs.Queries.GetIndexBlogs
{
    public interface IGetIndexBlogsServices
    {
        List<BlogDto> Execute();
    }
}