using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mushrooms.Core;
using System.Collections.Generic;

namespace Mushrooms.Database.Data.Configurations
{
    public class ProviderConfiguration : IEntityTypeConfiguration<Provider>
    {
        public void Configure(EntityTypeBuilder<Provider> builder)
        {
            builder
             .HasData(new List<Provider>
             {
                    new Provider
                    {
                        Id = 1,
                        Name = "Provider 1"
                    },
                    new Provider
                    {
                        Id = 2,
                        Name = "Provider 2"
                    },
                      new Provider
                    {
                        Id = 3,
                        Name = "Provider 3"
                    }
         });
        }
    }
}
