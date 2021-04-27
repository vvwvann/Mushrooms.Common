using Mushrooms.Core.Models;

namespace Mushrooms.Core.Interfaces
{
    public interface IQueryService
    {
        QueryStandart Query { get; set; }

        PaginationStandart Pagination { get; set; }
    }
}
