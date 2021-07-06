using System;
using System.ComponentModel.DataAnnotations;

namespace EndPoint.WebSite.Areas.Auth.Data.Dto
{
    public class LoginDto
    {
        [Display(Name = "نام کاربری(شماره تلفن)")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        [StringLength(11, ErrorMessage = "تعداد کاراکتر بیش از حد مجاز")]
        [RegularExpression(@"(\+98|0)?09\d{9}", ErrorMessage = "فرمت شماره تلفن نامعتبر است")]
        public String UserName { get; set; }

        [Display(Name = "رمز عبور ")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        [DataType(DataType.Password, ErrorMessage = "غیر مجاز")]
        [StringLength(30, ErrorMessage = "تعداد کاراکتر بیش از حد مجاز")]
        [MinLength(8, ErrorMessage = "تعداد رمز شما حداقل 8 کاراکتر باید باشد")]
        public String Password { get; set; }

        public String ReturnUrl { get; set; }
    }
}