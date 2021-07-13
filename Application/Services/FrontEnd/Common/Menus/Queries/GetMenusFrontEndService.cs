using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Application.Interfaces.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;

namespace Application.Services.FrontEnd.Common.Menus.Queries
{
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
            List<GetMenu1Dto> menus;
            var menusCachedValue=_cache.Get("IGetMenusFrontEndService_menus");
            if (menusCachedValue==null)
            {
                menus = _context.ParsaPooladMenus
                    .Include(f => f.WsproductFirstGroup)
                    .Select(f => new GetMenu1Dto
                    {
                        ParsaPooladMenusId = f.ParsaPooladMenusId,
                        Name = f.Name,
                        EnName = f.UrlName,
                        Icon = f.Icon,
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

                var options = new DistributedCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromMinutes(3));


                var jsonData = JsonConvert.SerializeObject(menus);
                byte[] jsonMenusEncoded = Encoding.UTF8.GetBytes(jsonData);
                _cache.Set("IGetMenusFrontEndService_menus", jsonMenusEncoded, options);
            }
            else
            {
                var menusCached = _cache.Get("IGetMenusFrontEndService_menus");
                var menusCachedEncoded = Encoding.UTF8.GetString(menusCached);
                menus = JsonConvert.DeserializeObject<List<GetMenu1Dto>>(menusCachedEncoded);
            }

            var blogsGroup = _context.CrmCmsNewsGroups.ToList();

            return new ResultGetMenusFrontEndDto
            {
                Menus = menus,
                BlogsGroup = blogsGroup,
            };
        }
    }
}