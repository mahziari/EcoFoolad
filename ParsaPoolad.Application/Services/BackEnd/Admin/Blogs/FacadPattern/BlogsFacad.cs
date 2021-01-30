using Microsoft.AspNetCore.Hosting;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Application.Interfaces.FacadPatterns.BackEnd.Admin;
using ParsaPoolad.Application.Services.BackEnd.Admin.Blogs.Command;
using ParsaPoolad.Application.Services.BackEnd.Admin.Blogs.Queries;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Blogs.FacadPattern
{
    public class BlogsFacad : IBlogsFacad
    {
        
        private readonly IDataBaseContext _context;
        private readonly IWebHostEnvironment _environment;

        public BlogsFacad(IDataBaseContext context,IWebHostEnvironment environment)
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