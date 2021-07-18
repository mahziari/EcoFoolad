using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace  Application.Services.BackEnd.Admin.BlogsCategories.Command.CreateBlogsCategories
{
    public class CreateBlogsCategoriesServicesDto
    {

        [Display(Name = "نام دسته بندی بلاگ")]
        [Required(AllowEmptyStrings = false,ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string Name { get; set; }
        
        
        [Display(Name = "نام دسته بندی انگلسیس بلاگ")]
        [Required(AllowEmptyStrings = false,ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string Slug { get; set; }
        
        [Display(Name = "توضیح برای دسته بندی فارسی بلاگ")]
        [Required(AllowEmptyStrings = false,ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string SmallDescription { get; set; }
        
        [Display(Name = "رنگ دسته بندی بلاگ")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string Color { get; set; }
        
        [Display(Name = "آیکن دسته بندی بلاگ")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string FaIcon { get; set; }
        
        [Display(Name = "عکس دسته بندی بلاگ")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string ImageUrl { get; set; }
    }
}