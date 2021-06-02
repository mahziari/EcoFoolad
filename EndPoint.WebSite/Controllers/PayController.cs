using System;
using System.Threading.Tasks;
using Application.Interfaces.FacadPatterns.FrontEnd;
using Application.Services.FrontEnd.Carts;
using Application.Services.FrontEnd.Fainances.Commands;
using Application.Services.FrontEnd.Fainances.Queries;
using Domain.Entities.Users;
using EndPoint.WebSite.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.WebSite.Controllers
{
    [Authorize(Policy = "SeniorProgrammer")]
    public class PayController : Controller
    {
        private readonly ICartFrontEndService _cartFrontEndService;
        private readonly CookiesManeger _cookiesManeger;
        private readonly UserManager<User> _userManager;
        private readonly IFinancesFrontEndFacad _financesFrontEndFacad;


        public PayController(ICartFrontEndService cartFrontEndService, CookiesManeger cookiesManeger, UserManager<User> userManager, IFinancesFrontEndFacad financesFrontEndFacad)
        {
            _cartFrontEndService = cartFrontEndService;
            _cookiesManeger = cookiesManeger;
            _userManager = userManager;
            _financesFrontEndFacad = financesFrontEndFacad;
        }


        public async Task<IActionResult> Index()
        {
            string userId = _userManager.GetUserId(HttpContext.User);
            var cart = _cartFrontEndService.GetMyCart(_cookiesManeger.GetBrowserId(HttpContext), userId);
            if (cart.Data.SumAmount > 0)
            {k
                var requestPay = _financesFrontEndFacad.AddRequestPayService.Execute(cart.Data.SumAmount, userId);
                // ارسال در گاه پرداخت
                
                
                // var result = await  _payment.Request(new DtoRequest()
                // {
                //     Mobile = "09121112222",
                //     CallbackUrl = $"https://localhost:44339/Pay/Verify?guid={requestPay.Data.guid}",
                //     Description = "پرداخت فاکتور شماره:" + requestPay.Data.RequestPayId,
                //     Email = requestPay.Data.Email,
                //     Amount = requestPay.Data.Amount,
                //     MerchantId = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX"
                // }, ZarinPal.Class.Payment.Mode.sandbox);
                return Redirect($"https://sandbox.zarinpal.com/pg/StartPay");

            }
            else
            {
                return RedirectToAction("Index", "Cart");
            }

        }
    

        //  public async Task<IActionResult> Verify(Guid guid, string authority, string status)
        // {

            // var requestPay = _getRequestPayService.Execute(guid);
            //
            // var verification = await _payment.Verification(new DtoVerification
            // {
            //     Amount = requestPay.Data.Amount,
            //     MerchantId = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX",
            //     Authority = authority
            // }, Payment.Mode.sandbox);
            //
            // if(verification.Status == 100)
            // {
            //
            // }
            // else
            // {
            //
            // }
            //
            // return View();
        // }
    }
}
