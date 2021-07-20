using  Application.Services.BackEnd.Admin.BlogsCategories.Command.CreateBlogsCategories;
using Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetEditBlogsCategories;
using Domain.Entities;
using  Domain.Entities.IdealCrm;

namespace  Application.Services.BackEnd.Admin.BlogsCategories.Command.EditBlogsCategories
{
    public interface IEditBlogsCategoriesServices
    {
        BaseDto<BlogCategoryDto> Execute(BlogCategoryDto blogsCategoryDto);
    }
}