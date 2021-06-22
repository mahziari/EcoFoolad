using Application.Interfaces.FacadPatterns.FrontEnd;
using Application.Services.FrontEnd.Common;
using Common.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EndPoint.WebSite.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        private readonly ILogger _logger;
        private readonly IHomeFrontEndFacad _homeFacad;

        public HomeController(IHomeFrontEndFacad homeFacad, ILoggerFactory logger)
        {
            _homeFacad = homeFacad;
            _logger = logger.CreateLogger("Home");
        }

        [Route("/")]
        public IActionResult Index()
        {

            var result = _homeFacad.GetHomeFrontEndService.Execute();
            
            
            _logger.LogInformation(LogEvents.LogInformationComplete,"info");
            _logger.LogWarning(LogEvents.LogWarningComplete,"war");
            _logger.LogError(LogEvents.LogErrorComplete,"err");
            _logger.LogDebug(LogEvents.LogDebugSomeErrorOccurred,"debug");
            _logger.LogCritical(LogEvents.LogCriticalSomeErrorOccurred,"critical");

            return View(result); 
        }



        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // [Route("error")]
        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }
    }
}
