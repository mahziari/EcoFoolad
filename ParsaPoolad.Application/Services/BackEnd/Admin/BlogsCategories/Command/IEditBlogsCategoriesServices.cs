using System;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
// using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Domain.Entities;
using static Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.BlogsCategories.Command
{
    public interface IEditBlogsCategoriesServices
    {
        ResultEditBlogsCategoriesDto Execute(CreateBlogsCategoriesServicesDto createBlogsCategoriesServicesDto,CrmCmsNewsGroups crmCmsNewsGroups,int id);
    }

    public class EditBlogsCategoriesServices:IEditBlogsCategoriesServices {
        private readonly IDataBaseContext _context;

        public EditBlogsCategoriesServices(IDataBaseContext context )
        {
            _context = context;
        }

        public ResultEditBlogsCategoriesDto Execute(CreateBlogsCategoriesServicesDto createBlogsCategoriesServicesDto,CrmCmsNewsGroups crmCmsNewsGroups,int id)
        {
            
            var blogCategory = _context.CrmCmsNewsGroups.Find(id);
            
            blogCategory.GroupName = createBlogsCategoriesServicesDto.GroupName;
            blogCategory.Color = createBlogsCategoriesServicesDto.Color;
            blogCategory.FaIcon = createBlogsCategoriesServicesDto.FaIcon;
            _context.SaveChanges();

            return new ResultEditBlogsCategoriesDto
            {
                IsSuccess = true,
                Message = "دسته بندی بلاگ با موفقیت ویرایش شد"
            };
        }
    }

    public class ResultEditBlogsCategoriesDto
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }


}