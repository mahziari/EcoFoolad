using System.ComponentModel.DataAnnotations;
using Application.Services.BackEnd.Admin.Blogs.Queries.GetCreateBlogs;
using Domain.Entities;
using Microsoft.AspNetCore.Http;

namespace  Application.Services.BackEnd.Admin.Blogs.Queries.GetEditBlogs
{
    public interface IGetEditBlogsServices
    {
        GetEditBlogsDto Execute(int id);
    }
}