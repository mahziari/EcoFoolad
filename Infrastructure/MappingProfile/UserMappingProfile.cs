using Application.Services.FrontEnd.User.Addresses;
using AutoMapper;
using Domain.Entities.Users;

namespace Infrastructure.MappingProfile
{
    public class UserMappingProfile:Profile
    {
        public UserMappingProfile()
        {
            CreateMap<UserAddress, UserAddressDto>().ReverseMap();
        }
    }
}