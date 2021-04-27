using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mushrooms.Core;

namespace Mushrooms.Database.Data.Configurations
{
    public class BasketConfiguration : IEntityTypeConfiguration<Basket>
    {
        public void Configure(EntityTypeBuilder<Basket> builder)
        {

            builder
               .HasOne(t => t.Client)
               .WithOne(x => x.Basket)
               .HasForeignKey<Client>(x => x.BasketId);
        }
    }
}
