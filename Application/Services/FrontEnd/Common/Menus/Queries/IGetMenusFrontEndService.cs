using System.Collections.Generic;
using System.Threading.Tasks;


namespace  Application.Services.FrontEnd.Common.Menus.Queries
{
    public interface IGetMenusFrontEndService
    {
        ResultGetMenusFrontEndDto Execute();
    }

    public class ResultGetMenusFrontEndDto
    {
        public List<GetMenu1Dto> Menus { get; set; }
    }


    public class GetMenu1Dto
    {
        public int ParsaPooladMenusId { get; set; }
        public string Name { get; set; }
        public string EnName { get; set; }
        public string Icon { get; set; }
        public List<GetMenu2Dto> Sub { get; set; }
    }

    public class GetMenu2Dto
    {
        public int PrdFirstGroupId { get; set; }
        public string Fgname { get; set; }
        public string EnFgname { get; set; }
        public List<GetMenu3Dto> SubSub { get; set; }
    }

    public class GetMenu3Dto
    {
        public int WsproductSecondGroupId { get; set; }
        public string Sgname { get; set; }
        public string EnSgname { get; set; }
    }
}