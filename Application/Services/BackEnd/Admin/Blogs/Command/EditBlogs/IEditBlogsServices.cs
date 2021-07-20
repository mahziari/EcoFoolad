using System.Linq;
using Domain.Entities;
using  Domain.Entities.IdealCrm;

namespace  Application.Services.BackEnd.Admin.Blogs.Command.EditBlogs
{
    public interface IEditBlogsServices
    {
        BaseDto Execute(BlogDto blogDto);
    }
}