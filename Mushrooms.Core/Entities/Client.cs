using Mushrooms.Core;
using System;
using System.Collections.Generic;

namespace Mushrooms.Core
{
    public class Client
    {
        public int Id { get; set; }

        public string UserName { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string Phone { get; set; }
        public string Salutation { get; set; }
        public string Language { get; set; }
        public string LastName { get; set; }

        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime DeletedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public bool IsDeleted { get; set; }
        public bool IsBlocked { get; set; }

        public ClientType Type { get; set; }

        public int BasketId { get; set; }
        public Basket Basket { get; set; } = new Basket();

        public int? PhotoId { get; set; }

        public Media Photo { get; set; }

        public ICollection<ProductViewed> ProductViewed { get; set; }
        public ICollection<Product> Wishlists { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
