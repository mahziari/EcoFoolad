using Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetEditBlogsCategories;
using Domain.Entities;

namespace  Application.Services.BackEnd.Admin.BlogsCategories.Command.DeleteBlogsCategories
{
    public interface IDeleteBlogsCategoriesServices
    {
        BaseDto<BlogCategoryDto> Execute(int id);
    }
}