using Application.Interfaces.Contexts;
using Microsoft.AspNetCore.Hosting;
using Application.Interfaces.FacadPatterns.BackEnd.Admin;
using Application.Services.BackEnd.Admin.Blogs.Command.ActiveBlogs;
using Application.Services.BackEnd.Admin.Blogs.Command.CreateBlogs;
using Application.Services.BackEnd.Admin.Blogs.Command.DeleteBlogs;
using Application.Services.BackEnd.Admin.Blogs.Command.EditBlogs;
using Application.Services.BackEnd.Admin.Blogs.Queries.GetCreateBlogs;
using Application.Services.BackEnd.Admin.Blogs.Queries.GetDetailsBlogs;
using Application.Services.BackEnd.Admin.Blogs.Queries.GetEditBlogs;
using Application.Services.BackEnd.Admin.Blogs.Queries.GetIndexBlogs;
using AutoMapper;
using Microsoft.AspNetCore.Http;

namespace Application.Services.BackEnd.Admin.Blogs.FacadPattern
{
    public class BlogsFacad : IBlogsFacad
    {
        private readonly IWebHostEnvironment _environment;
        private readonly IMapper _mapper;
        private readonly ICustomDbContext _customDbContext;
        private readonly IHttpContextAccessor _httpContext;


        public BlogsFacad(IWebHostEnvironment environment, IMapper mapper, ICustomDbContext customDbContext, IHttpContextAccessor httpContext)
        {
            _environment = environment;
            _mapper = mapper;
            _customDbContext = customDbContext;
            _httpContext = httpContext;
        }


        private IGetIndexBlogsServices _getIndexBlogsServices;

        public IGetIndexBlogsServices GetIndexBlogsServices
        {
            get { return _getIndexBlogsServices ??= new GetIndexBlogsServices(_customDbContext,_mapper); }
        }


        private IGetCreateBlogsServices _getCreateBlogsServices;

        public IGetCreateBlogsServices GetCreateBlogsServices
        {
            get { return _getCreateBlogsServices ??= new GetCreateBlogsServices(_customDbContext); }
        }


        private ICreateBlogsServices _createBlogsServices;

        public ICreateBlogsServices CreateBlogsServices
        {
            get { return _createBlogsServices ??= new CreateBlogsServices(_environment, _mapper, _customDbContext,_httpContext); }
        }


        private IGetDetailsBlogsServices _getDetailsBlogsServices;

        public IGetDetailsBlogsServices GetDetailsBlogsServices
        {
            get { return _getDetailsBlogsServices ??= new GetDetailsBlogsServices(_customDbContext,_mapper); }
        }


        private IGetEditBlogsServices _getEditBlogsServices;

        public IGetEditBlogsServices GetEditBlogsServices
        {
            get { return _getEditBlogsServices ??= new GetEditBlogsServices(_customDbContext,_mapper); }
        }


        private IEditBlogsServices _editBlogsServices;

        public IEditBlogsServices EditBlogsServices
        {
            get { return _editBlogsServices ??= new EditBlogsServices(_environment, _mapper, _customDbContext); }
        }


        private IDeleteBlogsServices _deleteBlogsServices;

        public IDeleteBlogsServices DeleteBlogsServices
        {
            get { return _deleteBlogsServices ??= new DeleteBlogsServices(_environment, _mapper, _customDbContext); }
        }


        private IActiveBlogsServices _activeBlogsServices;

        public IActiveBlogsServices ActiveBlogsServices
        {
            get { return _activeBlogsServices ??= new ActiveBlogsServices(_customDbContext); }
        }
    }
}