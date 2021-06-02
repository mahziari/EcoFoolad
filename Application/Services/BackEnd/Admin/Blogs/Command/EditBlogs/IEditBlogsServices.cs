using System.Linq;
using  Domain.Entities.IdealCrm;

namespace  Application.Services.BackEnd.Admin.Blogs.Command.EditBlogs
{
    public interface IEditBlogsServices
    {
        ResultEditBlogsDto Execute(EditBlogsServicesDto editBlogsServicesDto,int id);
    }
}