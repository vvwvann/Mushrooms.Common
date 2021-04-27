using Mushrooms.Core;
using Mushrooms.Core.Interfaces;
using Mushrooms.Database.Data.Extensions;
using System.Collections.Generic;
using Mushrooms.Core.Extensions;

namespace Mushrooms.Database.Seeds
{
    public static class QuantityTypeSeed
    {
        public static void Seed(IApplicationDbContext dbContext)
        {
            var list = new List<QuantityType>
            {
               new QuantityType
                    {
                        Id = (int)QuantityTypes.Pack,
                        Name = new Dictionary<string, string>{
                          [LanguageType.EN] =  "pack(s)",
                          [LanguageType.DE] = "Pkg."
                        }.ToJsonDocument()
                    },
                    new QuantityType
                    {
                        Id = (int)QuantityTypes.Bag,
                        Name = new Dictionary<string, string>{
                          [LanguageType.EN] =  "bag(s)",
                          [LanguageType.DE] = "Stack"
                        }.ToJsonDocument()
                    },
                    new QuantityType
                    {
                        Id = (int)QuantityTypes.Piece,
                        Name = new Dictionary<string, string>{
                          [LanguageType.EN] =  "piece(s)",
                          [LanguageType.DE] = "Stk."
                        }.ToJsonDocument()
                    }            
            };

            dbContext.QuantityTypes.AddOrUpdateRange(list);
            dbContext.SaveChanges();
        }
    }
}


