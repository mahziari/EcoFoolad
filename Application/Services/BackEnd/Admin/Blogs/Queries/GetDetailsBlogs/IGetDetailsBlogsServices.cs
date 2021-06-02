using System.Collections.Generic;
using  Domain.Entities.IdealCrm;

namespace  Application.Services.BackEnd.Admin.Blogs.Queries.GetDetailsBlogs
{
    public interface IGetDetailsBlogsServices
    {
        ResultGetDetailsBlogsDto Execute(int id);
    }
}