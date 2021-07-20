using Domain.Entities;

namespace  Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetEditBlogsCategories
{
    public interface IGetEditBlogsCategoriesServices
    {
        BaseDto<BlogCategoryDto> Execute(int id);
    }
}