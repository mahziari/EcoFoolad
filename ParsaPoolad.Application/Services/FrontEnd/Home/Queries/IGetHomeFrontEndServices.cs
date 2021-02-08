using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using ParsaPoolad.Application.Interfaces.Contexts;
using ParsaPoolad.Common.Extentions;

namespace ParsaPoolad.Application.Services.FrontEnd.Home.Queries
{
    public interface IGetHomeFrontEndService
    {
        ResultGetHomeFrontEndDto Execute();
    }

    public class GetHomeFrontEndService : IGetHomeFrontEndService
    {
        private readonly IDistributedCache _cache;
        private readonly IDataBaseContext _context;
        private readonly IIdentityDataBaseContext _parsapooladContext;

        public GetHomeFrontEndService(IDataBaseContext context,
            IIdentityDataBaseContext parsapooladContext,
            IDistributedCache cache)
        {
            _context = context;
            _parsapooladContext = parsapooladContext;
            _cache = cache;
        }

        public ResultGetHomeFrontEndDto Execute()
        {
            // TODO Redis Cache
            List<GetSlidersDto> sliders;
            if (string.IsNullOrEmpty(_cache.GetString("IGetHomeFrontEndService_Sliders")))
            {
                sliders = _parsapooladContext.Sliders.Select(s => new GetSlidersDto
                {
                    Id = s.Id,
                    Type = s.Type,
                    Active = s.Active,
                    Position = s.Position,
                    Url = s.Url,
                }).ToList();

                var options = new DistributedCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(15)
                };

                var jsonData = JsonConvert.SerializeObject(sliders);
                _cache.SetString("IGetHomeFrontEndService_Sliders", jsonData, options);
            }
            else
            {
                var slidersFromRedis = _cache.GetString("IGetHomeFrontEndService_Sliders");
                sliders = JsonConvert.DeserializeObject<List<GetSlidersDto>>(slidersFromRedis);
            }


            var blogsGroup = _context.CrmCmsNewsGroups
                .Select(g => new GetBlogsGroupDto
                {
                    Id = g.NewsGroupId,
                    Name = g.GroupName
                }).ToList();


            return new ResultGetHomeFrontEndDto
            {
                Sliders = sliders,
                BlogsGroup = blogsGroup,
            };
        }
    }

    public class ResultGetHomeFrontEndDto
    {
        public List<GetSlidersDto> Sliders { get; set; }
        public List<GetBlogsGroupDto> BlogsGroup { get; set; }
    }


    public class GetSlidersDto
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public bool Active { get; set; }
        public int Position { get; set; }
        public string Url { get; set; }
    }

    public class GetBlogsGroupDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}