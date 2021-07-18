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
using AutoMapper;
using Microsoft.AspNetCore.Http;

namespace  Application.Services.BackEnd.Admin.BlogsCategories.FacadPattern
{
    public class BlogsCategoriesFacad : IBlogsCategoriesFacad
    {
        
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContext;

        public BlogsCategoriesFacad(ICustomDbContext customDbContext, IMapper mapper, IHttpContextAccessor httpContext)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
            _httpContext = httpContext;
        }
        
        
        private IGetIndexBlogsCategoriesServices _getIndexBlogsCategoriesServices;
        public IGetIndexBlogsCategoriesServices GetIndexBlogsCategoriesServices
        {
            get
            {
                return _getIndexBlogsCategoriesServices ??= new GetIndexBlogsCategoriesServices(_customDbContext,_mapper);
            }
        }
        
        
        
        private IGetCreateBlogsCategoriesServices _getCreateBlogsCategoriesServices;
        public IGetCreateBlogsCategoriesServices GetCreateBlogsCategoriesServices
        {
            get
            {
                return _getCreateBlogsCategoriesServices ??= new GetCreateBlogsCategoriesServices(_customDbContext);
            }
        }
        
        
        private ICreateBlogsCategoriesServices _createBlogsCategoriesServices;
        public ICreateBlogsCategoriesServices CreateBlogsCategoriesServices
        {
            get
            {
                return _createBlogsCategoriesServices ??= new CreateBlogsCategoriesServices(_customDbContext,_mapper,_httpContext);
            }
        }
        
        
        private IGetEditBlogsCategoriesServices _getEditBlogsCategoriesServices;
        public IGetEditBlogsCategoriesServices GetEditBlogsCategoriesServices
        {
            get
            {
                return _getEditBlogsCategoriesServices ??= new GetEditBlogsCategoriesServices(_customDbContext,_mapper);
            }
        }
        
        
        
        private IEditBlogsCategoriesServices _editBlogsCategoriesServices;
        public IEditBlogsCategoriesServices EditBlogsCategoriesServices
        {
            get
            {
                return _editBlogsCategoriesServices ??= new EditBlogsCategoriesServices(_customDbContext,_mapper);
            }
        }
        
        
        private IDeleteBlogsCategoriesServices _deleteBlogsCategoriesServices;
        public IDeleteBlogsCategoriesServices DeleteBlogsCategoriesServices
        {
            get
            {
                return _deleteBlogsCategoriesServices ??= new DeleteBlogsCategoriesServices(_customDbContext);
            }
        }
        
        
        
        private IActiveBlogsCategoriesServices _activeBlogsCategoriesServices;
        public IActiveBlogsCategoriesServices ActiveBlogsCategoriesServices
        {
            get
            {
                return _activeBlogsCategoriesServices ??= new ActiveBlogsCategoriesServices(_customDbContext);
            }
        }
    }
}