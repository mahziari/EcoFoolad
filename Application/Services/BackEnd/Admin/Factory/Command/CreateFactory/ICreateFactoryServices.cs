using System.Linq;
using Application.Services.FrontEnd.User.Addresses;
using Domain.Entities;

namespace Application.Services.BackEnd.Admin.Factory.Command.CreateFactory
{
    public interface ICreateFactoryServices
    { 
        BaseDto<FactoryDto> CreateFactory(FactoryDto factoryDto);
    }
}