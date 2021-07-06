using System;
using System.ComponentModel.DataAnnotations;

namespace EndPoint.WebSite.Areas.Auth.Data.Dto
{
    public class RegisterDto
    {
        public String UserName { get; set; }

        [Display(Name = "نام")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        [StringLength(50, ErrorMessage = "تعداد کاراکتر بیش از حد مجاز")]
        public String FirstName { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        [StringLength(50, ErrorMessage = "تعداد کاراکتر بیش از حد مجاز")]
        public String LastName { get; set; }

        [Display(Name = "شماره تلفن")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        [StringLength(11, ErrorMessage = "تعداد کاراکتر بیش از حد مجاز")]
        public String PhoneNumber { get; set; }
        
        [Display(Name = "آدرس ")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        [StringLength(1000, ErrorMessage = "تعداد کاراکتر بیش از حد مجاز")]
        public String Address { get; set; }

        [Display(Name = "رمز عبور ")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        [DataType(DataType.Password, ErrorMessage = "غیر مجاز")]
        [StringLength(30, ErrorMessage = "تعداد کاراکتر بیش از حد مجاز")]
        [MinLength(8, ErrorMessage = "تعداد رمز شما حداقل 8 کاراکتر باید باشد")]
        public String Password { get; set; }

        [Display(Name = "تکرار رمز عبور ")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        [DataType(DataType.Password, ErrorMessage = "غیر مجاز")]
        [Compare(nameof(Password), ErrorMessage = "عدم مطابقت تکرار رمز عبور")]
        [StringLength(30, ErrorMessage = "تعداد کاراکتر بیش از حد مجاز")]
        [MinLength(8, ErrorMessage = "تعداد رمز شما حداقل 8 کاراکتر باید باشد")]
        public String ConfirmPassword { get; set; }
        public bool RequestToBeOwner { get; set; }
    }
}