namespace Mushrooms.Core
{
    public class OrderItem
    {
        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public int OptionId { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public double DiscountPercent { get; set; }

        public Product Product { get; set; }

        public Order Order { get; set; }
    }
}
