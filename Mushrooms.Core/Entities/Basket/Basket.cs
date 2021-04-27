using System;
using System.Collections.Generic;

namespace Mushrooms.Core
{
    public class Basket
    {
        public int Id { get; set; }

        public decimal Discount { get; set; }

        public decimal TotalSum { get; set; }

        public decimal DeliveryCost { get; set; }

        public DateTime UpdatedAt { get; set; }

        public Client Client { get; set; }

        public ICollection<BasketProduct> Products { get; set; }

        public ICollection<Voucher> Vouchers { get; set; } = new List<Voucher>();
    }
}
