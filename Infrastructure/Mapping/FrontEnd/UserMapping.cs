using Application.Services.BackEnd.User.Addresses;
using Application.Services.BackEnd.User.Orders;
using AutoMapper;
using Domain.Entities.Orders;
using Domain.Entities.Users;

namespace Infrastructure.Mapping.FrontEnd
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