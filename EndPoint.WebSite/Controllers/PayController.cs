using Application.Services.FrontEnd.Payments;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace EndPoint.WebSite.Controllers
{
    public class PayController:Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IPaymentsServices _paymentsServices;

        public PayController(IConfiguration configuration, IPaymentsServices paymentsServices)
        {
            _configuration = configuration;
            _paymentsServices = paymentsServices;
        }

        public IActionResult Index()
        {
            return Redirect("/");
        }
    }
}