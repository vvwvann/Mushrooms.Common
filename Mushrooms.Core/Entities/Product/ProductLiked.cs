using System;

namespace Mushrooms.Core
{
    public class ProductLiked
    {
        public int ProductId { get; set; }

        public int UserId { get; set; }

        public DateTime Time { get; set; }

        public Product Product { get; set; }
    }
}
