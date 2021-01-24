using ParsaPoolad.Application.Services.BackEnd.Admin.BlogsCategories.Command;
using ParsaPoolad.Application.Services.BackEnd.Admin.BlogsCategories.Queries;

namespace ParsaPoolad.Application.Interfaces.FacadPatterns.BackEnd.Admin
{
    public interface IBlogsCategoriesFacad
    {
        IGetIndexBlogsCategoriesServices GetIndexBlogsCategoriesServices { get; }
        IGetCreateBlogsCategoriesServices GetCreateBlogsCategoriesServices { get; }
        ICreateBlogsCategoriesServices CreateBlogsCategoriesServices { get; }
        IGetEditBlogsCategoriesServices GetEditBlogsCategoriesServices { get; }
        IEditBlogsCategoriesServices EditBlogsCategoriesServices { get; }
        IDeleteBlogsCategoriesServices DeleteBlogsCategoriesServices { get; }
        // IActiveBlogsCategoriesServices ActiveBlogsCategoriesServices { get; }  
    }
}