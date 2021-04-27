using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mushrooms.Core;
using System.Collections.Generic;

namespace Mushrooms.Database.Data.Configurations
{
    public class MassUnitConfiguration : IEntityTypeConfiguration<MassUnit>
    {
        public void Configure(EntityTypeBuilder<MassUnit> builder)
        {
            builder
             .HasData(new List<MassUnit>
             {
                    new MassUnit
                    {
                        Id = (int)MassUnitType.kg,
                        Name = "kg"
                    },
                    new MassUnit
                    {
                        Id = (int)MassUnitType.g,
                        Name = "g"
                    },
                      new MassUnit
                    {
                        Id = (int)MassUnitType.pcs,
                        Name = "pcs"
                    }
         });
        }
    }
}
