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
    [Route("home")]
    public class HomeController : Controller
    {
        private readonly IHomeFrontEndFacad _homeFacad;
        private readonly ILogger _logger;

        public HomeController(IHomeFrontEndFacad homeFacad, ILoggerFactory logger)
        {
            _homeFacad = homeFacad;
            _logger = logger.CreateLogger("Home");
        }

        [Route("/")]
        public IActionResult Index()
        {
            var result = _homeFacad.GetHomeFrontEndService.Execute();


            _logger.LogInformation(LogEvents.LogInformationComplete, "info");
            _logger.LogWarning(LogEvents.LogWarningComplete, "war");
            _logger.LogError(LogEvents.LogErrorComplete, "err");
            _logger.LogDebug(LogEvents.LogDebugSomeErrorOccurred, "debug");
            _logger.LogCritical(LogEvents.LogCriticalSomeErrorOccurred, "critical");

            return View(result);
        }


        // [Route("/sitemap-blog.xml")]
        // public async Task<IActionResult> SitemapBlog()
        // {
        //     
        //     
        //     string baseUrl = $"{Request.Scheme}://{Request.Host}{Request.PathBase}";
        //     string segment = "blog";
        //     string contentType = "application/xml";
        //
        //     string sitemapBlog = "sitemap-blog.xml";
        //
        //     // For showing in browser (Without download)
        //     var cd = new System.Net.Mime.ContentDisposition
        //     {
        //         FileName = sitemapBlog,
        //         Inline = true,
        //     };
        //     Response.Headers.Append("Content-Disposition", cd.ToString());
        //
        //     // Cache
        //     // var bytes = _cache.Get<byte[]>(sitemapBlog);
        //     // if (bytes != null)
        //     //     return File(bytes, contentType);
        //
        //     var blogs = await _idealCrmDataBaseContext.CrmCmsNews.ToListAsync();
        //
        //     var sb = new StringBuilder();
        //     sb.AppendLine($"<?xml version=\"1.0\" encoding=\"utf-8\"?>");
        //     sb.AppendLine($"<urlset xmlns=\"http://www.sitemaps.org/schemas/sitemap/0.9\"");
        //     sb.AppendLine($"   xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"");
        //     sb.AppendLine(
        //         $"   xsi:schemaLocation=\"http://www.sitemaps.org/schemas/sitemap/0.9 http://www.sitemaps.org/schemas/sitemap/0.9/sitemap.xsd\">");
        //
        //     foreach (var m in blogs)
        //     {
        //         var dt = m.RegisterDate;
        //         string lastmod = $"{dt.ToString("s") + "+" + TimeZoneInfo.Local.BaseUtcOffset.ToHHMM()}";
        //         sb.AppendLine($"    <url>");
        //         sb.AppendLine($"        <loc>{baseUrl}/{segment}/{m.Title}</loc>");
        //         sb.AppendLine($"        <lastmod>{lastmod}</lastmod>");
        //         sb.AppendLine($"        <changefreq>daily</changefreq>");
        //         sb.AppendLine($"        <priority>0.8</priority>");
        //         sb.AppendLine($"    </url>");
        //     }
        //
        //     sb.AppendLine($"</urlset>");
        //
        //     var bytes = Encoding.UTF8.GetBytes(sb.ToString());
        //
        //     var options = new DistributedCacheEntryOptions
        //     {
        //         AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(24)
        //     };
        //
        //     _cache.Set(sitemapBlog, bytes, options);
        //
        //     return File(bytes, contentType);
        // }



       
    }
}