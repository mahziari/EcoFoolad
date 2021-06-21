using System;
using System.Collections.Generic;
using Application.Interfaces.Contexts;
using Application.Services.BackEnd.Admin.Factory.Command.CreateFactory;
using AutoMapper;
using Domain.Entities;

namespace Application.Services.BackEnd.Admin.Factory.Queries.GetCreateFactory
{
    public interface IGetCreateFactoryServices
    {
        FactoryDto GetCreateFactory();
    }
    public class GetCreateFactoryServices:IGetCreateFactoryServices{
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;
        public GetCreateFactoryServices(ICustomDbContext customDbContext, IMapper mapper)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
        }
        
        
        public FactoryDto GetCreateFactory()
        {
            return new FactoryDto();
        }

    }
}