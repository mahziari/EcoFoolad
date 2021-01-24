using ParsaPoolad.Application.Services.FrontEnd.Blogs.Queries;

namespace ParsaPoolad.Application.Interfaces.FacadPatterns.FrontEnd
{
    public interface IBlogsFrontEndFacad
    {
        IGetBlogsFrontEndService GetBlogsFrontEndService { get; }
        IGetBlogsDetailsFrontEndService GetBlogsDetailsFrontEndService { get; }
        IGetBlogsCategoryFrontEndService GetBlogsCategoryFrontEndService { get; }

    }
}