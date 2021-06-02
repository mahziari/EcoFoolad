using Application.Interfaces.Contexts;
using Microsoft.AspNetCore.Hosting;
 
using  Application.Interfaces.FacadPatterns.BackEnd.Admin;
using  Application.Services.BackEnd.Admin.Sliders.Commands;
using  Application.Services.BackEnd.Admin.Sliders.Queries;


namespace  Application.Services.BackEnd.Admin.Sliders.FacadPattern
{
    public class SlidersFacad:ISlidersFacad
    {
        private readonly ICustomDbContext _context;
        private readonly IWebHostEnvironment _environment;

        public SlidersFacad(ICustomDbContext context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _environment = hostingEnvironment;
        }
        
        
        
        
         private IGetIndexSlidersServices _getIndexSlidersServices;
        public IGetIndexSlidersServices GetIndexSlidersServices
        {
            get
            {
                return _getIndexSlidersServices ??= new GetIndexSlidersServices(_context);
            }
        }
        
        
        
        private IGetCreateSlidersServices _getCreateSlidersServices;
        public IGetCreateSlidersServices GetCreateSlidersServices
        {
            get
            {
                return _getCreateSlidersServices ??= new GetCreateSlidersServices(_context);
            }
        }
        
        
        private ICreateSlidersServices _createSlidersServices;
        public ICreateSlidersServices CreateSlidersServices
        {
            get
            {
                return _createSlidersServices ??= new CreateSlidersServices(_context,_environment);
            }
        }
        
        
        private IGetDetailsSlidersServices _getDetailsSlidersServices;
        public IGetDetailsSlidersServices GetDetailsSlidersServices
        {
            get
            {
                return _getDetailsSlidersServices ??= new GetDetailsSlidersServices(_context);
            }
        }
        
        
        private IGetEditSlidersServices _getEditSlidersServices;
        public IGetEditSlidersServices GetEditSlidersServices
        {
            get
            {
                return _getEditSlidersServices ??= new GetEditSlidersServices(_context);
            }
        }
        
        
        
        private IEditSlidersServices _editSlidersServices;
        public IEditSlidersServices EditSlidersServices
        {
            get
            {
                return _editSlidersServices ??= new EditSlidersServices(_context);
            }
        }
        
        
        private IDeleteSlidersServices _deleteSlidersServices;
        public IDeleteSlidersServices DeleteSlidersServices
        {
            get
            {
                return _deleteSlidersServices ??= new DeleteSlidersServices(_context,_environment);
            }
        }

    }
}