
using Mushrooms.Core.Interfaces;

namespace Mushrooms.Core.Models
{
    public class PaginationStandart : IPaginationStandart
    {
        public int Page { get; set; } = 1;

        public int Size { get; set; } = 20;
    }
}
