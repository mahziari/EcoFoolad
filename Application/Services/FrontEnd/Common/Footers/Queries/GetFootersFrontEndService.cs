using System;
using System.Linq;
using System.Text;
using Application.Interfaces.Contexts;
using AutoMapper;
using Domain.Entities;
using Domain.Entities.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;

namespace Application.Services.FrontEnd.Common.Footers.Queries
{
    public class GetFootersFrontEndService:IGetFootersFrontEndService
    {
        private readonly ICustomDbContext _customDbContext;
        private readonly IMapper _mapper;
        private readonly IDistributedCache _cache;

        public GetFootersFrontEndService(ICustomDbContext customDbContext, IMapper mapper, IDistributedCache cache)
        {
            _customDbContext = customDbContext;
            _mapper = mapper;
            _cache = cache;
        }
        
        

        public BaseDto<FooterFrontEndDto> GetFootersFrontEnd()
        {
            FooterFrontEndDto data = null;
            var footersCachedValue=_cache.Get("IGetFootersFrontEndService_footers");
            if (footersCachedValue == null)
            {
                var model = _customDbContext.Footers.FirstOrDefault();
                data = _mapper.Map<FooterFrontEndDto>(model);
                
                
                var options = new DistributedCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromDays(6));
                
                var jsonData = JsonConvert.SerializeObject(data);
                byte[] jsonFootersEncoded = Encoding.UTF8.GetBytes(jsonData);
                _cache.Set("IGetFootersFrontEndService_footers", jsonFootersEncoded, options);
            }
            else
            {
                var footersCached = _cache.Get("IGetFootersFrontEndService_footers");
                var footersCachedEncoded = Encoding.UTF8.GetString(footersCached);
                data = JsonConvert.DeserializeObject<FooterFrontEndDto>(footersCachedEncoded);
            }

            return new BaseDto<FooterFrontEndDto>
            (
                true,
                null,
                data
            );
        }
    }
}