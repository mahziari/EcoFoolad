using  Application.Services.BackEnd.Admin.BlogsCategories.Command.CreateBlogsCategories;
using  Application.Services.BackEnd.Admin.BlogsCategories.Command.DeleteBlogsCategories;
using  Application.Services.BackEnd.Admin.BlogsCategories.Command.EditBlogsCategories;
using  Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetCreateBlogsCategories;
using  Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetEditBlogsCategories;
using  Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetIndexBlogsCategories;

namespace  Application.Interfaces.FacadPatterns.BackEnd.Admin
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