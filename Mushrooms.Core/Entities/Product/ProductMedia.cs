namespace Mushrooms.Core
{
    public class ProductMedia
    {
        public int ProductId { get; set; }

        public int MediaId { get; set; }

        public int Index { get; set; }

        public Product Product { get; set; }

        public Media Basket { get; set; }
    }
}
