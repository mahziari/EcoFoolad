using System.ComponentModel.DataAnnotations;
using Domain.Entities;

namespace  Application.Services.BackEnd.Admin.Blogs.Queries.GetCreateBlogs
{
    public interface IGetCreateBlogsServices
    {
        GetCreateBlogsDto Execute();
    }
}