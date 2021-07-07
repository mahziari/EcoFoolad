using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Application.Interfaces.Contexts;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Application.Services.BackEnd.Admin.Footers
{
    public interface IFootersServices
    {
        FooterDto GetFootersValues();
        BaseDto<FooterDto> EditFootersValues(FooterDto footerDto);
    }

    public class FootersServices : IFootersServices
    {
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;

        public FootersServices(ICustomDbContext customDbContext, IMapper mapper)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
        }

        [HttpGet]
        public FooterDto GetFootersValues()
        {
            var model = _customDbContext.Footers.FirstOrDefault();
            var data = _mapper.Map<FooterDto>(model);
            return data;
        }

        [HttpPost]
        public BaseDto<FooterDto> EditFootersValues(FooterDto footerDto)
        {
            var model = _customDbContext.Footers.Find(footerDto.Id);
            var data =  _mapper.Map(footerDto, model);
            _customDbContext.SaveChanges();
            return new BaseDto<FooterDto>
            (
                true,
                new List<string> {"فوتر با موفقیت ویرایش شد"},
                _mapper.Map<FooterDto>(data)
            );
        }
    }


    public class FooterDto
    {
        public int Id { get; set; }
        
        [Display(Name = "نام سایت")]
        public string SiteName { get; set; }

        [Display(Name = "آدرس دفتر")] 
        public string OfficeAddress { get; set; }

        [Display(Name = "آدرس کارخانه")]
        public string FactoryAddress { get; set; }

        [Display(Name = "شماره دفتر")]
        public string PhoneNumber1 { get; set; }

        [Display(Name = "شماره انبار")]
        public string PhoneNumber2 { get; set; }

        [Display(Name = "")] 
        public string PhoneNumber3 { get; set; }

        [Display(Name = "توضیحات")]
        public string Description { get; set; }

        [Display(Name = "کپی رایت")] 
        public string Copyright { get; set; }

        [Display(Name = "لوگو اینماد")] 
        public string Photo1 { get; set; }

        [Display(Name = "لوگو ساماندهی")]
        public string Photo2 { get; set; }

        [Display(Name = "لوگو همکار 1")] 
        public string Photo3 { get; set; }

        [Display(Name = "لوگو همکار 1")]
        public string Photo4 { get; set; }

        [Display(Name = "لوگو همکار 1")] 
        public string Photo5 { get; set; }

        [Display(Name = "لوگو همکار 1")] 
        public string Photo6 { get; set; }

        [Display(Name = "لوگو همکار 1")]
        public string Photo7 { get; set; }

        [Display(Name = "لوگو اتحادیه کشوری کسب و کار مجازی")] 
        public string Photo8 { get; set; }

        [Display(Name = "لوگو نظام صنفی رایانه ای کشور")]
        public string Photo9 { get; set; }

        [Display(Name = "لوگو انجمن انفورماتیک ایران")] 
        public string Photo10 { get; set; }

        [Display(Name = "لوگو شرکت های ارایه دهنده خدمات وب و موبایل")]
        public string Photo11 { get; set; }

        [Display(Name = "")] public string Photo12 { get; set; }

        [Display(Name = "")] public string Photo13 { get; set; }

        [Display(Name = "")] public string Photo14 { get; set; }

        [Display(Name = "")] public string Photo15 { get; set; }

        [Display(Name = "عکس لوگو بزرگ")]
        public string LogoImage { get; set; }

        [Display(Name = "عکس لوگو کوچک")] 
        public string ThumbnailLogoImage { get; set; }
    }
}