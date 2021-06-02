﻿using System;
using System.Linq;
using Application.Services.FrontEnd.Carts;
using Common.Extentions;
using Common.Utilities;
using Domain.Entities.IdealCrm;
using Domain.Entities.Users;
using EndPoint.Web.Areas.Auth.Data.Dto;
using EndPoint.WebSite.Utilities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Persistence.Contexts;

namespace EndPoint.WebSite.Areas.Auth.Controllers
{
    [Area("Auth")]
    public class AuthController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IdealCrmDataBaseContext _idealCrmDataBaseContext;
        private readonly ILogger _logger;
        private readonly CookiesManeger _cookiesManeger ;
        private readonly ICartFrontEndService _cartFrontEndService;

        public AuthController(UserManager<User> userManager, RoleManager<Role> roleManager,
            SignInManager<User> signInManager,
            ILoggerFactory logger, IdealCrmDataBaseContext idealCrmDataBaseContext, CookiesManeger cookiesManeger, ICartFrontEndService cartFrontEndService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _idealCrmDataBaseContext = idealCrmDataBaseContext;
            _cookiesManeger = cookiesManeger;
            _cartFrontEndService = cartFrontEndService;
            _logger = logger.CreateLogger("Account");
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
                SendSms.VerifySmsSend(checkOutDto.PhoneNumber, "ConfirmPhoneNumberSmsSend", code);
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
                TempData["ErrorChangePhoneNumberInRegister"] =
                    "استفاده از شماره موبایل به عنوان رمز عبور غیر مجاز میباشد";
                RedirectToAction(nameof(Register));
            }

            var userAvalable = _userManager.FindByNameAsync(registerDto.PhoneNumber).Result;
            if (userAvalable != null)
            {
                _logger.LogInformation(LogEvents.LogInformationComplete, "RegisterAuthErrors");
                TempData["AuthErrors"] = "شما شماره همراه خود را به صورت غیر مجاز تغییر داده اید";
                return RedirectToAction(nameof(Login));
            }

            long latestUserId = _idealCrmDataBaseContext.Users.Select(u => u.UserId).Max();
            

            User newUser = new User
            {
                CrmUsersId = (int) (latestUserId+1),
                FirstName = registerDto.FirstName,
                LastName = registerDto.LastName,
                UserName = registerDto.PhoneNumber,
                PhoneNumber = registerDto.PhoneNumber,
                Address = registerDto.Address,
                DataCreated =  PersianDateTime.Now.ToDateTime(),
                IsActive = true,
                RequestToBeOwner=registerDto.RequestToBeOwner
            };

            var result = _userManager.CreateAsync(newUser, registerDto.Password).Result;
            if (result.Succeeded)
            {
                
               
                // This Code, Add User To IdealCrm Users table DataBase
                Users nweUsers = new Users()
                {
                    Fname = registerDto.FirstName,
                    Lname = registerDto.LastName,
                    UserName = registerDto.PhoneNumber,
                    Password = PasswordHash.GetMd5Hash(registerDto.Password),
                    IsAdmin = "827ccb0eea8a706c4c34a16891f84e7b",
                    IsActive = true,
                    UserId1 = null,
                    Month1 = 5,
                    RegisterDate =  DateTime.Now,
                    RegisterDatePersian =  PersianDateTime.Now.ToString("yyyyMMdd"),
                    AppType = "EcoFooladWeb",
                    LanguageId = 1065,
                    FirstRegisterUserId = (int) (latestUserId+1),
                    FirstRegisterDatePersian =  PersianDateTime.Now.ToString("yyyyMMdd"),
                    FirstRegisterDate =  DateTime.Now,
                    UserIsActiveInWinApp = true,
                    UserIsActiveInWebApp = true,
                    MobAppBaseInfoNeedUpdate = true,
                    MobAppBaseInfoNeedUpdateDetail = "Users,UserLanguages,CrmLinkedUsers,UsersPermission,CrmCompanyTitle,CrmCompanyPresentation,CrmPersonJobs,CrmProjectTitles,CrmConversationStatus,CrmsysRollPermission,CrmConversationStatusGroups,CrmConversationDefaultContext,CrmCompanyGroups,CrmCompanySubGroups,CrmCompanyType,WSProductFirstGroup,WSProductSecondGroup,WSProductUnits,WSProducts,WSOrderPaymentTypes,"
                };
                _idealCrmDataBaseContext.Users.Add(nweUsers);
                _idealCrmDataBaseContext.SaveChanges();

                

                // This Code, Add User To IdealCrm Company table DataBase
                var newCrmCompany = new CrmCompany()
                {
                    ImportDate = PersianDateTime.Now.ToString("yyyyMMdd"),
                    CmpName = registerDto.FirstName+' '+registerDto.LastName,
                    UserId = 57,
                    Year1 = 1,
                    Month1 = 7,
                    RegisterDate = DateTime.Now,
                    RegisterDatePersian =  PersianDateTime.Now.ToString("yyyyMMdd"),
                    AddType = 1,
                    CmpReferUserId =  57,
                    CrmUsersId=(int?) (latestUserId+1),
                    CmpMobile = registerDto.PhoneNumber
                };
                _idealCrmDataBaseContext.CrmCompany.Add(newCrmCompany);
                _idealCrmDataBaseContext.SaveChanges();

                
                
                
                
                var user = _userManager.FindByNameAsync(registerDto.PhoneNumber).Result;
                // Find Role User
                var roles = _roleManager.Roles.FirstOrDefault(r => r.Name == "User");
                if (roles == null)
                {
                    // Delete User If User Role is Unavailable
                    _userManager.DeleteAsync(user);
                    TempData["AuthErrors"] = "مشکلی در ثبت نام بوجود آمده است, لطفا با پشتیبانی تماس بگیرید.";
                    return View(registerDto);
                }
                // Add Role User To Registered Users
                var addToRole =_userManager.AddToRoleAsync(user, roles.Name).Result;
                var currentRole = _roleManager.FindByNameAsync(roles.Name).Result;
                var claimsRole = _roleManager.GetClaimsAsync(currentRole).Result;
                // addClaimsToUser
                var addClaims = _userManager.AddClaimsAsync(user, claimsRole).Result;
             

                var code = _userManager.GenerateChangePhoneNumberTokenAsync(user, registerDto.PhoneNumber).Result;
                SendSms.VerifySmsSend(registerDto.PhoneNumber, "ConfirmPhoneNumberSmsSend", code);

                TempData["PhoneNumber"] = registerDto.PhoneNumber;
                return RedirectToAction(nameof(Confirm));
            }

            var message = "";
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
                _logger.LogInformation(LogEvents.LogInformationComplete, "ConfirmErrorVerifyPhoneNumber");
                TempData["ErrorVerifyPhoneNumber"] = "کد وارد شده اشتباه است";
                return View(confirmDto);
            }

            user.PhoneNumberConfirmed=true;
            var identityResult = _userManager.UpdateAsync(user).Result;
            if (identityResult.Succeeded)
            {
                TempData["AuthSuccess"] = "ثبت نام شما با موفقیت انجام شد";
            }
            //Send Success Sms
            var firstName = user.FirstName.FixPersianChars();
            var lastName = user.LastName.FixPersianChars();
            SendSms.VerifySmsSend(confirmDto.PhoneNumber, "SuccessRegister", firstName, lastName, confirmDto.PhoneNumber);

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
            _signInManager.SignOutAsync();

            var result = _signInManager
                .PasswordSignInAsync(user, loginDto.Password, false, true)
                .Result;

            if (result.Succeeded)
            {
                // Set User To Cart if Cart is Available In before Time By BrowserId
                _cartFrontEndService.GetMyCart(_cookiesManeger.GetBrowserId(HttpContext), user.Id);
                
                
                _userManager.AddLoginAsync(user, null);
                _logger.LogInformation(LogEvents.LogInformationComplete, "LoginSuccess");

                if (Url.IsLocalUrl(loginDto.ReturnUrl))
                {
                    return Redirect(loginDto.ReturnUrl); 
                }
                _logger.LogInformation(LogEvents.OpenRedirectAttack, "Open Redirect Attack!!");
                return Redirect("/");
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
            _logger.LogInformation(LogEvents.LogInformationComplete, "LoginWrongPassword");

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
            SendSms.VerifySmsSend(UserName, "ForgotPasswordSmsSend", code);

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
                _logger.LogInformation(LogEvents.LogInformationComplete, "SuccessChangePassword");
                TempData["ErrorVerifyPhoneNumber"] = "کد وارد شده اشتباه است";
                return View(forgotPasswordDto);
            }


            var result = _userManager
                .ResetPasswordAsync(user, forgotPasswordDto.token, forgotPasswordDto.Password)
                .Result;
            if (result.Succeeded)
            {
                _logger.LogInformation(LogEvents.LogInformationComplete, "SuccessChangePassword");

                //Send Success Sms
                var firstName = user.FirstName.FixPersianChars();
                var lastName = user.LastName.FixPersianChars();
                SendSms.VerifySmsSend(forgotPasswordDto.PhoneNumber, "SuccessChangePassword", firstName, lastName,
                    forgotPasswordDto.PhoneNumber);

                TempData["PhoneNumber"] = forgotPasswordDto.PhoneNumber;
                TempData["SuccessChangePassword"] = "رمز عبور شما با موفقیت ویرایش شد";
                return RedirectToAction(nameof(CheckOut));
            }
            else
            {
                TempData["ForgotPasswordErrors"] = result.Errors;
                _logger.LogWarning(LogEvents.LogWarningComplete, "ForgotPasswordErrors");
                return View(forgotPasswordDto);
            }
        }


        [HttpPost]
        [Route("users/auth/again-sms-send", Name = "AgainSmsSend")]
        public IActionResult AgainSmsSend(ConfirmDto confirmDto)
        {
            var user = _userManager.FindByNameAsync(confirmDto.PhoneNumber).Result;
            var code = _userManager.GenerateChangePhoneNumberTokenAsync(user, confirmDto.PhoneNumber).Result;
            SendSms.VerifySmsSend(confirmDto.PhoneNumber, "ConfirmPhoneNumberSmsSend", code);

            TempData["PhoneNumber"] = confirmDto.PhoneNumber;
            return RedirectToAction(nameof(Confirm));
        }
    }
}