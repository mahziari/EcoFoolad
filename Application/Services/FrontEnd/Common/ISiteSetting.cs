using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces.Contexts;
using AutoMapper;

namespace Application.Services.FrontEnd.Common
{

    public interface ISiteSetting
    {
        SiteSettingFrontEndDto GetSiteSetting();
    }

    public class SiteSetting : ISiteSetting
    {
        private readonly  ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;

        public SiteSetting(ICustomDbContext customDbContext, IMapper mapper)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
        }
        
        public SiteSettingFrontEndDto GetSiteSetting()
        {
            var model = _customDbContext.Footers.FirstOrDefault();
            var data = _mapper.Map<SiteSettingFrontEndDto>(model);
            return data;
        }
        
    }
}

public class SiteSettingFrontEndDto
{
    public string SiteName { get; set; }
    public string LogoImage {get; set; }
    public string ThumbnailLogoImage {get; set; }
}
