using System.Threading.Tasks;

namespace Application.Services.FrontEnd.SiteMaps
{
    public interface ISiteMapServices
    {
        Task<string> SiteMapXml();
        Task<string> SiteMapBlogXml();
        Task<string> SiteMapProductXml();
    }
}