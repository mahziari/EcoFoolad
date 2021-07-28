﻿using Application.Interfaces.Contexts;
 
using  Application.Interfaces.FacadPatterns.FrontEnd;
using  Application.Services.FrontEnd.Blogs.Queries;
using AutoMapper;

namespace  Application.Services.FrontEnd.Blogs.FacadPattern
{
    public class BlogsFrontEndFacad: IBlogsFrontEndFacad
    {
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;

        public BlogsFrontEndFacad(ICustomDbContext customDbContext, IMapper mapper)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
        }
        
        private IGetBlogsFrontEndService _getBlogsFrontEndService;
        public IGetBlogsFrontEndService GetBlogsFrontEndService
        {
            get
            {
                return _getBlogsFrontEndService ??= new GetBlogsFrontEndService(_customDbContext,_mapper);
            }
        }
        
        
        private IGetAllBlogsFrontEndService _getAllBlogsFrontEndService;
        public IGetAllBlogsFrontEndService GetAllBlogsFrontEndService
        {
            get
            {
                return _getAllBlogsFrontEndService ??= new GetAllBlogsFrontEndService(_customDbContext,_mapper);
            }
        }
        
        
        private IGetBlogsDetailsFrontEndService _getBlogsDetailsFrontEndService;
        public IGetBlogsDetailsFrontEndService GetBlogsDetailsFrontEndService
        {
            get
            {
                return _getBlogsDetailsFrontEndService ??= new GetBlogsDetailsFrontEndService(_customDbContext,_mapper);
            }
        }
        
        
        
        private IGetBlogsCategoryFrontEndService _getBlogsCategoryFrontEndService;
        public IGetBlogsCategoryFrontEndService GetBlogsCategoryFrontEndService
        {
            get
            {
                return _getBlogsCategoryFrontEndService ??= new GetBlogsCategoryFrontEndService(_customDbContext,_mapper);
            }
        }
    }
}