using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mushrooms.Core;

namespace Mushrooms.Database.Data.Configurations
{
    public class OrderProductConfiguration : IEntityTypeConfiguration<OrderProduct>
    {
        public void Configure(EntityTypeBuilder<OrderProduct> builder)
        {
            builder
            .HasKey(x => new { x.ProductId, x.OrderId, x.OptionId });

            builder
            .HasOne(pt => pt.Order)
            .WithMany(p => p.Products)
            .OnDelete(DeleteBehavior.Restrict)
            .HasForeignKey(pt => pt.OrderId);

            builder
            .HasOne(pt => pt.Product)
            .WithMany(p => p.Orders)
            .OnDelete(DeleteBehavior.Restrict)
            .HasForeignKey(pt => new { pt.ProductId, pt.OptionId });
        }
    }

}
