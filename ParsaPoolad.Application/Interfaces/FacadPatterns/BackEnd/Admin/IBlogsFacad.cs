using ParsaPoolad.Application.Services.BackEnd.Admin.Blogs.Command;
using ParsaPoolad.Application.Services.BackEnd.Admin.Blogs.Queries;

namespace ParsaPoolad.Application.Interfaces.FacadPatterns.BackEnd.Admin
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