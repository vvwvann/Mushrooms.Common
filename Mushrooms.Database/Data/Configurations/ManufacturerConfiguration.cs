using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mushrooms.Core;
using System.Collections.Generic;

namespace Mushrooms.Database.Data.Configurations
{
    public class ManufacturerConfiguration : IEntityTypeConfiguration<Manufacturer>
    {
        public void Configure(EntityTypeBuilder<Manufacturer> builder)
        {
            builder
             .HasData(new List<Manufacturer>
             {
                    new Manufacturer
                    {
                        Id = 1,
                        Name = "Manufacturer 1"
                    },
                    new Manufacturer
                    {
                        Id = 2,
                        Name = "Manufacturer 2"
                    },
                      new Manufacturer
                    {
                        Id = 3,
                        Name = "Manufacturer 3"
                    }
         });
        }
    }
}
