using System;
using System.ComponentModel.DataAnnotations;

namespace EndPoint.WebSite.Areas.Auth.Data.Dto
{
    public class ForgotPasswordDto
    {
        [Display(Name = "شماره تلفن")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        [StringLength(11, ErrorMessage = "تعداد کاراکتر بیش از حد مجاز")]
        public String PhoneNumber { get; set; }

        [Display(Name = " کد تایید ارسال شده")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        [MaxLength(6, ErrorMessage = "تعداد کاراکتر بیش از حد مجاز")]
        [MinLength(6, ErrorMessage = "تعداد کاراکتر کمتر از حد مجاز")]
        public string Code { get; set; }

        [Display(Name = "رمز عبور جدید")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        [DataType(DataType.Password, ErrorMessage = "غیر مجاز")]
        [StringLength(30, ErrorMessage = "تعداد کاراکتر بیش از حد مجاز")]
        [MinLength(8, ErrorMessage = "تعداد رمز شما حداقل 8 کاراکتر باید باشد")]
        public String Password { get; set; }

        [Display(Name = "تکرار رمز عبور جدید ")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        [DataType(DataType.Password, ErrorMessage = "غیر مجاز")]
        [Compare(nameof(Password), ErrorMessage = "عدم مطابقت تکرار رمز عبور")]
        [StringLength(30, ErrorMessage = "تعداد کاراکتر بیش از حد مجاز")]
        [MinLength(8, ErrorMessage = "تعداد رمز شما حداقل 8 کاراکتر باید باشد")]
        public String ConfirmPassword { get; set; }

        public string token { get; set; }
        public int CounterTime { get; set; }
    }
}