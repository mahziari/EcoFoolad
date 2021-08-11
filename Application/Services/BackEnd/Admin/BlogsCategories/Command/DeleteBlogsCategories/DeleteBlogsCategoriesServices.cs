 

using System.Collections.Generic;
using Application.Interfaces.Contexts;
using Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetEditBlogsCategories;
using Domain.Entities;
using Domain.Entities.Dtos;

namespace  Application.Services.BackEnd.Admin.BlogsCategories.Command.DeleteBlogsCategories
{
    public class DeleteBlogsCategoriesServices : IDeleteBlogsCategoriesServices
    {
        private readonly ICustomDbContext _customDbContext;

        public DeleteBlogsCategoriesServices(ICustomDbContext customDbContext)
        {
            _customDbContext = customDbContext;
        }


        public BaseDto<BlogCategoryDto> Execute(int id)
        {
            var blogCategory = _customDbContext.BlogCategories.Find(id);
            
            if (blogCategory == null)
            {
                return new BaseDto<BlogCategoryDto>
                (
                    false,
                    new List<string> {"یافت نشد"},
                    null
                );
            }
            
            _customDbContext.BlogCategories.Remove(blogCategory);
            _customDbContext.SaveChanges();
            return new BaseDto<BlogCategoryDto>
            (
                false,
                new List<string> {"با موفقیت حذف شد"},
                null
            );
        }

    }
}