using System.Collections.Generic;
using System.Linq;
using Application.Interfaces.Contexts;
using Application.Services.BackEnd.Admin.Blogs.Queries.GetCreateBlogs;
using AutoMapper;
using Domain.Entities;
using Domain.Entities.Dtos;
using Microsoft.EntityFrameworkCore;
 

namespace  Application.Services.BackEnd.Admin.Blogs.Queries.GetDetailsBlogs
{
    public class GetDetailsBlogsServices : IGetDetailsBlogsServices
    {
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;

        public GetDetailsBlogsServices(ICustomDbContext customDbContext, IMapper mapper)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
        }


        public BaseDto<BlogDto>  Execute(int id)
        {
            var blogModel = _customDbContext.Blogs
                .Include(s => s.BlogCategory)
                .Where(s => s.Id == id);
              
            var blog = _mapper.Map<BlogDto>(blogModel);

            return new BaseDto<BlogDto>
            (
                true,
                null,
                blog
            );
        }
    }
}