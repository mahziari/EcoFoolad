using Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetEditBlogsCategories;
using Domain.Entities;

namespace  Application.Services.BackEnd.Admin.BlogsCategories.Command.ActiveBlogsCategories
{
    public interface IActiveBlogsCategoriesServices
    {
        BaseDto<BlogCategoryDto> Execute(int id);
    }
}