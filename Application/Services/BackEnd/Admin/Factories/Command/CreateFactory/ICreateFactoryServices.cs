using System.Linq;
using Domain.Entities;
using Domain.Entities.Dtos;

namespace Application.Services.BackEnd.Admin.Factory.Command.CreateFactory
{
    public interface ICreateFactoryServices
    { 
        BaseDto<FactoryDto> CreateFactory(FactoryDto factoryDto);
    }
}