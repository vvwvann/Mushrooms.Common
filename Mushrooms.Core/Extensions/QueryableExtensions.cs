using Microsoft.EntityFrameworkCore;
using Mushrooms.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mushrooms.Core.Extensions
{
    public static class QueryableExtensions
    {
        public static async Task<List<T>> PaginateAsync<T>(
            this IQueryable<T> source,
            IPaginationStandart pagination)
        {
            return await source
                .Skip((pagination.Page - 1) * pagination.Size)
                .Take(pagination.Size)
                .ToListAsync();
        }
    }
}
