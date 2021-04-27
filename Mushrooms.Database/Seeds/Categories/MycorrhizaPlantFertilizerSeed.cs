using Mushrooms.Core;
using Mushrooms.Core.Interfaces;
using Mushrooms.Database.Data.Extensions;
using System.Collections.Generic;
using Mushrooms.Core.Extensions;

namespace Mushrooms.Database.Seeds
{
    public static class MycorrhizaPlantFertilizerSeed
    {
        public static void Seed(IApplicationDbContext dbContext)
        {
            List<Media> medias = new List<Media> {
                new Media
                {
                    Id = 32,
                    PreviewPath = "http://5.189.140.208:5000/images/basil-genovese-seeds-from-organic-farming.jpg",
                    Path = "http://5.189.140.208:5000/images/basil-genovese-seeds-from-organic-farming.jpg"
                },
                new Media
                {
                    Id = 33,
                    PreviewPath =  "http://5.189.140.208:5000/images/bush-bean-maxi-seeds-from-organic-farming.jpg" ,
                    Path =  "http://5.189.140.208:5000/images/bush-bean-maxi-seeds-from-organic-farming.jpg"
                },
                new Media
                {
                    Id = 34,
                    PreviewPath = "http://5.189.140.208:5000/images/chili-pepper-habanero-tropical-red-seeds-from-organic-farming.jpg",
                    Path = "http://5.189.140.208:5000/images/chili-pepper-habanero-tropical-red-seeds-from-organic-farming.jpg"
                },
                new Media
                {
                    Id = 35,
                    PreviewPath = "http://5.189.140.208:5000/images/iceberg-lettuce-graz-cabbage-head-2-seeds-from-organic-farming.jpg",
                    Path = "http://5.189.140.208:5000/images/iceberg-lettuce-graz-cabbage-head-2-seeds-from-organic-farming.jpg"
                }
            };

            dbContext.Medias.AddOrUpdateRange(medias);
            dbContext.SaveChanges();

            List<Product> products = new List<Product>
            {
                new Product
                 {
                     Id = 501,
                     ItemNumber = "ANK-303",
                     ProductWeight = 0.200,
                     ShippingWeight = 0.250,
                     OptionId = 1,
                     Price = 3.1M,
                     PreviewId = 32,
                     Media = medias,
                     Name = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "Basil Genovese Seeds from organic Farming",
                             [LanguageType.DE] = "Basilikum Genovese Saatgut aus biologischem Anbau"
                         }.ToJsonDocument(),
                         Description = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "Annual, warmth loving, 20-40cm-high, light germinator. Sowing: first crop from middle of April, transplant 2 - 3 plants together or direct drilling from end of May. 3 - 4g for 1000 plants.Spacing: 20x20cm.",
                             [LanguageType.DE] = "Einjährig, wärmeliebend, 20-40 cm hoch, Lichtkeimer. Aussaat: Vorkultur ab Mitte April, 2-3 Pflanzen gemeinsam pikieren oder Direktsaat ab Ende Mai. 3-4g für 1000 Pflanzen. Abstände: Pflanzabstand 20x20 cm.",
                         }.ToJsonDocument(),
                         ShortDescription = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "Annual, warmth loving, 20-40cm-high, light germinator.",
                             [LanguageType.DE] = "Einjährig, wärmeliebend, 20-40 cm hoch, Lichtkeimer."
                         }.ToJsonDocument(),
                         BasePrice = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "30 g pack (13,25€)",
                             [LanguageType.DE] = "30 g pack (13,25€)"
                         }.ToJsonDocument(),
                         Mass = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "200 g",
                             [LanguageType.DE] = "200 g"
                         }.ToJsonDocument(),
                         Characteristics = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "Das Austernpilz-Pilzpulver enthält alle Inhaltsstoffe des Pleurotus ostreatus in der natürlichen Konzentration und Zusammensetzung.",
                             [LanguageType.DE] = "Das Austernpilz-Pilzpulver enthält alle Inhaltsstoffe des Pleurotus ostreatus in der natürlichen Konzentration und Zusammensetzung."
                         }.ToJsonDocument(),
                         BulletedList = new Dictionary<string, List<string>>
                         {
                             [LanguageType.EN] = new List<string> { "0,44 € per 1 g", "including 13% VAT. , plus shipping", "available now", "delivery status: 2 - 3 Weeks lead time" },
                             [LanguageType.DE] = new List<string> { "0,44 € per 1 g", "including 13% VAT. , plus shipping", "available now", "delivery status: 2 - 3 Weeks lead time" }
                         }.ToJsonDocument(),
                        Seo = new Seo
                            {
                            Title = new Dictionary<string, string>
                                {
                                    [LanguageType.EN] = "en_title",
                                    [LanguageType.DE] = "de_title"
                                }.ToJsonDocument(),
                            Keys = new Dictionary<string, string>
                                {
                                    [LanguageType.EN] = "en_keys",
                                    [LanguageType.DE] = "de_keys"
                                }.ToJsonDocument(),
                            Desc = new Dictionary<string, string>
                                {
                                    [LanguageType.EN] = "en_desc",
                                    [LanguageType.DE] = "de_desc"
                                }.ToJsonDocument()
                        },
                         QuantityId = (int)QuantityTypes.Piece
                 },  
                new Product
                 {
                     Id = 502,
                     ItemNumber = "ANK-303",
                     ProductWeight = 1.5,
                     ShippingWeight = 2,
                     OptionId = 1,
                     Price = 3.1M,
                     DiscountPercent = 10,
                     PreviewId = 33,
                     Media = medias,
                     Name = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "Bush Bean Maxi Seeds from organic Farming",
                             [LanguageType.DE] = "Buschbohnen Maxi Saatgut aus biologischem Anbau"
                         }.ToJsonDocument(),
                         Description = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "Erect growth with 18-20cm round runner beans (clucking type) hanging above the leaves. The freely suspended bush beans are easily plucked. Very early with a high yield and also suitable for forcing.",
                             [LanguageType.DE] = "Aufrechter Wuchs mit über dem Laub hängenden, 18-20 cm langen, runden Fisolen (Gluckentyp). Die freihängenden Fisolen lassen sich leicht pflücken. Sehr früh mit hohem Ertrag. Auch zum Treiben geeignet.",
                         }.ToJsonDocument(),
                         ShortDescription = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "The freely suspended bush beans are easily plucked. Very early with a high yield.",
                             [LanguageType.DE] = "Die freihängenden Fisolen lassen sich leicht pflücken. Sehr früh mit hohem Ertrag."
                         }.ToJsonDocument(),
                         BasePrice = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "30 g pack (13,25€)",
                             [LanguageType.DE] = "30 g pack (13,25€)"
                         }.ToJsonDocument(),
                         Mass = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "200 g",
                             [LanguageType.DE] = "200 g"
                         }.ToJsonDocument(),
                         Characteristics = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "Das Austernpilz-Pilzpulver enthält alle Inhaltsstoffe des Pleurotus ostreatus in der natürlichen Konzentration und Zusammensetzung.",
                             [LanguageType.DE] = "Das Austernpilz-Pilzpulver enthält alle Inhaltsstoffe des Pleurotus ostreatus in der natürlichen Konzentration und Zusammensetzung."
                         }.ToJsonDocument(),
                         BulletedList = new Dictionary<string, List<string>>
                         {
                             [LanguageType.EN] = new List<string> { "0,44 € per 1 g", "including 13% VAT. , plus shipping", "available now", "delivery status: 2 - 3 Weeks lead time" },
                             [LanguageType.DE] = new List<string> { "0,44 € per 1 g", "including 13% VAT. , plus shipping", "available now", "delivery status: 2 - 3 Weeks lead time" }
                         }.ToJsonDocument(),
                         Seo = new Seo
                            {
                            Title = new Dictionary<string, string>
                                {
                                    [LanguageType.EN] = "en_title",
                                    [LanguageType.DE] = "de_title"
                                }.ToJsonDocument(),
                            Keys = new Dictionary<string, string>
                                {
                                    [LanguageType.EN] = "en_keys",
                                    [LanguageType.DE] = "de_keys"
                                }.ToJsonDocument(),
                            Desc = new Dictionary<string, string>
                                {
                                    [LanguageType.EN] = "en_desc",
                                    [LanguageType.DE] = "de_desc"
                                }.ToJsonDocument()
                        },
                         QuantityId = (int)QuantityTypes.Pack
                 },
                new Product
                 {
                     Id = 503,
                     ItemNumber = "ANK-303",
                     ProductWeight = 1.5,
                     ShippingWeight = 2,
                     OptionId = 1,
                     Price = 3.1M,
                     DiscountPercent = 10,
                     PreviewId = 34,
                     Media = medias,
                     Name = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "Chili Pepper Habanero Tropical Red Seeds from organic Farming",
                             [LanguageType.DE] = "Chili Habanero Tropical Red Saatgut aus biologischem Anbau"
                         }.ToJsonDocument(),
                         Description = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "One of the hottest chilli peppers. The plants grow 1.2 m tall. The fruits are thin-walled, round and long, wrinkly, up to 5-6 cm long and 3 cm wide. As they ripen the fruits turn from light green to orange, and finally to an intense red. Tropical aromatic taste. Relatively early maturing and high yielding. Habanero can over winter as a pot plant. Heat rating 10 on a scale from 1 to 10.",
                             [LanguageType.DE] = "Eine der schärfsten aller Chili-Sorten. Die Pflanzen werden bis zu 1,2 m hoch. Die Früchte sind dünnwandig, rundlich bis länglich, faltig und werden ca. 5 - 6 cm lang und ca. 3 cm breit. Die Früchte reifen von hellgrün über orange zu einem intensiven Rot. Tropisch-fruchtig-aromatischer Geschmack. Relativ früh reifend und sehr ertragreich. Schärfegrad 10 auf einer Skala von 1-10. Habanero kann als Topfpflanze überwintert werden.",
                         }.ToJsonDocument(),
                         ShortDescription = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "One of the hottest chilli peppers. Tropical fruity aromatic taste",
                             [LanguageType.DE] = "Eine der schärfsten aller Chili-Sorten. Tropisch-fruchtig-aromatischer Geschmack."
                         }.ToJsonDocument(),
                         BasePrice = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "30 g pack (13,25€)",
                             [LanguageType.DE] = "30 g pack (13,25€)"
                         }.ToJsonDocument(),
                         Mass = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "200 g",
                             [LanguageType.DE] = "200 g"
                         }.ToJsonDocument(),
                         Characteristics = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "Synonyms: Oyster Mushroom, Hiratake, Tamogitake, Píng Gu, Sadafi, Chippikkoon, Oyster Shelf, Tree Oyster, Straw Mushroom",
                             [LanguageType.DE] = "Das Austernpilz-Pilzpulver enthält alle Inhaltsstoffe des Pleurotus ostreatus in der natürlichen Konzentration und Zusammensetzung."
                         }.ToJsonDocument(),
                         BulletedList = new Dictionary<string, List<string>>
                         {
                             [LanguageType.EN] = new List<string> { "0,44 € per 1 g", "including 13% VAT. , plus shipping", "available now", "delivery status: 2 - 3 Weeks lead time" },
                             [LanguageType.DE] = new List<string> { "0,44 € per 1 g", "including 13% VAT. , plus shipping", "available now", "delivery status: 2 - 3 Weeks lead time" }
                         }.ToJsonDocument(),
                          Seo = new Seo
                            {
                            Title = new Dictionary<string, string>
                                {
                                    [LanguageType.EN] = "en_title",
                                    [LanguageType.DE] = "de_title"
                                }.ToJsonDocument(),
                            Keys = new Dictionary<string, string>
                                {
                                    [LanguageType.EN] = "en_keys",
                                    [LanguageType.DE] = "de_keys"
                                }.ToJsonDocument(),
                            Desc = new Dictionary<string, string>
                                {
                                    [LanguageType.EN] = "en_desc",
                                    [LanguageType.DE] = "de_desc"
                                }.ToJsonDocument()
                        },
                         QuantityId = (int)QuantityTypes.Pack
                 },
                new Product
                 {
                     Id = 504,
                     ItemNumber = "ANK-303",
                     ProductWeight = 1.5,
                     ShippingWeight = 2,
                     OptionId = 1,
                     Price = 3.1M,
                     DiscountPercent = 50,
                     PreviewId = 35,
                     Media = medias,
                     Name = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "Iceberg Lettuce Graz Cabbage Head 2 Seeds from organic Farming.",
                             [LanguageType.DE] = "Eissalat Grazer Krauthäuptel 2 Saatgut aus biologischem Anbau"
                         }.ToJsonDocument(),
                         Description = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "Well-known Austrian variety. Crisp lettuce with light-green, crisp leaves and a slightly red edge. Develops medium-large to large, firm heads. Good mildew tolerance and bolt-resistant. Cultivation from spring to autumn.",
                             [LanguageType.DE] = "Bekannte österreichische Sorte. Krachsalat mit hellgrünen, knackigen Blättern und leicht rotem Rand. Entwickelt mittelgroße bis große, feste Köpfe. Gute Mehltautoleranz und Schossfestigkeit. Anbau Frühjahr bis Herbst.",
                         }.ToJsonDocument(),
                         ShortDescription = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "Well-known Austrian variety. Develops medium-large to large, firm heads.",
                             [LanguageType.DE] = "Bekannte österreichische Sorte. Entwickelt mittelgroße bis große, feste Köpfe."
                         }.ToJsonDocument(),
                         BasePrice = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "30 g pack (13,25€)",
                             [LanguageType.DE] = "30 g pack (13,25€)"
                         }.ToJsonDocument(),
                         Mass = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "200 g",
                             [LanguageType.DE] = "200 g"
                         }.ToJsonDocument(),
                         Characteristics = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "Synonyms: Oyster Mushroom, Hiratake, Tamogitake, Píng Gu, Sadafi, Chippikkoon, Oyster Shelf, Tree Oyster, Straw Mushroom",
                             [LanguageType.DE] = "Das Austernpilz-Pilzpulver enthält alle Inhaltsstoffe des Pleurotus ostreatus in der natürlichen Konzentration und Zusammensetzung."
                         }.ToJsonDocument(),
                         BulletedList = new Dictionary<string, List<string>>
                         {
                             [LanguageType.EN] = new List<string> { "0,44 € per 1 g", "including 13% VAT. , plus shipping", "available now", "delivery status: 2 - 3 Weeks lead time" },
                             [LanguageType.DE] = new List<string> { "0,44 € per 1 g", "including 13% VAT. , plus shipping", "available now", "delivery status: 2 - 3 Weeks lead time" }
                         }.ToJsonDocument(),
                         Seo = new Seo
                            {
                            Title = new Dictionary<string, string>
                                {
                                    [LanguageType.EN] = "en_title",
                                    [LanguageType.DE] = "de_title"
                                }.ToJsonDocument(),
                            Keys = new Dictionary<string, string>
                                {
                                    [LanguageType.EN] = "en_keys",
                                    [LanguageType.DE] = "de_keys"
                                }.ToJsonDocument(),
                            Desc = new Dictionary<string, string>
                                {
                                    [LanguageType.EN] = "en_desc",
                                    [LanguageType.DE] = "de_desc"
                                }.ToJsonDocument()
                        },
                         QuantityId = (int)QuantityTypes.Pack
                 }
            };


            dbContext.Products.AddOrUpdateRange(products);

            List<Category> categories = new()
            {
                new Category
                {
                    Id = 5,
                    Index = 3,
                    Image = "http://5.189.140.208:5000/images/Mushroom-supplements.jpg",
                    GridTheme = new GridTheme
                    {
                       Color = "#FF7555",
                       Image = "http://5.189.140.208:3000/img/fertilizer.png"
                    },
                    CatalogColors = new CategoryTheme
                    {
                        TopBar = "#0D143F",
                        Categories = "#FF7555",
                    },
                    Products = products,
                    Name = new Dictionary<string, string>
                    {
                        [LanguageType.EN] = "Mycorrhiza Plant Fertilizer",
                        [LanguageType.DE] = "Mykorrhiza Pflanzendünger"
                    }.ToJsonDocument(),
                    Description = new Dictionary<string, string>
                    {
                        [LanguageType.EN] = "Soil fungi that boost natural and healthy plant growth.",
                        [LanguageType.DE] = "Mykorrhiza-Bodenpilze für ein natürliches und gesundes Pflanzenwachstum",
                    }.ToJsonDocument(),
                    GridDescription = new Dictionary<string, string>
                    {
                        [LanguageType.EN] = "Soil fungi that boost natural and healthy plant growth.",
                        [LanguageType.DE] = "Mykorrhiza-Bodenpilze für ein natürliches und gesundes Pflanzenwachstum."
                    }.ToJsonDocument(),
                    Seo = new Seo
                    {
                        Title = new Dictionary<string, string>
                        {
                            [LanguageType.EN] = "en_title",
                            [LanguageType.DE] = "de_title"
                        }.ToJsonDocument(),
                        Keys = new Dictionary<string, string>
                        {
                            [LanguageType.EN] = "en_keys",
                            [LanguageType.DE] = "de_keys"
                        }.ToJsonDocument(),
                        Desc = new Dictionary<string, string>
                        {
                            [LanguageType.EN] = "en_desc",
                            [LanguageType.DE] = "de_desc"
                        }.ToJsonDocument()
                    },
                }
            };

            dbContext.Categories.AddOrUpdateRange(categories);
            dbContext.SaveChanges();
        }
    }
}
