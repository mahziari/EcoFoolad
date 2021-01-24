using System;
using System.Linq;
using EndPoint.Web.Areas.Auth.Data.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ParsaPoolad.Common.Extentions;
using ParsaPoolad.Common.Services;
using ParsaPoolad.Domain.Entities.Identity;
using ParsaPoolad.Persistence.Contexts;


namespace EndPoint.Web.Areas.Auth.Controllers
{
    [Area("Auth")]
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IdentityDataBaseContext _identityContext;

        public AccountController(UserManager<User> userManager, RoleManager<Role> roleManager,
            SignInManager<User> signInManager,
            IdentityDataBaseContext identityContext)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _identityContext = identityContext;
        }

        [HttpGet]
        [Route("users/auth/checkout", Name = "checkout")]
        public IActionResult CheckOut(string returnUrl = "/")
        {
            return View(new CheckOutDto
            {
                ReturnUrl = Request.Headers["Referer"].ToString()
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("users/auth/checkout", Name = "checkout")]
        public IActionResult CheckOut(CheckOutDto checkOutDto)
        {
            if (!ModelState.IsValid)
            {
                return View(checkOutDto);
            }

            TempData["PhoneNumber"] = checkOutDto.PhoneNumber;
            TempData["ReturnUrl"] = checkOutDto.ReturnUrl;
            var user = _userManager.FindByNameAsync(checkOutDto.PhoneNumber).Result;
            if (user == null)
            {
                return RedirectToAction(nameof(Register));
            }

            var userConfirmed = _userManager.IsPhoneNumberConfirmedAsync(user).Result;
            if (userConfirmed == false)
            {
                var code = _userManager.GenerateChangePhoneNumberTokenAsync(user, checkOutDto.PhoneNumber).Result;
                SmsServices.SmsSend(checkOutDto.PhoneNumber, "ConfirmPhoneNumberSmsSend", code);
                return RedirectToAction(nameof(Confirm));
            }

            return RedirectToAction(nameof(Login));
        }


        [HttpGet]
        [Route("users/auth/register", Name = "register")]
        public IActionResult Register()
        {
            return View(new RegisterDto
            {
                PhoneNumber = TempData["PhoneNumber"].ToString(),
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("users/auth/register", Name = "register")]
        public IActionResult Register(RegisterDto registerDto)
        {
            if (ModelState.IsValid == false)
            {
                return View(registerDto);
            }

            if (registerDto.PhoneNumber == registerDto.Password)
            {
                TempData["ErrorChangePhoneNumberInRegister"] = "استفاده از شماره موبایل به عنوان رمز عبور غیر مجاز میباشد";
                RedirectToAction(nameof(Register));
            }

            var userAvalable = _userManager.FindByNameAsync(registerDto.PhoneNumber).Result;
            if (userAvalable != null)
            {
                TempData["AuthErrors"] = "شما شماره همراه خود را به صورت غیر مجاز تغییر داده اید";
                return RedirectToAction(nameof(Login));
            }

            User newUser = new User()
            {
                FirstName = registerDto.FirstName,
                LastName = registerDto.LastName,
                UserName = registerDto.PhoneNumber,
                PhoneNumber = registerDto.PhoneNumber,
                Address = registerDto.Address,
                IsActive = true
            };
            var result = _userManager.CreateAsync(newUser, registerDto.Password).Result;
            if (result.Succeeded)
            {
                var user = _userManager.FindByNameAsync(registerDto.PhoneNumber).Result;


                // Add Role User To Users
                var roles = _roleManager.Roles.FirstOrDefault(r => r.Name == "SeniorProgrammer");
                _userManager.AddToRoleAsync(user, roles.Name);

                var code = _userManager.GenerateChangePhoneNumberTokenAsync(user, registerDto.PhoneNumber).Result;
                SmsServices.SmsSend(registerDto.PhoneNumber, "ConfirmPhoneNumberSmsSend", code);

                TempData["PhoneNumber"] = registerDto.PhoneNumber;
                return RedirectToAction(nameof(Confirm));
            }

            String message = "";
            foreach (var item in result.Errors.ToList())
            {
                message += item.Description + Environment.NewLine;
            }

            TempData["AuthErrors"] = message;

            return View(registerDto);
        }

        [HttpGet]
        [Route("users/auth/confirm-phone-number", Name = "confirm-phone-number")]
        public IActionResult Confirm()
        {
            return View(new ConfirmDto
            {
                PhoneNumber = TempData["PhoneNumber"].ToString(),
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("users/auth/confirm-phone-number", Name = "confirm-phone-number")]
        public IActionResult Confirm(ConfirmDto confirmDto)
        {
            TempData["PhoneNumber"] = confirmDto.PhoneNumber;

            if (ModelState.IsValid == false)
            {
                return View(confirmDto);
            }

            var user = _userManager.FindByNameAsync(confirmDto.PhoneNumber).Result;
            bool resultVerify = _userManager
                .VerifyChangePhoneNumberTokenAsync(user, confirmDto.Code, confirmDto.PhoneNumber)
                .Result;

            if (resultVerify == false)
            {
                TempData["ErrorVerifyPhoneNumber"] = "کد وارد شده اشتباه است";
                return View(confirmDto);
            }

            // user.PhoneNumberConfirmed=true;
            // _userManager.UpdateAsync(user);
            var userConfirm = _identityContext.Users.FirstOrDefault(u => u.UserName == confirmDto.PhoneNumber);
            userConfirm.PhoneNumberConfirmed = true;
            _identityContext.SaveChanges();
            TempData["AuthSuccess"] = "ثبت نام شما با موفقیت انجام شد";

            //Send Success Sms
            var firstName = user.FirstName.FixPersianChars();
            var lastName = user.LastName.FixPersianChars();
            SmsServices.SmsSend(confirmDto.PhoneNumber, "SuccessRegister", firstName, lastName, confirmDto.PhoneNumber);

            return RedirectToAction(nameof(SignUpSuccessfully));
        }


        [HttpGet]
        [Route("users/auth/login", Name = "login")]
        public IActionResult Login()
        {
            return View(new LoginDto
            {
                ReturnUrl = TempData["ReturnUrl"].ToString(),
                UserName = TempData["PhoneNumber"].ToString()
            });
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("users/auth/login", Name = "login")]
        public IActionResult Login(LoginDto loginDto)
        {
            if (!ModelState.IsValid)
            {
                return View(loginDto);
            }

            var user = _userManager.FindByNameAsync(loginDto.UserName).Result;

            // if (user == null)
            // {
            //     TempData["AuthSuccess"] = "کاربری با این شماره تلفن وجود ندارد";
            //     return View(loginDto);
            // }

            _signInManager.SignOutAsync();


            var result = _signInManager
                .PasswordSignInAsync(user, loginDto.Password, false, true)
                .Result;

            if (result.Succeeded)
            {
                return Redirect(loginDto.ReturnUrl);
            }

            if (result.RequiresTwoFactor)
            {
                //return to two factor
            }

            if (result.IsLockedOut)
            {
                // redirect to page lock or
            }

            ModelState.AddModelError(string.Empty, "رمز نادرست است");

            return View(loginDto);
        }


        [HttpGet]
        [Route("users/auth/logout", Name = "logout")]
        public IActionResult LogOut()
        {
            _signInManager.SignOutAsync();
            return RedirectToAction("index", "Home");
        }


        [HttpGet]
        [Route("users/auth/sign-up-successfully", Name = "SignUpSuccessfully")]
        public IActionResult SignUpSuccessfully()
        {
            return View();
        }


        [HttpPost]
        [Route("users/auth/forgot-password-sms-send-code", Name = "forgotPasswordSmsSendCode")]
        public IActionResult ForgotPasswordSendSmsCode(string UserName)
        {
            var user = _userManager.FindByNameAsync(UserName).Result;
            var code = _userManager.GenerateChangePhoneNumberTokenAsync(user, UserName).Result;
            SmsServices.SmsSend(UserName, "ForgotPasswordSmsSend", code);

            TempData["PhoneNumber"] = UserName;
            return RedirectToAction(nameof(ForgotPassword));
        }

        [HttpGet]
        [Route("users/auth/forgot-password", Name = "forgotPassword")]
        public IActionResult ForgotPassword()
        {
            var phoneNumber = TempData["PhoneNumber"].ToString();
            var user = _userManager.FindByNameAsync(phoneNumber).Result;
            string token = _userManager.GeneratePasswordResetTokenAsync(user).Result;

            return View(new ForgotPasswordDto
            {
                PhoneNumber = TempData["PhoneNumber"].ToString(),
                token = token
            });
        }

        [HttpPost]
        [Route("users/auth/forgot-password", Name = "forgotPassword")]
        public IActionResult ForgotPassword(ForgotPasswordDto forgotPasswordDto)
        {
            if (ModelState.IsValid == false)
            {
                return View(forgotPasswordDto);
            }

            var user = _userManager.FindByNameAsync(forgotPasswordDto.PhoneNumber).Result;
            var resultConfirm = _userManager.IsPhoneNumberConfirmedAsync(user).Result;
            if (resultConfirm == false)
            {
                TempData["AuthErrors"] = "شما حساب کاربری خود را تایید نکرده اید";
                return RedirectToAction(nameof(CheckOut));
            }

            bool resultVerify = _userManager
                .VerifyChangePhoneNumberTokenAsync(user, forgotPasswordDto.Code, forgotPasswordDto.PhoneNumber)
                .Result;

            if (resultVerify == false)
            {
                TempData["ErrorVerifyPhoneNumber"] = "کد وارد شده اشتباه است";
                return View(forgotPasswordDto);
            }


            var result = _userManager
                .ResetPasswordAsync(user, forgotPasswordDto.token, forgotPasswordDto.Password)
                .Result;
            if (result.Succeeded)
            {
                //Send Success Sms

                var firstName = user.FirstName.FixPersianChars();
                var lastName = user.LastName.FixPersianChars();
                SmsServices.SmsSend(forgotPasswordDto.PhoneNumber, "SuccessChangePassword", firstName, lastName,
                    forgotPasswordDto.PhoneNumber);


                TempData["PhoneNumber"] = forgotPasswordDto.PhoneNumber;
                TempData["SuccessChangePassword"] = "رمز عبور شما با موفقیت ویرایش شد";
                return RedirectToAction(nameof(Login));
            }
            else
            {
                TempData["ForgotPasswordErrors"] = result.Errors;
                return View(forgotPasswordDto);
            }
        }


        [HttpPost]
        [Route("users/auth/again-sms-send", Name = "AgainSmsSend")]
        public IActionResult AgainSmsSend(ConfirmDto confirmDto)
        {
            var user = _userManager.FindByNameAsync(confirmDto.PhoneNumber).Result;
            var code = _userManager.GenerateChangePhoneNumberTokenAsync(user, confirmDto.PhoneNumber).Result;
            SmsServices.SmsSend(confirmDto.PhoneNumber, "ConfirmPhoneNumberSmsSend", code);

            TempData["PhoneNumber"] = confirmDto.PhoneNumber;
            return RedirectToAction(nameof(Confirm));
        }


        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}