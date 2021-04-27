using System.Collections.Generic;
using System.Text.Json;

namespace Mushrooms.Core
{
    public class ShippingOption
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public int Index { get; set; }

        public JsonDocument Title { get; set; }

        public JsonDocument Description { get; set; }

        public ICollection<Order> Order { get; set; }
    }
}
