using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsaPoolad.Common.Services
{
    public static class Pagination
    {
        public static IEnumerable<TSource> ToPaged<TSource>(this IEnumerable<TSource> source, int pageNumber, int pageSize, out int rowsCount)
        {
            rowsCount = source.Count();
            return source.Skip((pageNumber - 1) * pageSize).Take(pageSize);
        }
    }
}