using Application.Interfaces.Contexts;
 

namespace  Application.Services.BackEnd.Admin.Sliders.Commands
{
    public interface IEditSlidersServices
    {
        ResultEditSlidersServices Execute();
    }

    public class EditSlidersServices : IEditSlidersServices
    {
        private readonly ICustomDbContext _context;
        public EditSlidersServices(ICustomDbContext context)
        {
            _context = context;
        }

        public ResultEditSlidersServices Execute()
        {
            return new ResultEditSlidersServices
            {

            };
        }
    }



    public class ResultEditSlidersServices
    {
        public string Type { get; set; }
        public string Position { get; set; }
        public string Url { get; set; }
    }
}