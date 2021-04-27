using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Mushrooms.Core.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Provider> Providers { get; set; }
        DbSet<Manufacturer> Manufacturers { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Client> Clients { get; set; }
        DbSet<BasketProduct> BasketProducts { get; set; }
        DbSet<OrderProduct> OrderProducts { get; set; }
        DbSet<Media> Medias { get; set; }
        DbSet<CallRequest> CallRequests { get; set; }
        DbSet<NewsletterSubscriber> NewsletterSubscribers { get; set; }
        DbSet<MessageRequest> MessageRequests { get; set; }
        DbSet<InfoCategory> InfoCategories { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<SeoPage> SeoPages { get; set; }
        DbSet<InfoItem> InfoItems { get; set; }
        DbSet<Contact> Contacts { get; set; }
        DbSet<ItemBody> ItemBodies { get; set; }
        DbSet<Voucher> Vouchers { get; set; }
        DbSet<Basket> Baskets { get; set; }
        DbSet<PaymentOption> PaymentOptions { get; set; }
        DbSet<ShippingOption> ShippingOptions { get; set; }
        DbSet<ProductViewed> ProductViewed { get; set; }
        DbSet<Country> Countries { get; set; }
        DbSet<QuantityType> QuantityTypes { get; set; }
        DbSet<Language> Languanges { get; set; }

        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        int SaveChanges();
    }
}
