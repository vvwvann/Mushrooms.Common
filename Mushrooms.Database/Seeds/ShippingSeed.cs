using Mushrooms.Core;
using Mushrooms.Core.Interfaces;
using Mushrooms.Database.Data.Extensions;
using System.Collections.Generic;
using Mushrooms.Core.Extensions;

namespace Mushrooms.Database.Seeds
{
    public static class ShippingSeed
    {
        public static void Seed(IApplicationDbContext dbContext)
        {
            var list = new List<ShippingOption>
            {
                    new ShippingOption
                    {
                        Id = 1,
                        Price = 4.99m,
                        Index = 1,
                        Title = new Dictionary<string, string>
                        {
                            [LanguageType.EN] = "Österreichische Post.at",
                            [LanguageType.DE] = "Österreichische Post.at"
                        }.ToJsonDocument(),
                        Description = new Dictionary<string, string>
                        {
                            [LanguageType.EN] = "Shipping with Austrian Postal Service.",
                            [LanguageType.DE] = "Versand mit österreichischer Post.",
                        }.ToJsonDocument()
                    },
                     new ShippingOption
                    {
                        Id = 2,
                        Price = 12,
                        Index = 2,
                        Title = new Dictionary<string, string>
                        {
                            [LanguageType.EN] = "Option 2",
                            [LanguageType.DE] = "Option 2"
                        }.ToJsonDocument(),
                        Description = new Dictionary<string, string>
                        {
                            [LanguageType.EN] = "Shipping with Austrian Postal Service.",
                            [LanguageType.DE] = "Versand mit österreichischer Post.",
                        }.ToJsonDocument()
                    },
            };

            dbContext.ShippingOptions.AddOrUpdateRange(list);
            dbContext.SaveChanges();
        }
    }

}


