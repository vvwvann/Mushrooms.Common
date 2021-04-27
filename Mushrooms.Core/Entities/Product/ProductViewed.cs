using System;

namespace Mushrooms.Core
{
    public class ProductViewed
    {
        public int ProductId { get; set; }

        public int ClientId { get; set; }

        public int OptionId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Product Product { get; set; }

        public Client Client { get; set; }
    }
}
