using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Application.Interfaces.Contexts;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
 
using  Domain.Entities.IdealCrm;

namespace  Application.Services.FrontEnd.Home.Queries
{
    public interface IGetHomeFrontEndService
    {
        ResultGetHomeFrontEndDto Execute();
    }

    public class GetHomeFrontEndService : IGetHomeFrontEndService
    {
        private readonly IDistributedCache _cache;
        private readonly IIdealCrmDataBaseContext _idealCrmContext;
        private readonly ICustomDbContext _context;

        public GetHomeFrontEndService(IDistributedCache cache, IIdealCrmDataBaseContext idealCrmContext, ICustomDbContext context)
        {
            _cache = cache;
            _idealCrmContext = idealCrmContext;
            _context = context;
        }

        public ResultGetHomeFrontEndDto Execute()
        {
            List<GetSlidersDto> sliders;
            var slidersCachedValue=_cache.Get("IGetHomeFrontEndService_Sliders");
            if (slidersCachedValue!=null)
            {
                var slidersCachedEncoded = Encoding.UTF8.GetString(slidersCachedValue);
                sliders = JsonConvert.DeserializeObject<List<GetSlidersDto>>(slidersCachedEncoded);
            }
            else
            {
                sliders = _context.Sliders.Select(s => new GetSlidersDto
                {
                    Id = s.Id,
                    Type = s.Type,
                    Active = s.Active,
                    Position = s.Position,
                    Url = s.Url,
                }).ToList();

                
                var options = new DistributedCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(180));

                var jsonData = JsonConvert.SerializeObject(sliders);
                byte[] jsonMenusEncoded = Encoding.UTF8.GetBytes(jsonData);
                _cache.Set("IGetHomeFrontEndService_Sliders", jsonMenusEncoded, options);
            }


            var blogsGroup = _idealCrmContext.CrmCmsNewsGroups
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