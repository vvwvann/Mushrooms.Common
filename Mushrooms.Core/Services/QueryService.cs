using Mushrooms.Core.Interfaces;
using Mushrooms.Core.Models;

namespace Mushrooms.Core.Services
{
    public class QueryService : IQueryService
    {
        public QueryStandart Query { get; set; } = new();
        public PaginationStandart Pagination { get; set; } = new();
    }
}
