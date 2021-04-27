using System;
using System.Collections.Generic;

namespace Mushrooms.Core
{
    public class Order
    {
        public int Id { get; set; }

        public int ClientId { get; set; }

        public int? TransactionId { get; set; }

        public OrderStatus Status { get; set; } = OrderStatus.NEW;

        public PaymentStatus PaymentStatus { get; set; } = PaymentStatus.AWAITING;

        public decimal Price { get; set; }

        public decimal DeliveryPrice { get; set; }

        public decimal TotalSum { get; set; }

        public decimal Discount { get; set; }

        public string Comment { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime DeletedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime DeliveryDate { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Transaction Transaction { get; set; }

        public OrderPersonal Personal { get; set; }

        public OrderAddress Address { get; set; }

        public int ShippingId { get; set; }

        public int PaymentId { get; set; }

        public Client Client { get; set; }

        public PaymentOption Payment { get; set; }

        public ShippingOption Shipping { get; set; }

        public ICollection<OrderProduct> Products { get; set; }

        public ICollection<Voucher> Vouchers { get; set; }
    }

    public class OrderAddress
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
    }

    public class OrderPersonal
    {
        public string FirstName { get; set; }
        public string Phone { get; set; }
        public string Salutation { get; set; }
        public string LastName { get; set; }
    }
}
