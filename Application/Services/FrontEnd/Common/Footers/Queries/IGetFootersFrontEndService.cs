using System.ComponentModel.DataAnnotations;
using System.Linq;
using Application.Interfaces.Contexts;
using AutoMapper;
using Domain.Entities;

namespace Application.Services.FrontEnd.Common.Footers.Queries
{
    public interface IGetFootersFrontEndService
    {
        BaseDto<FooterFrontEndDto> GetFootersFrontEnd();
    }

    public class GetFootersFrontEndService:IGetFootersFrontEndService
    {
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;

        public GetFootersFrontEndService(ICustomDbContext customDbContext, IMapper mapper)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
        }
        
        

        public BaseDto<FooterFrontEndDto> GetFootersFrontEnd()
        {
            var model = _customDbContext.Footers.FirstOrDefault();
            var data = _mapper.Map<FooterFrontEndDto>(model);
            return new BaseDto<FooterFrontEndDto>
            (
                true,
                null,
                _mapper.Map<FooterFrontEndDto>(data)
            );
        }
    }
    
    
    public class FooterFrontEndDto
    {
        public int Id { get; set; }
        public string SiteName { get; set; }
        public string OfficeAddress { get; set; }
        public string FactoryAddress { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string PhoneNumber3 { get; set; }
        public string Description {get; set; }
        public string Copyright {get; set; }
        public string Photo1 {get; set; }
        public string Photo2 {get; set; }
        public string Photo3 {get; set; }
        public string Photo4 {get; set; }
        public string Photo5 {get; set; }
        public string Photo6 {get; set; }
        public string Photo7 {get; set; }
        public string Photo8 {get; set; }
        public string Photo9 {get; set; }
        public string Photo10 {get; set; }
        public string Photo11 {get; set; }
        public string Photo12 {get; set; }
        public string Photo13 {get; set; }
        public string Photo14 {get; set; }
        public string Photo15 {get; set; }
        public string LogoImage {get; set; }
        public string ThumbnailLogoImage {get; set; }
    }
}


