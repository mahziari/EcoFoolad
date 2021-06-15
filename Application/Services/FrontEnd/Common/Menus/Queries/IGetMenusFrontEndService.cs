using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
 

namespace  Application.Services.FrontEnd.Common.Menus.Queries
{
    public interface IGetMenusFrontEndService
    {
        ResultGetMenusFrontEndDto Execute();
    }

    public class GetMenusFrontEndService : IGetMenusFrontEndService
    {
        private readonly IIdealCrmDataBaseContext _context;
        private readonly IDistributedCache _cache;

        public GetMenusFrontEndService(IIdealCrmDataBaseContext context, IDistributedCache cache)
        {
            _context = context;
            _cache = cache;
        }


        public ResultGetMenusFrontEndDto Execute()
        {
            // TODO Redis Cache
            List<GetMenu1Dto> menus;
            if (string.IsNullOrEmpty(_cache.GetString("IGetMenusFrontEndService_menus")))
            {
                menus = _context.ParsaPooladMenus
                    .Include(f => f.WsproductFirstGroup)
                    .Select(f => new GetMenu1Dto
                    {
                        ParsaPooladMenusId = f.ParsaPooladMenusId,
                        Name = f.Name,
                        EnName = f.UrlName,
                        Sub = f.WsproductFirstGroup
                            .Where(first => first.IsRemoved == null)
                            .Select(first => new GetMenu2Dto
                            {
                                PrdFirstGroupId = first.PrdFirstGroupId,
                                Fgname = first.Fgname,
                                EnFgname = first.EnFgname,
                                SubSub = first.WsproductSecondGroup
                                    .Where(seconds => seconds.IsRemoved == null)
                                    .Select(seconds => new GetMenu3Dto
                                    {
                                        WsproductSecondGroupId = seconds.PrdSecondGroupId,
                                        Sgname = seconds.Sgname,
                                        EnSgname = seconds.EnSgname.Replace(" ","-"),
                                    }).ToList()
                            }).ToList()
                    }).ToList();

                var options = new DistributedCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(15)
                };


                var jsonData = JsonConvert.SerializeObject(menus);
                _cache.SetString("IGetMenusFrontEndService_menus", jsonData, options);
            }
            else
            {
                var menusFromRedis = _cache.GetString("IGetMenusFrontEndService_menus");
                menus = JsonConvert.DeserializeObject<List<GetMenu1Dto>>(menusFromRedis);
            }

            return new ResultGetMenusFrontEndDto
            {
                Menus = menus,
            };
        }
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