namespace  Application.Services.BackEnd.Admin.BlogsCategories.Command.DeleteBlogsCategories
{
    public interface IDeleteBlogsCategoriesServices
    {
        ResultDeleteBlogsCategoriesDto Execute(int id);
    }
}