using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mushrooms.Core;

namespace Mushrooms.Database.Data.Configurations
{
    public class CategoriesConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category")
                .HasOne(pt => pt.Parent)
                .WithMany(p => p.SubCategories)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(pt => pt.ParentId);
        }
    }
}
