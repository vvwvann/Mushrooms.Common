using Mushrooms.Core;
using System;

namespace Mushrooms.Core
{
    public class Transaction
    {
        public int Id { get; set; }

        public TransactionStatus Status { get; set; }

        public PaymentType Type { get; set; }

        public decimal Sum { get; set; }

        public int Attemp { get; set; }

        public DateTime Date { get; set; }
    }
}
