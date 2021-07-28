using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Application.Interfaces.Contexts;
using Application.Services.BackEnd.Admin.Footers;
using AutoMapper;
using Domain.Entities;

namespace Application.Services.BackEnd.Admin.AboutUs
{
    public interface IAboutUsServices
    {
        AboutUsDto GetAboutUs();
        BaseDto<AboutUsDto> EditFootersValues(AboutUsDto aboutUsDto);
    }

    public class AboutUsServices : IAboutUsServices
    {
   

        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;

        public AboutUsServices(ICustomDbContext customDbContext, IMapper mapper)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
        }


        public AboutUsDto GetAboutUs()
        {
            var aboutUsModel = _customDbContext.AboutUs.Single();
            var data = _mapper.Map<AboutUsDto>(aboutUsModel);
            return data;
        }

        public BaseDto<AboutUsDto> EditFootersValues(AboutUsDto aboutUsDto)
        {
            var model = _customDbContext.Footers.Find(aboutUsDto.Id);
            var data =  _mapper.Map(aboutUsDto, model);
            _customDbContext.SaveChanges();
            return new BaseDto<AboutUsDto>
            (
                true,
                new List<string> {"فوتر با موفقیت ویرایش شد"},
                _mapper.Map<AboutUsDto>(data)
            );
        }
    }

    public class AboutUsDto
    {
        public int Id { get; set; }
        
        [Display(Name = "لینک عکس بالای صفحه")]
        public string ImageUrl { get; set; }
        
        [Display(Name = "متن درباره ما")]
        public string Body { get; set; }
        
        [Display(Name = "لینک عکس اعضا ۱")]
        public string Member1 { get; set; }
        
        [Display(Name = "لینک عکس اعضا 2")]
        public string Member2 { get; set; }
        
        [Display(Name = "لینک عکس اعضا 3")]
        public string Member3 { get; set; }
    }
}