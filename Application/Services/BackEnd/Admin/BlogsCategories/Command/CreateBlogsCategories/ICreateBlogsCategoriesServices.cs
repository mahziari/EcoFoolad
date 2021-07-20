
using Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetEditBlogsCategories;
using Domain.Entities;

namespace  Application.Services.BackEnd.Admin.BlogsCategories.Command.CreateBlogsCategories
{
    public interface ICreateBlogsCategoriesServices
    {
        BaseDto<BlogCategoryDto> Execute(BlogCategoryDto blogsCategoryDto);
    }
}