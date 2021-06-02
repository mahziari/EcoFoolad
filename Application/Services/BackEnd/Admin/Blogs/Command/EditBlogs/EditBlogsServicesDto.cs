using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace  Application.Services.BackEnd.Admin.Blogs.Command.EditBlogs
{
    public class EditBlogsServicesDto
    {
        public int NewsId { get; set; }

        [Display(Name = "نوع بلاگ")]
        [Required(AllowEmptyStrings = false,ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public int NewsGroupId { get; set; }

        [Display(Name = "عنوان بلاگ")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        [StringLength(200, ErrorMessage = "تعداد کاراکتر بیش از حد مجاز")]
        public string Title { get; set; }

        [Display(Name = "توضیح کوتاه بلاگ")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string NewsSummery { get; set; }

        [Display(Name = "متن بلاگ")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string NewsBody { get; set; }
        
        [Display(Name = "تصویر بلاگ")]
        // [Required(ErrorMessage = "لطفا یک {0} انتخاب کنید")]
        [DataType(DataType.Upload)]
        public IFormFile Images { get; set; }
        public int Position { get; set; }
    }
}