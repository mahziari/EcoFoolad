using  Application.Services.FrontEnd.Blogs.Queries;

namespace  Application.Interfaces.FacadPatterns.FrontEnd
{
    public interface IBlogsFrontEndFacad
    {
        IGetBlogsFrontEndService GetBlogsFrontEndService { get; }
        IGetArchiveBlogsFrontEndService GetArchiveBlogsFrontEndService { get; }
        IGetBlogsDetailsFrontEndService GetBlogsDetailsFrontEndService { get; }
        IGetBlogsCategoryArchiveFrontEndServices GetBlogsCategoryArchiveFrontEndServices { get; }
        IGetBlogsCategoryFrontEndService GetBlogsCategoryFrontEndService { get; }

    }
}