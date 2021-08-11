using Domain.Entities;
using Domain.Entities.Dtos;

namespace  Application.Services.BackEnd.Admin.Blogs.Command.ActiveBlogs
{
    public interface IActiveBlogsServices
    {
        BaseDto Execute(int id);
    }
}