using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mushrooms.Core;

namespace Mushrooms.Database.Data.Configurations
{
    public class BasketProductConfiguration : IEntityTypeConfiguration<BasketProduct>
    {
        public void Configure(EntityTypeBuilder<BasketProduct> builder)
        {
            builder
            .HasKey(x => new { x.ProductId, x.BasketId, x.OptionId });

            builder
            .HasOne(pt => pt.Basket)
            .WithMany(p => p.Products)
            .OnDelete(DeleteBehavior.Restrict)
            .HasForeignKey(pt => pt.BasketId);

            builder
            .HasOne(pt => pt.Product)
            .WithMany(p => p.Baskets)
            .OnDelete(DeleteBehavior.Restrict)
            .HasForeignKey(pt => new { pt.ProductId, pt.OptionId });
        }
    }
}
