 

using System.Collections.Generic;
using Application.Interfaces.Contexts;
using Application.Services.BackEnd.Admin.Company.Command;
using AutoMapper;
using Domain.Entities;
using Domain.Entities.Dtos;

namespace  Application.Services.BackEnd.Admin.Blogs.Command.ActiveBlogs
{
    public class ActiveBlogsServices : IActiveBlogsServices
    {
        private readonly ICustomDbContext _customDbContext;
        public ActiveBlogsServices(ICustomDbContext customDbContext)
        {
            _customDbContext = customDbContext;
        }

        public BaseDto Execute(int id)
        {
            var blog = _customDbContext.Blogs.Find(id);

            if (blog == null)
            {
                return new BaseDto
                (
                    true, 
                    new List<string> {"یافت نشد"}
                );
            }

            if (blog.IsVerified == false)
            {
                blog.IsVerified = true;  
            }
            else if(blog.IsVerified)
            {
                blog.IsVerified = false;
            }
            _customDbContext.SaveChanges();
            
            return new BaseDto
            (
                true,
                new List<string> {"تغییر وضعیت با موفقیت انجام شد"}
            );
        }

    }
}