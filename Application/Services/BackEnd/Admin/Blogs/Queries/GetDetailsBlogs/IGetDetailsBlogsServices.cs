using System.Collections.Generic;
using Domain.Entities;
using Domain.Entities.Dtos;
using  Domain.Entities.IdealCrm;

namespace  Application.Services.BackEnd.Admin.Blogs.Queries.GetDetailsBlogs
{
    public interface IGetDetailsBlogsServices
    {
        BaseDto<BlogDto>  Execute(int id);
    }
}