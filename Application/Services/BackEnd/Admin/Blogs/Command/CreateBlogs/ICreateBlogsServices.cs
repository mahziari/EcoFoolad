using Domain.Entities;
using Domain.Entities.Dtos;

namespace  Application.Services.BackEnd.Admin.Blogs.Command.CreateBlogs
{
    public interface ICreateBlogsServices
    {
        BaseDto Execute(BlogDto blogDto);
    }
}