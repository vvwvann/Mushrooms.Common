using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mushrooms.Core
{
    public class Voucher
    {
        [Key]
        public string Code { get; set; }

        public double? Percent { get; set; }

        public decimal? Sum { get; set; }

        public DateTime From { get; set; } = DateTime.MinValue;

        public DateTime To { get; set; } = DateTime.MaxValue;

        public decimal MinSum { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
