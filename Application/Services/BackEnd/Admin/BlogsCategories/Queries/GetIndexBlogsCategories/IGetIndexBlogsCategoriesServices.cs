using System.Collections.Generic;
using Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetEditBlogsCategories;

namespace  Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetIndexBlogsCategories
{
    public interface IGetIndexBlogsCategoriesServices
    {
        List<BlogCategoryDto> Execute();
    }
}