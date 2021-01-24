using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Application.Services.BackEnd.Admin.Sliders.Commands;
using ParsaPoolad.Domain.Entities;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.BlogsCategories.Command
{
    public interface ICreateBlogsCategoriesServices
    {
        ResultCreateBlogsCategoriesDto Execute(CreateBlogsCategoriesServicesDto createBlogsCategoriesServicesDto);
    }

    public class CreateBlogsCategoriesServices : ICreateBlogsCategoriesServices
    {

        private readonly IDataBaseContext _context;
        public CreateBlogsCategoriesServices(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultCreateBlogsCategoriesDto Execute(CreateBlogsCategoriesServicesDto createBlogsCategoriesServicesDto)
        {
            
            var blogs = new CrmCmsNewsGroups()
            {
                GroupName=createBlogsCategoriesServicesDto.GroupName,
                en_GroupName=createBlogsCategoriesServicesDto.en_GroupName,
                Color = createBlogsCategoriesServicesDto.Color,
                FaIcon = createBlogsCategoriesServicesDto.FaIcon,
                IsActive = true,
                UserId = 57,
                Month1 = 6,
                FirstRegisterUserId = 57,
                FirstRegisterDate = DateTime.Now,
                FirstRegisterDatePersian = PersianDateTime.Now.ToString("yyyyMMdd"),
                RegisterDate = DateTime.Now,
                RegisterDatePersian = PersianDateTime.Now.ToString("yyyyMMdd"),
                AppType = "web",
                LanguageId = 1065
            };

            _context.CrmCmsNewsGroups.Add(blogs);
            _context.SaveChanges();

            return new ResultCreateBlogsCategoriesDto
            {
                IsSuccess = true,
                Message = "بلاگ با موفقیت اضافه شد"
            };

        }
    }


    public class ResultCreateBlogsCategoriesDto
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }

    public class CreateBlogsCategoriesServicesDto
    {

        [Display(Name = "نام دسته بندی بلاگ")]
        [Required(AllowEmptyStrings = false,ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string GroupName { get; set; }
        
        
        [Display(Name = "نام دسته بندی انگلسیس بلاگ")]
        [Required(AllowEmptyStrings = false,ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string en_GroupName { get; set; }
        
        [Display(Name = "رنگ دسته بندی بلاگ")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string Color { get; set; }
        
        [Display(Name = "آیکن دسته بندی بلاگ")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string FaIcon { get; set; }
    }
}