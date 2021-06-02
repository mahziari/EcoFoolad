using System.ComponentModel.DataAnnotations;

namespace  Application.Services.BackEnd.Admin.BlogsCategories.Command.CreateBlogsCategories
{
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