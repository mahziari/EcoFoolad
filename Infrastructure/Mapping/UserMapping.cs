using Application.Services.FrontEnd.User.Addresses;
using Application.Services.FrontEnd.User.Orders;
using AutoMapper;
using Domain.Entities.Orders;
using Domain.Entities.Users;

namespace Infrastructure.Mapping
{
    public class UserMappingProfile:Profile
    {
        public UserMappingProfile()
        {
            CreateMap<UserAddress, UserAddressDto>().ReverseMap();
            CreateMap<UserAddress, Address>();
            
            
            CreateMap<Order, UserOrdersDto>().ReverseMap();
            
            
            
        }
    }
}