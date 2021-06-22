using Application.Interfaces.Contexts;
 
using  Application.Interfaces.FacadPatterns.FrontEnd;
using  Application.Services.FrontEnd.Blogs.Queries;

namespace  Application.Services.FrontEnd.Blogs.FacadPattern
{
    public class BlogsFrontEndFacad: IBlogsFrontEndFacad
    {
        private readonly IIdealCrmDataBaseContext _context;
        private readonly ICustomDbContext _customDbContext;

        public BlogsFrontEndFacad(IIdealCrmDataBaseContext context, ICustomDbContext customDbContext)
        {
            _context = context;
            _customDbContext = customDbContext;
        }
        
        private IGetBlogsFrontEndService _getBlogsFrontEndService;
        public IGetBlogsFrontEndService GetBlogsFrontEndService
        {
            get
            {
                return _getBlogsFrontEndService ??= new GetBlogsFrontEndService(_context,_customDbContext);
            }
        }
        
        
        private IGetBlogsDetailsFrontEndService _getBlogsDetailsFrontEndService;
        public IGetBlogsDetailsFrontEndService GetBlogsDetailsFrontEndService
        {
            get
            {
                return _getBlogsDetailsFrontEndService ??= new GetBlogsDetailsFrontEndService(_context,_customDbContext);
            }
        }
        
        
        
        private IGetBlogsCategoryFrontEndService _getBlogsCategoryFrontEndService;
        public IGetBlogsCategoryFrontEndService GetBlogsCategoryFrontEndService
        {
            get
            {
                return _getBlogsCategoryFrontEndService ??= new GetBlogsCategoryFrontEndService(_context,_customDbContext);
            }
        }
    }
}