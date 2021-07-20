﻿using System.ComponentModel.DataAnnotations;

namespace Application.Services.BackEnd.Admin.BlogsCategories
{
    public class BlogCategoryDto
    {
        public int Id { get; set; }
        
        [Display(Name = "نام دسته بندی فارسی بلاگ")]
        [Required(AllowEmptyStrings = false,ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string Name { get; set; }
        
        
        [Display(Name = "نام دسته بندی انگلسیس بلاگ")]
        [Required(AllowEmptyStrings = false,ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string Slug { get; set; }
        
        [Display(Name = "توضیح برای دسته بندی بلاگ")]
        [Required(AllowEmptyStrings = false,ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string SmallDescription { get; set; }
        
        [Display(Name = "رنگ دسته بندی بلاگ")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string Color { get; set; }
        
        [Display(Name = "آیکن دسته بندی بلاگ")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string FaIcon { get; set; }
        
        [Display(Name = "لینک عکس دسته بندی بلاگ")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string ImageUrl { get; set; }
        public string LocalTime { get; set; }
        public string RegisterUserId { get; set; }
        public bool IsActive { get; set; }
    }
}