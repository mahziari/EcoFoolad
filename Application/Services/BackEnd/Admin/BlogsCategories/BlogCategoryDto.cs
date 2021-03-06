using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Application.Interfaces.Contexts;
using Domain.Entities;
using FluentValidation;

namespace Application.Services.BackEnd.Admin.BlogsCategories
{
    public class BlogCategoryDto
    {
        public int Id { get; set; }
        
        [Display(Name = "نام دسته بندی فارسی مجله")]
        [Required(AllowEmptyStrings = false,ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string Name { get; set; }
        
        
        [Display(Name = "نام دسته بندی انگلسیس مجله")]
        [Required(AllowEmptyStrings = false,ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string Slug { get; set; }
        
        [Display(Name = "توضیح برای دسته بندی مجله")]
        [Required(AllowEmptyStrings = false,ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string SmallDescription { get; set; }
        
        [Display(Name = "رنگ دسته بندی مجله")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string Color { get; set; }
        
        [Display(Name = "آیکن دسته بندی مجله")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string FaIcon { get; set; }
        
        [Display(Name = "لینک عکس دسته بندی مجله")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string ImageUrl { get; set; }
        public string LocalTime { get; set; }
        public string RegisterUserId { get; set; }
        public bool IsActive { get; set; }
    }
    
    public class BlogCategoryValidator : AbstractValidator<BlogCategoryDto>
    {
        private readonly ICustomDbContext _customDbContext;
        public BlogCategoryValidator(ICustomDbContext customDbContext)
        {
            _customDbContext = customDbContext;
            RuleFor(x => x.Name).Must(BeUniqueName).WithMessage("این نام دسته بندی قبلا استفاده شده است");
            RuleFor(x => x.Slug).Must(BeUniqueSlug).WithMessage("این نام انگلیسی دسته بندی قبلا استفاده شده است");
        }

        private bool BeUniqueName(string name)
        {
            var blogCategoriesName = _customDbContext.BlogCategories.FirstOrDefault(c => c.Name == name);
            return blogCategoriesName==null;
        }
        
        private bool BeUniqueSlug(string slug)
        {
            var blogCategoriesSlug = _customDbContext.BlogCategories.FirstOrDefault(c => c.Slug == slug);
            return blogCategoriesSlug==null;
        }
    }
}