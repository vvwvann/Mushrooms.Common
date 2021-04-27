using Mushrooms.Core;
using Mushrooms.Core.Interfaces;
using Mushrooms.Database.Data.Extensions;
using System.Collections.Generic;
using Mushrooms.Core.Extensions;

namespace Mushrooms.Database.Seeds
{
    public static class MushroomSpeciesSeed
    {
        public static void Seed(IApplicationDbContext dbContext)
        {
            List<Media> medias = new List<Media> {
                new Media
                {
                    Id = 11,
                    PreviewPath = "http://5.189.140.208:5000/images/basil-genovese-seeds-from-organic-farming.jpg",
                    Path = "http://5.189.140.208:5000/images/basil-genovese-seeds-from-organic-farming.jpg"
                },
                new Media
                {
                    Id = 12,
                    PreviewPath =  "http://5.189.140.208:5000/images/bush-bean-maxi-seeds-from-organic-farming.jpg" ,
                    Path =  "http://5.189.140.208:5000/images/bush-bean-maxi-seeds-from-organic-farming.jpg"
                },
                new Media
                {
                    Id = 13,
                    PreviewPath = "http://5.189.140.208:5000/images/chili-pepper-habanero-tropical-red-seeds-from-organic-farming.jpg",
                    Path = "http://5.189.140.208:5000/images/chili-pepper-habanero-tropical-red-seeds-from-organic-farming.jpg"
                },
                new Media
                {
                    Id = 14,
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
                     Id = 701,
                     ProductWeight = 12.1,
                     ShippingWeight = 12.2,
                     OptionId = 1,
                     Price = 15.3M,
                     ItemNumber = "AJK-34",
                     PreviewId = 11,
                     Media = medias,
                     Name = new Dictionary<string, string>
                        {
                             [LanguageType.EN] = "Tree oyster - Pleurotus ostreatus - spawn dowels for organic growing acc. to Regulation EC 834/2007 and 889/2008, AT-BIO-301 Strain Nr.: 101001",
                             [LanguageType.DE] = "Tree oyster - Pleurotus ostreatus - spawn dowels for organic growing acc. to Regulation EC 834/2007 and 889/2008, AT-BIO-301 Strain Nr.: 101001"
                        }.ToJsonDocument(),
                        Description = new Dictionary<string, string>
                        {
                             [LanguageType.EN] = "The Tree Oyster is very simple in cultivation. The mycelium of this pleurotus species is very robust; therefore it is popular in commercial cultivation.",
                             [LanguageType.DE] = "The Tree Oyster is very simple in cultivation. The mycelium of this pleurotus species is very robust; therefore it is popular in commercial cultivation.",
                        }.ToJsonDocument(),
                        ShortDescription = new Dictionary<string, string>
                        {
                             [LanguageType.EN] = "Tree oyster mushroom wood dowel spawn for inoculation of tree stems.",
                             [LanguageType.DE] = "Tree oyster mushroom wood dowel spawn for inoculation of tree stems."
                        }.ToJsonDocument(),
                        BasePrice = new Dictionary<string, string>
                        {
                             [LanguageType.EN] = "30 g pack (13,25€)",
                             [LanguageType.DE] = "30 g pack (13,25€)"
                        }.ToJsonDocument(),
                        Mass = new Dictionary<string, string>
                        {
                             [LanguageType.EN] = "12 kg",
                             [LanguageType.DE] = "12 kg"
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
                     Id = 702,
                     ProductWeight = 1.5,
                     ShippingWeight = 2,
                     OptionId = 1,
                     Price = 15.3M,
                     DiscountPercent = 10,
                     ItemNumber = "AJK-34",
                     PreviewId = 12,
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
                             [LanguageType.EN] = "1.5 kg",
                             [LanguageType.DE] = "1.5 kg"
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
                     Id = 703,
                     ProductWeight = 1.5,
                     ShippingWeight = 2,
                     OptionId = 1,
                     Price = 3.1M,
                     DiscountPercent = 10,
                     PreviewId = 13,
                     Media = medias,
                     ItemNumber = "AJK-34",
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
                             [LanguageType.EN] = "One of the hottest chilli peppers. Tropical fruity aromatic taste.",
                             [LanguageType.DE] = "Eine der schärfsten aller Chili-Sorten. Tropisch-fruchtig-aromatischer Geschmack."
                        }.ToJsonDocument(),
                        BasePrice = new Dictionary<string, string>
                        {
                             [LanguageType.EN] = "30 g pack (13,25€)",
                             [LanguageType.DE] = "30 g pack (13,25€)"
                        }.ToJsonDocument(),
                        Mass = new Dictionary<string, string>
                        {
                             [LanguageType.EN] = "1.5 kg",
                             [LanguageType.DE] = "1.5 kg"
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
                     Id = 704,
                     ProductWeight = 1.5,
                     ShippingWeight = 2,
                     OptionId = 1,
                     Price = 3.1M,
                     DiscountPercent = 10,
                     PreviewId = 14,
                     ItemNumber = "AJK-34",
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
                             [LanguageType.EN] = "1.5 kg",
                             [LanguageType.DE] = "1.5 kg"
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
                 }
            };


            dbContext.Products.AddOrUpdateRange(products);

            List<Category> categories = new()
            {
                new Category
                {
                    Id = 7,
                    Index = 4,
                    GridTheme = new GridTheme
                    {
                       Color = "#4BC7CF",
                       Image = "http://5.189.140.208:3000/img/cultivation.png"
                    },
                    CatalogColors =  new CategoryTheme
                    {
                        TopBar = "#188287",
                        Categories = "#4BC9CF"
                    },
                    Products = products,
                    Name = new Dictionary<string, string>
                    {
                        [LanguageType.EN] = "Mushroom species",
                        [LanguageType.DE] = "Plizarten"
                    }.ToJsonDocument(),
                    Description = new Dictionary<string, string>
                    {
                        [LanguageType.EN] = "All products classified by mushroom species.",
                        [LanguageType.DE] = "Bio Pilze getrocknet, Pilzdelikatessen und Trüffelprodukte in höchster Qualität.",
                    }.ToJsonDocument(),
                    GridDescription = new Dictionary<string, string>
                    {
                        [LanguageType.EN] = "All products classified by mushroom species.",
                        [LanguageType.DE] = "Bio Pilze getrocknet, Pilzdelikatessen und Trüffelprodukte in höchster Qualität."
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
                },
                new Category
                {
                    Id = 8,
                    ParentId = 7,
                    Image = "http://5.189.140.208:5000/images/Mushroom-supplements.jpg",
                    CatalogColors =  new CategoryTheme
                    {
                        TopBar = "#188287",
                        Categories = "#4BC9CF"
                    },
                    Products = products,
                    Name = new Dictionary<string, string>
                    {
                        [LanguageType.EN] = "Tree Oyster - pleurotus ostreatus",
                        [LanguageType.DE] = "Austernpilz - Pleurotus ostreatus"
                    }.ToJsonDocument(),
                    Description = new Dictionary<string, string>
                    {
                        [LanguageType.EN] = "Synonyms: Pleurotus ostreatus Oyster Mushroom, Hiratake, Tamogitake, Píng Gu, Sadafi, Chippikkoon",
                        [LanguageType.DE] = "Synonyme: Pleurotus ostreatus, Austernseitling, Hiratake, Tamogitake, Píng Gu, Sadafi, Chippikkoon",
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
                },
                new Category
                {
                    Id = 9,
                    ParentId = 7,
                    Image = "http://5.189.140.208:5000/images/Mushroom-supplements.jpg",
                    CatalogColors =  new CategoryTheme
                    {
                        TopBar = "#188287",
                        Categories = "#4BC9CF"
                    },
                    Products = products,
                    Name = new Dictionary<string, string>
                    {
                        [LanguageType.EN] = "King oyster - Pleurotus eryngii",
                        [LanguageType.DE] = "Kräuterseitling - Pleurotus eryngii"
                    }.ToJsonDocument(),
                    Description = new Dictionary<string, string>
                    {
                        [LanguageType.EN] = "The King Oyster Mushroom produces fruiting bodies with a very delicious taste. The texture of the flesh is comparable to boletus. For cooking you can use Eryngii like boletus. Eryngii produces fruiting bodies with diamter 3-10 cm;",
                        [LanguageType.DE] = "Charakteristisch für den Kräuterseitling sind sein zartes Aroma und sein Fleisch, das eine steinpilzartige Konsistenz hat. Der Eryngii ist ein delikater Speisepilz, der ähnlich wie Steinpilze verwendet werden kann.",
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
