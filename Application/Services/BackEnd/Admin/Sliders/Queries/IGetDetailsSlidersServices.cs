using Application.Interfaces.Contexts;
 

namespace  Application.Services.BackEnd.Admin.Sliders.Queries
{
    public interface IGetDetailsSlidersServices
    {
        ResultGetDetailsSlidersServices Execute();
    }

    public class GetDetailsSlidersServices : IGetDetailsSlidersServices
    {
        private readonly ICustomDbContext _context;
        public GetDetailsSlidersServices(ICustomDbContext context)
        {
            _context = context;
        }

        public ResultGetDetailsSlidersServices Execute()
        {
            return new ResultGetDetailsSlidersServices
            {

            };
        }
    }



    public class ResultGetDetailsSlidersServices
    {
        public string Type { get; set; }
        public string Position { get; set; }
        public string Url { get; set; }
    }
}