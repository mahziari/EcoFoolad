using  Application.Services.BackEnd.Admin.BlogsCategories.Command.CreateBlogsCategories;
using  Domain.Entities.IdealCrm;

namespace  Application.Services.BackEnd.Admin.BlogsCategories.Command.EditBlogsCategories
{
    public interface IEditBlogsCategoriesServices
    {
        ResultEditBlogsCategoriesDto Execute(CreateBlogsCategoriesServicesDto createBlogsCategoriesServicesDto,
            CrmCmsNewsGroups crmCmsNewsGroups, int id);
    }
}