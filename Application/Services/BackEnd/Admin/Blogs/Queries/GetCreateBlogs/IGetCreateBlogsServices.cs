using System.ComponentModel.DataAnnotations;

namespace  Application.Services.BackEnd.Admin.Blogs.Queries.GetCreateBlogs
{
    public interface IGetCreateBlogsServices
    {
        ResultGetCreateBlogsDto Execute();
    }
}