
namespace Mushrooms.Core
{
    public class BasketProduct
    {
        public int ProductId { get; set; }

        public int OptionId { get; set; }

        public int Quantity { get; set; }

        public int BasketId { get; set; }

        public Product Product { get; set; }

        public Basket Basket { get; set; }
    }

}
