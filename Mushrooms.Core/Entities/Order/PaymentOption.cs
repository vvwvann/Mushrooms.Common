using System.Collections.Generic;
using System.Text.Json;

namespace Mushrooms.Core
{
    public class PaymentOption
    {
        public int Id { get; set; }

        public int Index { get; set; }

        public JsonDocument Title { get; set; }

        public JsonDocument OrderDescription { get; set; }

        public JsonDocument Subtitle { get; set; }

        public JsonDocument Description { get; set; }

        public ICollection<Order> Order { get; set; }
    }
}
