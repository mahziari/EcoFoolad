using  Application.Services.BackEnd.Admin.Blogs.Command.ActiveBlogs;
using  Application.Services.BackEnd.Admin.Blogs.Command.CreateBlogs;
using  Application.Services.BackEnd.Admin.Blogs.Command.DeleteBlogs;
using  Application.Services.BackEnd.Admin.Blogs.Command.EditBlogs;
using  Application.Services.BackEnd.Admin.Blogs.Queries.GetCreateBlogs;
using  Application.Services.BackEnd.Admin.Blogs.Queries.GetDetailsBlogs;
using  Application.Services.BackEnd.Admin.Blogs.Queries.GetEditBlogs;
using  Application.Services.BackEnd.Admin.Blogs.Queries.GetIndexBlogs;

namespace  Application.Interfaces.FacadPatterns.BackEnd.Admin
{
    public interface IBlogsFacad
    {
        IGetIndexBlogsServices GetIndexBlogsServices { get; }
        IGetCreateBlogsServices GetCreateBlogsServices { get; }
        ICreateBlogsServices CreateBlogsServices { get; }
        IGetDetailsBlogsServices GetDetailsBlogsServices { get; }
        IGetEditBlogsServices GetEditBlogsServices { get; }
        IEditBlogsServices EditBlogsServices { get; }
        IDeleteBlogsServices DeleteBlogsServices { get; }
        IActiveBlogsServices ActiveBlogsServices { get; }

    }
}