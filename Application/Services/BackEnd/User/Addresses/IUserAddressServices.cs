using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Application.Interfaces.Contexts;
using AutoMapper;
using Domain.Entities;
using Domain.Entities.Dtos;
using Domain.Entities.Users;

namespace Application.Services.BackEnd.User.Addresses
{
    public interface IUserAddressServices
    {
        List<UserAddressDto> GetUserAddress(string userId);
        BaseDto<UserAddressDto> AddNewAddress(UserAddressDto userAddressDto);
        BaseDto<UserAddressDto> GetEditAddressServices(int id);
        BaseDto<UserAddressDto> EditAddressServices(UserAddressDto userAddressDto);
        BaseDto Remove(int Id);
    }

    public class UserAddressServices : IUserAddressServices
    {
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;

        public UserAddressServices(ICustomDbContext customDbContext, IMapper mapper)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
        }

        public List<UserAddressDto> GetUserAddress(string userId)
        {
            var model = _customDbContext.UserAddresses.Where(a => a.UserId == userId);
            var data = _mapper.Map<List<UserAddressDto>>(model);
            return data;
        }

        public BaseDto<UserAddressDto> AddNewAddress(UserAddressDto userAddressDto)
        {
            var data = _mapper.Map<UserAddress>(userAddressDto);
            _customDbContext.UserAddresses.Add(data);
            _customDbContext.SaveChanges();
            return new BaseDto<UserAddressDto>
            (
                true,
                new List<string> {"تایپ با موفقیت ساخته شد"},

                _mapper.Map<UserAddressDto>(data)
            );
        }
        
    
        
        public BaseDto<UserAddressDto> GetEditAddressServices(int id)
        {
            var model = _customDbContext.UserAddresses.SingleOrDefault(a => a.Id == id);
            var data = _mapper.Map<UserAddressDto>(model);
            return new BaseDto<UserAddressDto>
            (
                true,
                null,
                _mapper.Map<UserAddressDto>(data)
            );
        }
        
        public BaseDto<UserAddressDto> EditAddressServices(UserAddressDto userAddressDto)
        {
            var model = _customDbContext.UserAddresses.SingleOrDefault(a => a.Id == userAddressDto.Id);
            _mapper.Map(userAddressDto, model);
            _customDbContext.SaveChanges();
            return new BaseDto<UserAddressDto>
            (
                true,
                new List<string> {"تایپ با موفقیت ویرایش شد"},

                _mapper.Map<UserAddressDto>(model)
            );
        }
        
        public BaseDto Remove(int Id)
        {
            var model = _customDbContext.UserAddresses.Find(Id);
            _customDbContext.UserAddresses.Remove(model);
            _customDbContext.SaveChanges();
            return new BaseDto
            (
                true,
                new List<string> { $"ایتم با موفقیت حذف شد" }
            );
        }
    }

    // public class UserAddressDto
    // {
    //     public string State { get; set; }
    //     public string City { get; set; }
    //     public string ZipCode { get; set; }
    //     public string PostalAddress { get; set; }
    //     public string ReciverName  { get; set; }
    // }

    public class UserAddressDto
    {
        public int Id { get; set; }
        public string UserId { get; set; }

        [Display(Name = "استان")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string State { get; set; }
        
        [Display(Name = "شهر")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string City { get; set; }
        
        [Display(Name = "کدپستی")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string ZipCode { get; set; }
        
        [Display(Name = "آدرس")]
        [StringLength(11, ErrorMessage = "تعداد کاراکتر بیش از حد مجاز")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string PostalAddress { get; set; }

        [Display(Name = "نام دریافت کننده")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string ReciverName  { get; set; }
    }
    
}