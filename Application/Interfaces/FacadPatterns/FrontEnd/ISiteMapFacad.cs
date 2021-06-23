using Application.Services.FrontEnd.SiteMaps;

namespace Application.Interfaces.FacadPatterns.FrontEnd
{
    public interface ISiteMapFacad
    {
         ISiteMapServices SiteMapServices { get; }
    }
}