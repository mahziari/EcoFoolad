using System;
using System.ComponentModel.DataAnnotations;

namespace EndPoint.WebSite.Areas.Auth.Data.Dto
{
    public class CheckOutDto
    {
        [Display(Name = "شماره موبایل")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        [StringLength(11, ErrorMessage = "تعداد کاراکتر بیش از حد مجاز")]
        [MinLength(11, ErrorMessage = "حداقل تعداد شماره تلفن 11 کاراکتر")]
        [MaxLength(11, ErrorMessage = "حداکثر تعداد شماره تلفن 11 کاراکتر")]
        [RegularExpression(@"(\+98|0)?09\d{9}", ErrorMessage = "فرمت شماره تلفن نامعتبر است")]
        public String PhoneNumber { get; set; }
        public String ReturnUrl { get; set; }
    }
}