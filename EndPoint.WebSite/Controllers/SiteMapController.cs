using System;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces.Contexts;
using Application.Interfaces.FacadPatterns.FrontEnd;
using Application.Services.FrontEnd.SiteMaps;
using Common.Utilities;
using Domain.Entities.SiteMaps;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace EndPoint.WebSite.Controllers
{
   
    public class SiteMapController:Controller
    {
        private readonly ICustomDbContext _customDbContext;
        private readonly IIdealCrmDataBaseContext _idealCrmDataBaseContext;
        private readonly IDistributedCache _cache;
        private readonly ISiteMapFacad _siteMapFacad;

        public SiteMapController(ICustomDbContext customDbContext, IIdealCrmDataBaseContext idealCrmDataBaseContext, IDistributedCache cache, ISiteMapFacad siteMapFacad)
        {
            _customDbContext = customDbContext;
            _idealCrmDataBaseContext = idealCrmDataBaseContext;
            _cache = cache;
            _siteMapFacad = siteMapFacad;
        }
        
        
        [HttpGet]
        [Route("/sitemap.xml")]
        public ActionResult Sitemap()
        {
            var result = _siteMapFacad.SiteMapServices.SiteMapXml().Result;
            return Content(result, "text/xml");
        }
        
        [HttpGet]
        [Route("/sitemap-blog.xml")]
        public ActionResult SiteMapBlog()
        {
            var result = _siteMapFacad.SiteMapServices.SiteMapBlogXml().Result;
            return Content(result, "text/xml");
        }
        
        [HttpGet]
        [Route("/sitemap-product.xml")]
        public ActionResult SiteMapProduct()
        {
            var result = _siteMapFacad.SiteMapServices.SiteMapProductXml().Result;
            return Content(result, "text/xml");
        }
    }
}