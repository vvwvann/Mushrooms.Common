using Mushrooms.Core;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Mushrooms.Core
{
    public class Product
    {
        public int Id { get; set; }

        public int OptionId { get; set; }

        public string ItemNumber { get; set; }

        public double Raiting { get; set; }

        public double ShippingWeight { get; set; }

        public double ProductWeight { get; set; }

        public double DiscountPercent { get; set; }

        public decimal Price { get; set; }

        public bool AddToBasket { get; set; } = true;

        public int PreviewId { get; set; }

        public Media Preview { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime DeletedAt { get; set; }

        public Provider Provider { get; set; }

        public Manufacturer Manufacturer { get; set; }

        public int? ProviderId { get; set; }

        public int? ManufacturerId { get; set; }

        public string EAN { get; set; }

        public int QuantityId { get; set; }

        public JsonDocument Name { get; set; }

        public JsonDocument Description { get; set; }

        public JsonDocument ShortDescription { get; set; }

        public JsonDocument Characteristics { get; set; }

        public JsonDocument BulletedList { get; set; }

        public JsonDocument BasePrice { get; set; }

        public JsonDocument Mass { get; set; }

        public DeliveryStatus DeliveryStatus { get; set; } = DeliveryStatus.InStock;

        public ICollection<Category> Categories { get; set; }

        public ICollection<Product> Related { get; set; }

        public ICollection<OrderProduct> Orders { get; set; }

        public ICollection<Client> Wishlists { get; set; }

        public ICollection<Media> Media { get; set; }

        public Seo Seo { get; set; }

        public QuantityType Quantity { get; set; }

        public ICollection<BasketProduct> Baskets { get; set; }

        public ICollection<ProductViewed> ProductViewed { get; set; }

    }

    public class Reccomendation
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }
    }

    public class Provider
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Media Image { get; set; }

        public int? ImageId { get; set; }

        public ICollection<Product> Products { get; set; }
    }

    public class Manufacturer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Media Image { get; set; }

        public int? ImageId { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
