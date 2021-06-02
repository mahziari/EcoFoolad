using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.Web.Areas.Auth.Data.Dto
{
    public class ConfirmDto
    {
        [Display(Name = " کد تایید ارسال شده")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        [MaxLength(6, ErrorMessage = "تعداد کاراکتر بیش از حد مجاز")]
        [MinLength(6, ErrorMessage = "تعداد کاراکتر کمتر از حد مجاز")]
        public string Code { get; set; }

        public String PhoneNumber { get; set; }
    }
}