using Application.Interfaces.Contexts;
using Microsoft.AspNetCore.Hosting;
 
using  Application.Interfaces.FacadPatterns.BackEnd.Admin;
using  Application.Services.BackEnd.Admin.Blogs.Command.ActiveBlogs;
using  Application.Services.BackEnd.Admin.Blogs.Command.CreateBlogs;
using  Application.Services.BackEnd.Admin.Blogs.Command.DeleteBlogs;
using  Application.Services.BackEnd.Admin.Blogs.Command.EditBlogs;
using  Application.Services.BackEnd.Admin.Blogs.Queries.GetCreateBlogs;
using  Application.Services.BackEnd.Admin.Blogs.Queries.GetDetailsBlogs;
using  Application.Services.BackEnd.Admin.Blogs.Queries.GetEditBlogs;
using  Application.Services.BackEnd.Admin.Blogs.Queries.GetIndexBlogs;

namespace  Application.Services.BackEnd.Admin.Blogs.FacadPattern
{
    public class BlogsFacad : IBlogsFacad
    {
        
        private readonly IIdealCrmDataBaseContext _context;
        private readonly IWebHostEnvironment _environment;

        public BlogsFacad(IIdealCrmDataBaseContext context,IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }
        
        
        private IGetIndexBlogsServices _getIndexBlogsServices;
        public IGetIndexBlogsServices GetIndexBlogsServices
        {
            get
            {
                return _getIndexBlogsServices ??= new GetIndexBlogsServices(_context);
            }
        }
        
        
        
        private IGetCreateBlogsServices _getCreateBlogsServices;
        public IGetCreateBlogsServices GetCreateBlogsServices
        {
            get
            {
                return _getCreateBlogsServices ??= new GetCreateBlogsServices(_context);
            }
        }
        
        
        private ICreateBlogsServices _createBlogsServices;
        public ICreateBlogsServices CreateBlogsServices
        {
            get
            {
                return _createBlogsServices ??= new CreateBlogsServices(_context,_environment);
            }
        }
        
        
        private IGetDetailsBlogsServices _getDetailsBlogsServices;
        public IGetDetailsBlogsServices GetDetailsBlogsServices
        {
            get
            {
                return _getDetailsBlogsServices ??= new GetDetailsBlogsServices(_context);
            }
        }
        
        
        private IGetEditBlogsServices _getEditBlogsServices;
        public IGetEditBlogsServices GetEditBlogsServices
        {
            get
            {
                return _getEditBlogsServices ??= new GetEditBlogsServices(_context);
            }
        }
        
        
        
        private IEditBlogsServices _editBlogsServices;
        public IEditBlogsServices EditBlogsServices
        {
            get
            {
                return _editBlogsServices ??= new EditBlogsServices(_context,_environment);
            }
        }
        
        
        private IDeleteBlogsServices _deleteBlogsServices;
        public IDeleteBlogsServices DeleteBlogsServices
        {
            get
            {
                return _deleteBlogsServices ??= new DeleteBlogsServices(_context,_environment);
            }
        }
        
        
        
        private IActiveBlogsServices _activeBlogsServices;
        public IActiveBlogsServices ActiveBlogsServices
        {
            get
            {
                return _activeBlogsServices ??= new ActiveBlogsServices(_context);
            }
        }
    }
}