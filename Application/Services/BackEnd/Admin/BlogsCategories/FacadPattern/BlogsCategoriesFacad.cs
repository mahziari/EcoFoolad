using Application.Interfaces.Contexts;
using Microsoft.AspNetCore.Hosting;
 
using  Application.Interfaces.FacadPatterns.BackEnd.Admin;
using  Application.Services.BackEnd.Admin.BlogsCategories.Command;
using  Application.Services.BackEnd.Admin.BlogsCategories.Command.ActiveBlogsCategories;
using  Application.Services.BackEnd.Admin.BlogsCategories.Command.CreateBlogsCategories;
using  Application.Services.BackEnd.Admin.BlogsCategories.Command.DeleteBlogsCategories;
using  Application.Services.BackEnd.Admin.BlogsCategories.Command.EditBlogsCategories;
using  Application.Services.BackEnd.Admin.BlogsCategories.Queries;
using  Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetCreateBlogsCategories;
using  Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetEditBlogsCategories;
using  Application.Services.BackEnd.Admin.BlogsCategories.Queries.GetIndexBlogsCategories;

namespace  Application.Services.BackEnd.Admin.BlogsCategories.FacadPattern
{
    public class BlogsCategoriesFacad : IBlogsCategoriesFacad
    {
        
        private readonly IIdealCrmDataBaseContext _context;

        public BlogsCategoriesFacad(IIdealCrmDataBaseContext context)
        {
            _context = context;
        }
        
        
        private IGetIndexBlogsCategoriesServices _getIndexBlogsCategoriesServices;
        public IGetIndexBlogsCategoriesServices GetIndexBlogsCategoriesServices
        {
            get
            {
                return _getIndexBlogsCategoriesServices ??= new GetIndexBlogsCategoriesServices(_context);
            }
        }
        
        
        
        private IGetCreateBlogsCategoriesServices _getCreateBlogsCategoriesServices;
        public IGetCreateBlogsCategoriesServices GetCreateBlogsCategoriesServices
        {
            get
            {
                return _getCreateBlogsCategoriesServices ??= new GetCreateBlogsCategoriesServices(_context);
            }
        }
        
        
        private ICreateBlogsCategoriesServices _createBlogsCategoriesServices;
        public ICreateBlogsCategoriesServices CreateBlogsCategoriesServices
        {
            get
            {
                return _createBlogsCategoriesServices ??= new CreateBlogsCategoriesServices(_context);
            }
        }
        
        
        private IGetEditBlogsCategoriesServices _getEditBlogsCategoriesServices;
        public IGetEditBlogsCategoriesServices GetEditBlogsCategoriesServices
        {
            get
            {
                return _getEditBlogsCategoriesServices ??= new GetEditBlogsCategoriesServices(_context);
            }
        }
        
        
        
        private IEditBlogsCategoriesServices _editBlogsCategoriesServices;
        public IEditBlogsCategoriesServices EditBlogsCategoriesServices
        {
            get
            {
                return _editBlogsCategoriesServices ??= new EditBlogsCategoriesServices(_context);
            }
        }
        
        
        private IDeleteBlogsCategoriesServices _deleteBlogsCategoriesServices;
        public IDeleteBlogsCategoriesServices DeleteBlogsCategoriesServices
        {
            get
            {
                return _deleteBlogsCategoriesServices ??= new DeleteBlogsCategoriesServices(_context);
            }
        }
        
        
        
        private IActiveBlogsCategoriesServices _activeBlogsCategoriesServices;
        public IActiveBlogsCategoriesServices ActiveBlogsCategoriesServices
        {
            get
            {
                return _activeBlogsCategoriesServices ??= new ActiveBlogsCategoriesServices(_context);
            }
        }
    }
}