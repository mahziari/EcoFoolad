using Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetEditBlogsCategories;
using Domain.Entities;
using Domain.Entities.Dtos;

namespace  Application.Services.BackEnd.Admin.BlogsCategories.Command.DeleteBlogsCategories
{
    public interface IDeleteBlogsCategoriesServices
    {
        BaseDto<BlogCategoryDto> Execute(int id);
    }
}