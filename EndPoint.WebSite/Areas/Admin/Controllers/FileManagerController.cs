using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.WebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    [Route("panel/admin/file-manager/[action]/{id?}")]
    public class FileManagerController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
    
        
    }
    
    
    
}