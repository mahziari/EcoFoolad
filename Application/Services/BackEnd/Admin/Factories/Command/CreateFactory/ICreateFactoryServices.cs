using System.Linq;
using Domain.Entities;

namespace Application.Services.BackEnd.Admin.Factory.Command.CreateFactory
{
    public interface ICreateFactoryServices
    { 
        BaseDto<FactoryDto> CreateFactory(FactoryDto factoryDto);
    }
}