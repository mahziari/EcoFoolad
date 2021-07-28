using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Application.Interfaces.Contexts;
using AutoMapper;
using Domain.Entities;

namespace Application.Services.FrontEnd.AboutUs
{
    public interface IAboutUsFrontEndServices
    {
        AboutUsFrontEndDto GetAboutUs();
    }

    public class AboutUsFrontEndServices : IAboutUsFrontEndServices
    {
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;
        public AboutUsFrontEndServices(ICustomDbContext customDbContext, IMapper mapper)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
        }
        

        public AboutUsFrontEndDto GetAboutUs()
        {
            var aboutUsModel = _customDbContext.AboutUs.First();
            var data = _mapper.Map<AboutUsFrontEndDto>(aboutUsModel);
            return data;
        }
    }

    public class AboutUsFrontEndDto
    {
        public int Id { get; set; }
        
        [Display(Name = "عکس بالای صفحه")]
        public string ImageUrl { get; set; }
        
        [Display(Name = "متن درباره ما")]
        public string Body { get; set; }
        
        [Display(Name = "عکس اعضا ۱")]
        public string Member1 { get; set; }
        
        [Display(Name = "عکس اعضا 2")]
        public string Member2 { get; set; }
        
        [Display(Name = "عکس اعضا 3")]
        public string Member3 { get; set; }
    }
}