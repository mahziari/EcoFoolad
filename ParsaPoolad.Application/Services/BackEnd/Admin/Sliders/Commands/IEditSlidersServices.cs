using ParsaPoolad.Application.Interfaces.Contexts;

namespace ParsaPoolad.Application.Services.BackEnd.Admin.Sliders.Commands
{
    public interface IEditSlidersServices
    {
        ResultEditSlidersServices Execute();
    }

    public class EditSlidersServices : IEditSlidersServices
    {
        private readonly IIdentityDataBaseContext _context;
        public EditSlidersServices(IIdentityDataBaseContext context)
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