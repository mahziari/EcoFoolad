using Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetEditBlogsCategories;
using Domain.Entities;
using Domain.Entities.Dtos;

namespace  Application.Services.BackEnd.Admin.BlogsCategories.Command.ActiveBlogsCategories
{
    public interface IActiveBlogsCategoriesServices
    {
        BaseDto<BlogCategoryDto> Execute(int id);
    }
}