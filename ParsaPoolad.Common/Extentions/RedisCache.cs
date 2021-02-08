// using System;
// using System.Text.Json;
// using System.Threading.Tasks;
// using Microsoft.Extensions.Caching.Distributed;
// using Newtonsoft.Json;
//
// namespace ParsaPoolad.Common.Extentions
// {
//     public static class RedisCache
//     {
//         public static async Task SetObjectAsync(  
//                 this IDistributedCache cache, string key, T value)  
//             {  
//                 await cache.SetStringAsync(key, JsonConvert.SerializeObject(value));  
//             }  
//   
//             public static async Task GetObjectAsync(  
//                 this IDistributedCache cache, string key)  
//             {  
//                 var value = await cache.GetStringAsync(key);  
//                 return value == null ? default(T) :  
//                     JsonConvert.DeserializeObject(value);  
//             }
//     }