using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mushrooms.Core;
using Mushrooms.Core.Interfaces;
using Mushrooms.Database.Identity;
using Mushrooms.Database.Seeds;
using System;
using System.Reflection;

namespace Mushrooms.Database.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>, IApplicationDbContext
    {
        public const string TRGM_EXT = "gin_trgm_ops";
        public const string GIN_INDEX = "gin";

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
#if DEBUG
            optionsBuilder
                .EnableSensitiveDataLogging()
                .LogTo(Console.WriteLine, LogLevel.Information);
#endif
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            if (Database.IsInMemory())
            {
                builder.Entity<Order>().Ignore(x => x.Address);
                builder.Entity<Order>().Ignore(x => x.Personal);

                builder.Entity<Category>().Ignore(x => x.CatalogColors);
                builder.Entity<Category>().Ignore(x => x.GridTheme);
                builder.Entity<Category>().Ignore(x => x.Name);
                builder.Entity<Category>().Ignore(x => x.Description);
                builder.Entity<Category>().Ignore(x => x.GridDescription);
                builder.Entity<Category>().Ignore(x => x.Seo);

                builder.Entity<InfoCategory>().Ignore(x => x.GridDescription);
                builder.Entity<InfoCategory>().Ignore(x => x.Title);
                builder.Entity<InfoCategory>().Ignore(x => x.Name);
                builder.Entity<InfoCategory>().Ignore(x => x.CatalogColors);
                builder.Entity<InfoCategory>().Ignore(x => x.GridTheme);
                builder.Entity<InfoCategory>().Ignore(x => x.Seo);

                builder.Entity<InfoItem>().Ignore(x => x.Title);
                builder.Entity<InfoItem>().Ignore(x => x.Description);
                builder.Entity<InfoItem>().Ignore(x => x.Seo);

                builder.Entity<Contact>().Ignore(x => x.Phone);
                builder.Entity<Contact>().Ignore(x => x.Address);
                builder.Entity<Contact>().Ignore(x => x.Schedule);
                builder.Entity<Contact>().Ignore(x => x.Seo);

                builder.Entity<InfoLink>().Ignore(x => x.Name);
                builder.Entity<InfoLink>().Ignore(x => x.Body);
                builder.Entity<InfoLink>().Ignore(x => x.Seo);

                builder.Entity<ItemBody>().Ignore(x => x.Title);
                builder.Entity<ItemBody>().Ignore(x => x.Body);
                builder.Entity<ItemBody>().Ignore(x => x.Seo);

                builder.Entity<QuantityType>().Ignore(x => x.Name);

                builder.Entity<PaymentOption>().Ignore(x => x.Title);
                builder.Entity<PaymentOption>().Ignore(x => x.OrderDescription);
                builder.Entity<PaymentOption>().Ignore(x => x.Subtitle);
                builder.Entity<PaymentOption>().Ignore(x => x.Description);

                builder.Entity<ShippingOption>().Ignore(x => x.Title);
                builder.Entity<ShippingOption>().Ignore(x => x.Description);

                builder.Entity<Product>().Ignore(x => x.Name);
                builder.Entity<Product>().Ignore(x => x.Description);
                builder.Entity<Product>().Ignore(x => x.ShortDescription);
                builder.Entity<Product>().Ignore(x => x.Characteristics);
                builder.Entity<Product>().Ignore(x => x.BulletedList);
                builder.Entity<Product>().Ignore(x => x.BasePrice);
                builder.Entity<Product>().Ignore(x => x.Mass);
                builder.Entity<Product>().Ignore(x => x.Seo);

                builder.Entity<SeoPage>().Ignore(x => x.Seo);
            }
            else
            {
                //builder.Entity<ProductLocalize>().Property(x => x.BulletedList).HasColumnType("jsonb");
                builder.Entity<Category>().Property(x => x.CatalogColors).HasColumnType("jsonb");
                builder.Entity<Category>().Property(x => x.GridTheme).HasColumnType("jsonb");
                builder.Entity<InfoCategory>().Property(x => x.CatalogColors).HasColumnType("jsonb");
                builder.Entity<InfoCategory>().Property(x => x.GridTheme).HasColumnType("jsonb");
                builder.Entity<Order>().Property(x => x.Address).HasColumnType("jsonb");
                builder.Entity<Order>().Property(x => x.Personal).HasColumnType("jsonb");
                builder.Entity<Product>().Property(x => x.BulletedList).HasColumnType("jsonb");

                builder.Entity<Category>().Property(x => x.Seo).HasColumnType("jsonb");
                builder.Entity<InfoCategory>().Property(x => x.Seo).HasColumnType("jsonb");
                builder.Entity<Product>().Property(x => x.Seo).HasColumnType("jsonb");
                builder.Entity<InfoItem>().Property(x => x.Seo).HasColumnType("jsonb");
                builder.Entity<ItemBody>().Property(x => x.Seo).HasColumnType("jsonb");
                builder.Entity<InfoLink>().Property(x => x.Seo).HasColumnType("jsonb");
                builder.Entity<SeoPage>().Property(x => x.Seo).HasColumnType("jsonb");
                builder.Entity<Contact>().Property(x => x.Seo).HasColumnType("jsonb");

            }

            builder.Entity<NewsletterSubscriber>().HasKey(x => x.Email);
            builder.Entity<Voucher>().HasKey(x => x.Code);

            builder.Entity<Media>().Property(e => e.Id)
                .HasIdentityOptions(startValue: 100);
        }
        public void SeedData()
        {
            ContactsSeed.Seed(this);
            PaymentSeed.Seed(this);
            ShippingSeed.Seed(this);
            QuantityTypeSeed.Seed(this);
            SeoPageSeed.Seed(this);

            MainCategoriesSeed.Seed(this);
            InfoCategoriesSeed.Seed(this);
        }

        public DbSet<Session> Sessions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<BasketProduct> BasketProducts { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<CallRequest> CallRequests { get; set; }
        public DbSet<NewsletterSubscriber> NewsletterSubscribers { get; set; }
        public DbSet<MessageRequest> MessageRequests { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<SeoPage> SeoPages { get; set; }        
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<InfoCategory> InfoCategories { get; set; }
        public DbSet<InfoItem> InfoItems { get; set; }
        public DbSet<QuantityType> QuantityTypes { get; set; }
        public DbSet<MassUnit> MassUnits { get; set; }
        public DbSet<ItemBody> ItemBodies { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<PaymentOption> PaymentOptions { get; set; }
        public DbSet<ShippingOption> ShippingOptions { get; set; }
        public DbSet<ProductViewed> ProductViewed { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Language> Languanges { get; set; }
    }
}
