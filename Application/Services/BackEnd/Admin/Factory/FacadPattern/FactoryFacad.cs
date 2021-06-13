using Application.Interfaces.Contexts;
using Application.Interfaces.FacadPatterns.BackEnd.Admin;
using Application.Services.BackEnd.Admin.Blogs.Queries.GetIndexBlogs;
using Application.Services.BackEnd.Admin.Factory.Command.CreateFactory;
using Application.Services.BackEnd.Admin.Factory.Command.EditFactory;
using Application.Services.BackEnd.Admin.Factory.Queries.GetCreateFactory;
using Application.Services.BackEnd.Admin.Factory.Queries.GetEditFactory;
using Application.Services.BackEnd.Admin.Factory.Queries.GetIndexFactory;
using AutoMapper;

namespace Application.Services.BackEnd.Admin.Factory.FacadPattern
{
    public class FactoryFacad:IFactoryFacad
    {
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;
        public FactoryFacad(ICustomDbContext customDbContext, IMapper mapper)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
        }
     
        private IGetIndexFactoryServices _getIndexFactoryServices;
        public IGetIndexFactoryServices GetIndexFactoryServices
        {
            get
            {
                return _getIndexFactoryServices ??= new GetIndexFactoryServices(_customDbContext,_mapper);
            }
        }
        
        
        
        private IGetCreateFactoryServices _getCreateFactoryServices;
        public IGetCreateFactoryServices GetCreateFactoryServices
        {
            get
            {
                return _getCreateFactoryServices ??= new GetCreateFactoryServices(_customDbContext,_mapper);
            }
        }

        
        
        
        // private IGetEditFactoryServices _getEditFactoryServices;
        // public IGetEditFactoryServices GetEditFactoryServices
        // {
        //     get
        //     {
        //         return _getEditFactoryServices ??= new GetEditFactoryServices(_customDbContext,_mapper);
        //     }
        // }
        
        
        private ICreateFactoryServices _createFactoryServices;
        public ICreateFactoryServices CreateFactoryServices
        {
            get
            {
                return _createFactoryServices ??= new CreateFactoryServices(_customDbContext,_mapper);
            }
        }
        
        
        // private IEditFactoryServices _editFactoryServices;
        // public IEditFactoryServices EditFactoryServices
        // {
        //     get
        //     {
        //         return _editFactoryServices ??= new EditFactoryServices(_customDbContext,_mapper);
        //     }
        // }

    }
    
}