using  Application.Services.FrontEnd.Blogs.Queries;

namespace  Application.Interfaces.FacadPatterns.FrontEnd
{
    public interface IBlogsFrontEndFacad
    {
        IGetBlogsFrontEndService GetBlogsFrontEndService { get; }
        IGetBlogsDetailsFrontEndService GetBlogsDetailsFrontEndService { get; }
        IGetBlogsCategoryFrontEndService GetBlogsCategoryFrontEndService { get; }

    }
}