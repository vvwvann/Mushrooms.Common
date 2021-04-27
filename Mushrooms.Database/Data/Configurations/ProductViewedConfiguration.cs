using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mushrooms.Core;

namespace Mushrooms.Database.Data.Configurations
{
    public class ProductViewedConfiguration : IEntityTypeConfiguration<ProductViewed>
    {
        public void Configure(EntityTypeBuilder<ProductViewed> builder)
        {
            builder.HasKey(x => new { x.ProductId, x.ClientId, x.OptionId });

            builder
             .HasOne(pt => pt.Client)
             .WithMany(p => p.ProductViewed)
             .OnDelete(DeleteBehavior.Restrict)
             .HasForeignKey(pt => pt.ClientId);

            builder
            .HasOne(pt => pt.Product)
            .WithMany(p => p.ProductViewed)
            .OnDelete(DeleteBehavior.Restrict)
            .HasForeignKey(pt => new { pt.ProductId, pt.OptionId });
        }
    }
}
