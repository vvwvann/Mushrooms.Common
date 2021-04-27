using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mushrooms.Core;
using System.Collections.Generic;

namespace Mushrooms.Database.Data.Configurations
{
    public class VoucherConfiguration : IEntityTypeConfiguration<Voucher>
    {
        public void Configure(EntityTypeBuilder<Voucher> builder)
        {

            builder
              .HasData(new List<Voucher>
              {
                    new Voucher
                    {
                        Code = "PERCENT",
                        Percent = 10
                    },
                    new Voucher
                    {
                        Code = "SUM",
                        Sum = 10
                    }
              });

        }
    }
}
