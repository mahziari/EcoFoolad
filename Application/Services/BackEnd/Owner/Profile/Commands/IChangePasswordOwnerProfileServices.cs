using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Application.Interfaces.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
 
using  Domain.Entities;
using Domain.Entities.Users;

namespace  Application.Services.BackEnd.Owner.Profile.Commands
{
    public interface IChangePasswordOwnerProfileServices
    {
        ResultChangePasswordOwnerProfileDto Execute(ChangePasswordOwnerProfileDto changePasswordOwnerProfileDto,string PhoneNumber);
    }

    public class ChangePasswordOwnerProfileServices:IChangePasswordOwnerProfileServices
    {
        
        private readonly IIdealCrmDataBaseContext _context;
        private readonly IHttpContextAccessor _httpContext;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public ChangePasswordOwnerProfileServices(IIdealCrmDataBaseContext context, IHttpContextAccessor httpContext, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _context = context;
            _httpContext = httpContext;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public ResultChangePasswordOwnerProfileDto Execute(ChangePasswordOwnerProfileDto changePasswordOwnerProfileDto,string PhoneNumber)
        {
           
            var user = _userManager.FindByNameAsync(changePasswordOwnerProfileDto.PhoneNumber).Result;
            var result = _userManager
                .ChangePasswordAsync(user, changePasswordOwnerProfileDto.CurrentPassword,changePasswordOwnerProfileDto.Password)
                .Result;
            
            if (result.Succeeded)
            {
                // //Send Success Sms
                // var firstName = user.FirstName.FixPersianChars();
                // var lastName = user.LastName.FixPersianChars();
                // SmsServices.SmsSend(changePasswordOwnerProfileDto.PhoneNumber, "SuccessChangePassword", firstName, lastName,
                //     changePasswordOwnerProfileDto.PhoneNumber);
                _signInManager.SignOutAsync();
                return new ResultChangePasswordOwnerProfileDto
                {
                    IsSuccess = true,
                    Message = "رمز عبور شما با موفقیت ویرایش شد"
                };
            }
            
            var message = "";
            foreach (var item in result.Errors.ToList())
            {
                message += item.Description + Environment.NewLine;
            }
            return new ResultChangePasswordOwnerProfileDto
            {
                IsSuccess = false,
                Message = message
            };
        }
    }
    
    public class ResultChangePasswordOwnerProfileDto
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
    
    public class ChangePasswordOwnerProfileDto
    {
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
    }
}