 

using System.Collections.Generic;
using Application.Interfaces.Contexts;
using Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetEditBlogsCategories;
using Domain.Entities;

namespace  Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetCreateBlogsCategories
{
    public class GetCreateBlogsCategoriesServices : IGetCreateBlogsCategoriesServices
    {
        private readonly ICustomDbContext _customDbContext;

        public GetCreateBlogsCategoriesServices(ICustomDbContext customDbContext)
        {
            _customDbContext = customDbContext;
        }


        public BlogCategoryDto Execute()
        {
            return new();
        }
    }
}