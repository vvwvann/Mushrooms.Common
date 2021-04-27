using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mushrooms.Core;

namespace Mushrooms.Database.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => new { x.Id, x.OptionId });

            builder
             .HasMany(t => t.Media)
             .WithMany(x => x.Products);

            builder
                .HasOne(t => t.Preview)
                .WithMany()
                .HasForeignKey(x => x.PreviewId);
        }
    }
}
