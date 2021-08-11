using Domain.Entities;
using Domain.Entities.Dtos;
using  Domain.Entities.IdealCrm;

namespace  Application.Services.BackEnd.Admin.Blogs.Command.DeleteBlogs
{
    public interface IDeleteBlogsServices
    {
        BaseDto Execute(int id);
    }
}