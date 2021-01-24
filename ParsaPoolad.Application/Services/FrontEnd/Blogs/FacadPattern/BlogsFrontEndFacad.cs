using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Application.Interfaces.FacadPatterns.FrontEnd;
using ParsaPoolad.Application.Services.FrontEnd.Blogs.Queries;

namespace ParsaPoolad.Application.Services.FrontEnd.Blogs.FacadPattern
{
    public class BlogsFrontEndFacad: IBlogsFrontEndFacad
    {
        private readonly IDataBaseContext _context;
        private readonly IIdentityDataBaseContext _parsapooladContext;

        public BlogsFrontEndFacad(IDataBaseContext context,IIdentityDataBaseContext parsapooladContext)
        {
            _context = context;
            _parsapooladContext = parsapooladContext;
        }
        
        private IGetBlogsFrontEndService _getBlogsFrontEndService;
        public IGetBlogsFrontEndService GetBlogsFrontEndService
        {
            get
            {
                return _getBlogsFrontEndService ??= new GetBlogsFrontEndService(_context,_parsapooladContext);
            }
        }
        
        
        private IGetBlogsDetailsFrontEndService _getBlogsDetailsFrontEndService;
        public IGetBlogsDetailsFrontEndService GetBlogsDetailsFrontEndService
        {
            get
            {
                return _getBlogsDetailsFrontEndService ??= new GetBlogsDetailsFrontEndService(_context);
            }
        }
        
        
        
        private IGetBlogsCategoryFrontEndService _getBlogsCategoryFrontEndService;
        public IGetBlogsCategoryFrontEndService GetBlogsCategoryFrontEndService
        {
            get
            {
                return _getBlogsCategoryFrontEndService ??= new GetBlogsCategoryFrontEndService(_context);
            }
        }
    }
}