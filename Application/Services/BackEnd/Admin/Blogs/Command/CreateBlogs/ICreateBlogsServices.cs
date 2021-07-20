using Domain.Entities;

namespace  Application.Services.BackEnd.Admin.Blogs.Command.CreateBlogs
{
    public interface ICreateBlogsServices
    {
        BaseDto Execute(BlogDto blogDto);
    }
}