using System;
using System.Threading.Tasks;
using Application.Interfaces.Contexts;
using Domain.Entities.SiteMaps;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;

namespace Application.Services.FrontEnd.SiteMaps
{
    public interface ISiteMapServices
    {
        Task<string> SiteMapXml();
        Task<string> SiteMapBlogXml();
        Task<string> SiteMapProductXml();
    }

    public class SiteMapServices : ISiteMapServices
    {
        private readonly ICustomDbContext _customDbContext;
        private readonly IIdealCrmDataBaseContext _idealCrmDataBaseContext;
        private readonly IDistributedCache _cache;
        private readonly IHttpContextAccessor _httpContext;
        private readonly IConfiguration _configuration;
        public SiteMapServices(ICustomDbContext customDbContext, IIdealCrmDataBaseContext idealCrmDataBaseContext,
            IDistributedCache cache, IHttpContextAccessor httpContext, IConfiguration configuration)
        {
            _customDbContext = customDbContext;
            _idealCrmDataBaseContext = idealCrmDataBaseContext;
            _cache = cache;
            _httpContext = httpContext;
            _configuration = configuration;
        }

        public async Task<string> SiteMapXml()
        {
            if (string.IsNullOrEmpty(await _cache.GetStringAsync("SiteMap")))
            {
                string baseUrl = $"{_httpContext.HttpContext?.Request.Scheme}://{_httpContext.HttpContext?.Request.Host}";
                
                // get a list of published articles
               var blogs=await _idealCrmDataBaseContext.CrmCmsNews
                    .Include(p => p.NewsGroup)
                    .ToListAsync();
               
               var blogsCategory=await _idealCrmDataBaseContext.CrmCmsNewsGroups
                   .ToListAsync();

               var siteMapsGenerator = new SiteMapsGenerator();
                // add the home page to the sitemap
                siteMapsGenerator.AddUrl(baseUrl, DateTime.UtcNow.ToString("s") + "+" + TimeZoneInfo.Local.BaseUtcOffset.ToHHMM(),ChangeFrequency.Weekly, priority: 1.0);

                // add the blog posts to the sitemap
                foreach (var item in blogs)
                {
                    siteMapsGenerator.AddUrl(baseUrl+"/"+item.NewsGroup.en_GroupName+"/"+item.Title.Replace(" ","-"), modified: item.LocalTime,ChangeFrequency.Daily,0.9);
                }
                
                foreach (var item in blogsCategory)
                {
                    siteMapsGenerator.AddUrl(baseUrl+"/"+item.en_GroupName.Replace(" ","-")+"/", modified: item.RegisterDate.ToString("s") + "+" + TimeZoneInfo.Local.BaseUtcOffset.ToHHMM(),ChangeFrequency.Daily,0.9);
                }

                // generate the sitemap xml
                string xml = siteMapsGenerator.ToString();


                var options = new DistributedCacheEntryOptions()
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(_configuration.GetValue<int>("SiteMapCacheTime:SiteMap"))
                };
                var jsonData = JsonConvert.SerializeObject(xml);
                _cache.SetString("SiteMap", jsonData, options);

                return xml.Normalize();
            }
            else
            {
                var sitemapProductRedis = _cache.GetString("SiteMap");
                var xml = JsonConvert.DeserializeObject(sitemapProductRedis).ToString();

                return xml;
            }
        }

        public async Task<string> SiteMapBlogXml()
        {
            if (string.IsNullOrEmpty(await _cache.GetStringAsync("SiteMapBlog")))
            {
                string baseUrl = $"{_httpContext.HttpContext?.Request.Scheme}://{_httpContext.HttpContext?.Request.Host}";
                
                // get a list of published articles
               var blogs=await _idealCrmDataBaseContext.CrmCmsNews
                    .Include(p => p.NewsGroup)
                    .ToListAsync();
               
               var blogsCategory=await _idealCrmDataBaseContext.CrmCmsNewsGroups
                   .ToListAsync();

               var siteMapsGenerator = new SiteMapsGenerator();
                // add the home page to the sitemap
                siteMapsGenerator.AddUrl(baseUrl, DateTime.UtcNow.ToString("s") + "+" + TimeZoneInfo.Local.BaseUtcOffset.ToHHMM(),ChangeFrequency.Weekly, priority: 1.0);

                // add the blog posts to the sitemap
                foreach (var item in blogs)
                {
                    siteMapsGenerator.AddUrl(baseUrl+"/"+"blog"+"/"+item.NewsGroup.en_GroupName+"/"+item.Title.Replace(" ","-"), modified: item.LocalTime,ChangeFrequency.Daily,0.9);
                }
                
                foreach (var item in blogsCategory)
                {
                    siteMapsGenerator.AddUrl(baseUrl+"/"+"blog"+"/"+item.en_GroupName.Replace(" ","-")+"/", modified: item.RegisterDate.ToString("s") + "+" + TimeZoneInfo.Local.BaseUtcOffset.ToHHMM(),ChangeFrequency.Daily,0.9);
                }

                // generate the sitemap xml
                string xml = siteMapsGenerator.ToString();


                var options = new DistributedCacheEntryOptions()
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(_configuration.GetValue<int>("SiteMapCacheTime:SiteMapBlog"))
                };
                var jsonData = JsonConvert.SerializeObject(xml);
                _cache.SetString("SiteMapBlog", jsonData, options);

                return xml.Normalize();
            }
            else
            {
                var sitemapProductRedis = _cache.GetString("SiteMapBlog");
                var xml = JsonConvert.DeserializeObject(sitemapProductRedis).ToString();

                return xml;
            }
        }

        public async Task<string> SiteMapProductXml()
        {
           if (string.IsNullOrEmpty(await _cache.GetStringAsync("SiteMapProduct")))
            {
                string baseUrl = $"{_httpContext.HttpContext?.Request.Scheme}://{_httpContext.HttpContext?.Request.Host}";
                
                // get a list of published articles
               var blogs=await _idealCrmDataBaseContext.CrmCmsNews
                    .Include(p => p.NewsGroup)
                    .ToListAsync();
               
               var blogsCategory=await _idealCrmDataBaseContext.CrmCmsNewsGroups
                   .ToListAsync();

               var siteMapsGenerator = new SiteMapsGenerator();
                // add the home page to the sitemap
                siteMapsGenerator.AddUrl(baseUrl, DateTime.UtcNow.ToString("s") + "+" + TimeZoneInfo.Local.BaseUtcOffset.ToHHMM(),ChangeFrequency.Weekly, priority: 1.0);

                // add the blog posts to the sitemap
                foreach (var item in blogs)
                {
                    siteMapsGenerator.AddUrl(baseUrl+"/"+"blog"+"/"+item.NewsGroup.en_GroupName+"/"+item.Title.Replace(" ","-"), modified: item.LocalTime,ChangeFrequency.Daily,0.9);
                }
                
                foreach (var item in blogsCategory)
                {
                }

                // generate the sitemap xml
                string xml = siteMapsGenerator.ToString();


                var options = new DistributedCacheEntryOptions()
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(_configuration.GetValue<int>("SiteMapCacheTime:SiteMapProduct"))
                };
                var jsonData = JsonConvert.SerializeObject(xml);
                _cache.SetString("SiteMapProduct", jsonData, options);

                return xml.Normalize();
            }
            else
            {
                var sitemapProductRedis = _cache.GetString("SiteMapProduct");
                var xml = JsonConvert.DeserializeObject(sitemapProductRedis).ToString();

                return xml;
            }
        }
    }
}