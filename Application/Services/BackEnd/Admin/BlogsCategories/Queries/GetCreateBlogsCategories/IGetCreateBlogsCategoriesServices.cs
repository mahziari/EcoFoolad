using Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetEditBlogsCategories;
using Domain.Entities;

namespace  Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetCreateBlogsCategories
{
    public interface IGetCreateBlogsCategoriesServices
    {
        BlogCategoryDto Execute();
    }
}