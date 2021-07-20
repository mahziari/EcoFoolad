using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.Entities.Blogs;
using Microsoft.AspNetCore.Http;

namespace Application.Services.BackEnd.Admin.Blogs
{
    public class BlogDto
    {
        public int Id { get; set; }
        [Display(Name = "نوع بلاگ")]
        [Required(AllowEmptyStrings = false,ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public int BlogCategoryId { get; set; }

        [Display(Name = "عنوان بلاگ")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        [StringLength(200, ErrorMessage = "تعداد کاراکتر بیش از حد مجاز")]
        public string Title { get; set; }

        [Display(Name = "توضیح کوتاه بلاگ")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string SmallDescription { get; set; }

        [Display(Name = "متن بلاگ")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string Body { get; set; }
        
        [Display(Name = "تصویر بلاگ")]
        // [Required(ErrorMessage = "لطفا یک {0} انتخاب کنید")]
        [DataType(DataType.Upload)]
        // [FileExtensions(Extensions = ".png,.jpg,.jpeg,.gif", ErrorMessage = "فرمت عکس نامعتبر است")]
        public IFormFile Image { get; set; }
        public int Position { get; set; }
        public bool RequestToAuthorFav { get; set; }
        public bool IsVerified { get; set; }
        public string ImageUrl { get; set; }
        public string LocalTime { get; set; }
        public string RegisterUserId { get; set; }
        public string Author { get; set; }
        public BlogCategory BlogCategory { get; set; }
    }
}