using Domain.Entities;
using Domain.Entities.Dtos;

namespace  Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetEditBlogsCategories
{
    public interface IGetEditBlogsCategoriesServices
    {
        BaseDto<BlogCategoryDto> Execute(int id);
    }
}