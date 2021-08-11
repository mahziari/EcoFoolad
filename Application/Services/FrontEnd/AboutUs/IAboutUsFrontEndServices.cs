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
        
        public string ImageUrl { get; set; }
        
        public string Body { get; set; }
        
        public string Member1 { get; set; }
        
        public string FullName1 { get; set; }
        
        public string MemberSide1 { get; set; }
        
        public string Member2 { get; set; }
        
        public string FullName2 { get; set; }
        
        public string MemberSide2 { get; set; }
        
        public string Member3 { get; set; }
        
        public string FullName3 { get; set; }
        
        public string MemberSide3 { get; set; }
    }
}