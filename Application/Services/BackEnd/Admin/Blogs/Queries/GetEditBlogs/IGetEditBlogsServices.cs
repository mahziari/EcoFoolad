using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace  Application.Services.BackEnd.Admin.Blogs.Queries.GetEditBlogs
{
    public interface IGetEditBlogsServices
    {
        ResultGetEditBlogsDto Execute(int id);
    }
}