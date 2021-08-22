using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Application.Interfaces.Contexts;
using AutoMapper;
using Domain.Entities.Dtos;
using Domain.Entities.Experts;

namespace Application.Services.BackEnd.Admin.Experts
{
    public interface IExpertsServices
    {
        List<ExpertDto> GetIndexExpertsServices();
        ExpertDto GetCreateExpertsServices();
        BaseDto<ExpertDto> GetEditExpertsServices(int id);
        BaseDto<ExpertDto> CreateExpertsServices(ExpertDto expertDto);
        BaseDto<ExpertDto> EditExpertsServices(ExpertDto expertDto);
        BaseDto DeleteExpertsServices(int id);
    }

    public class ExpertsServices : IExpertsServices
    {
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;
        public ExpertsServices(ICustomDbContext customDbContext, IMapper mapper)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
        }

        public List<ExpertDto> GetIndexExpertsServices()
        {
            var model = _customDbContext.Experts;
            var data = _mapper.Map<List<ExpertDto>>(model);
            return data;
        }
        
        public ExpertDto GetCreateExpertsServices()
        {
            return new ExpertDto();
        }
        

        public BaseDto<ExpertDto> CreateExpertsServices(ExpertDto expertDto)
        {
            var data = _mapper.Map<Expert>(expertDto);
            _customDbContext.Experts.Add(data);
            _customDbContext.SaveChanges();
            return new BaseDto<ExpertDto>
            (
                true,
                new List<string> {"کارشناس فروش با موفقیت ساخته شد"},
                _mapper.Map<ExpertDto>(data)
            );
        }
        
    
        
        public BaseDto<ExpertDto> GetEditExpertsServices(int id)
        {
            var model = _customDbContext.Experts.SingleOrDefault(a => a.Id == id);
            var data = _mapper.Map<ExpertDto>(model);
            return new BaseDto<ExpertDto>
            (
                true,
                null,
                _mapper.Map<ExpertDto>(data)
            );
        }
        
        public BaseDto<ExpertDto> EditExpertsServices(ExpertDto expertDto)
        {
            var model = _customDbContext.Experts.SingleOrDefault(a => a.Id == expertDto.Id);
            _mapper.Map(expertDto, model);
            _customDbContext.SaveChanges();
            return new BaseDto<ExpertDto>
            (
                true,
                new List<string> {"کارشناس فروش با موفقیت ویرایش شد"},

                _mapper.Map<ExpertDto>(model)
            );
        }
        
        public BaseDto DeleteExpertsServices(int id)
        {
            var model = _customDbContext.Experts.Find(id);
            _customDbContext.Experts.Remove(model);
            _customDbContext.SaveChanges();
            return new BaseDto
            (
                true,
                new List<string> { "کارشناس فروش با موفقیت حذف شد" }
            );
        }
        
    }

    public class ExpertDto
    {
        public int Id { get; set; }
        
        [Display(Name = "آدرس عکس کارشناس:")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string ImageUrl { get; set; }
        
        [Display(Name = "نام:")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string FirstName { get; set; }
        
        [Display(Name = "نام خوانوادگی:")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string LastName { get; set; }
        
        [Display(Name = "شماره موبایل:")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string PhoneNumber { get; set; }
        
        [Display(Name = "لینک  واتس آپ:")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string WhatsApp { get; set; }
        
        [Display(Name = "آی دی تلگرام:")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string Telegram { get; set; }
        
        [Display(Name = "آی دی اینستاگرام:")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string Instagram { get; set; } 
    }
}