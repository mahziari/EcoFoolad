using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Application.Interfaces.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
 
using  Domain.Entities;
using Domain.Entities.Users;


namespace  Application.Services.BackEnd.Owner.Profile.Queries
{
    public interface IGetIndexChangePasswordOwnerProfileServices
    {
        ResultGetIndexChangePasswordOwnerProfileDto Execute(string phoneNumber);
    }

    public class GetIndexChangePasswordOwnerProfileServices : IGetIndexChangePasswordOwnerProfileServices
    {
        private readonly IIdealCrmDataBaseContext _context;
        private readonly IHttpContextAccessor _httpContext;
        private readonly UserManager<Domain.Entities.Users.User> _userManager;
        public GetIndexChangePasswordOwnerProfileServices(IIdealCrmDataBaseContext context, IHttpContextAccessor httpContext, UserManager<Domain.Entities.Users.User> userManager)
        {
            _context = context;
            _httpContext = httpContext;
            _userManager = userManager;
        }


        public ResultGetIndexChangePasswordOwnerProfileDto Execute(string phoneNumber)
        {
            var user =  _userManager.GetUserAsync(_httpContext.HttpContext?.User).Result;

            return new ResultGetIndexChangePasswordOwnerProfileDto
            {
               User=user
            };
        }
    }

    public class ResultGetIndexChangePasswordOwnerProfileDto
    {
        public Domain.Entities.Users.User User { get; set; }
        public string PhoneNumber { get; set; }

        [Display(Name = "رمز عبور قبلی")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        [DataType(DataType.Password, ErrorMessage = "غیر مجاز")]
        [StringLength(30, ErrorMessage = "تعداد کاراکتر بیش از حد مجاز")]
        [MinLength(8, ErrorMessage = "تعداد رمز شما حداقل 8 کاراکتر باید باشد")]
        public String CurrentPassword { get; set; }
        
        
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
        
        public string token { get; set; }

    }
    
}