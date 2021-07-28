using  Application.Services.FrontEnd.Blogs.Queries;

namespace  Application.Interfaces.FacadPatterns.FrontEnd
{
    public interface IBlogsFrontEndFacad
    {
        IGetBlogsFrontEndService GetBlogsFrontEndService { get; }
        IGetAllBlogsFrontEndService GetAllBlogsFrontEndService { get; }
        IGetBlogsDetailsFrontEndService GetBlogsDetailsFrontEndService { get; }
        IGetBlogsCategoryFrontEndService GetBlogsCategoryFrontEndService { get; }

    }
}