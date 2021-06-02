using  Domain.Entities.IdealCrm;

namespace  Application.Services.BackEnd.Admin.Blogs.Command.DeleteBlogs
{
    public interface IDeleteBlogsServices
    {
        ResultDeleteBlogDto Execute(int id);
    }
}