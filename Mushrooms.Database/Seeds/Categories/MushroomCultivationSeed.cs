using Mushrooms.Core;
using Mushrooms.Core.Interfaces;
using Mushrooms.Database.Data.Extensions;
using System.Collections.Generic;
using System.Linq;
using Mushrooms.Core.Extensions;

namespace Mushrooms.Database.Seeds
{
    public static class MushroomCultivationSeed
    {
        public static void Seed(IApplicationDbContext dbContext)
        {
            List<Media> medias = new List<Media> {
                new Media
                {
                    Id = 15,
                    PreviewPath = "http://5.189.140.208:5000/images/basil-genovese-seeds-from-organic-farming.jpg",
                    Path = "http://5.189.140.208:5000/images/basil-genovese-seeds-from-organic-farming.jpg"
                },
                new Media
                {
                    Id = 16,
                    PreviewPath =   "http://5.189.140.208:5000/images/bush-bean-maxi-seeds-from-organic-farming.jpg",
                    Path =   "http://5.189.140.208:5000/images/bush-bean-maxi-seeds-from-organic-farming.jpg"
                },
                new Media
                {
                    Id = 17,
                    PreviewPath = "http://5.189.140.208:5000/images/chili-pepper-habanero-tropical-red-seeds-from-organic-farming.jpg",
                    Path = "http://5.189.140.208:5000/images/chili-pepper-habanero-tropical-red-seeds-from-organic-farming.jpg"
                },
                new Media
                {
                    Id = 18,
                    PreviewPath = "http://5.189.140.208:5000/images/iceberg-lettuce-graz-cabbage-head-2-seeds-from-organic-farming.jpg",
                    Path = "http://5.189.140.208:5000/images/iceberg-lettuce-graz-cabbage-head-2-seeds-from-organic-farming.jpg"
                },
                new Media
                {
                    Id = 19,
                    PreviewPath = "http://5.189.140.208:5000/images/zhu-ling-powder-organic-polyporus-umbellatus-organic-mushroom-powder-capsules-120-pcs.jpg",
                    Path = "http://5.189.140.208:5000/images/zhu-ling-powder-organic-polyporus-umbellatus-organic-mushroom-powder-capsules-120-pcs.jpg"
                },
                new Media
                {
                    Id = 20,
                    PreviewPath =  "http://5.189.140.208:5000/images/fantastische-pilze-paul-stamets-isbn-978-3-03788-593-2_1.jpg",
                    Path =  "http://5.189.140.208:5000/images/fantastische-pilze-paul-stamets-isbn-978-3-03788-593-2_1.jpg"
                },
                new Media
                {
                    Id = 21,
                    PreviewPath = "http://5.189.140.208:5000/images/natuerlich-koch-ich-pilze-yvonne-schwarzinger-isbn-978-3-7066-2581-4.jpg",
                    Path = "http://5.189.140.208:5000/images/natuerlich-koch-ich-pilze-yvonne-schwarzinger-isbn-978-3-7066-2581-4.jpg"
                },
                new Media
                {
                    Id = 22,
                    PreviewPath = "http://5.189.140.208:5000/images/zhu-ling-powder-organic-polyporus-umbellatus-organic-mushroom-powder-capsules-120-pcs.jpg",
                    Path = "http://5.189.140.208:5000/images/zhu-ling-powder-organic-polyporus-umbellatus-organic-mushroom-powder-capsules-120-pcs.jpg"
                }
            };

            dbContext.Medias.AddOrUpdateRange(medias);
            dbContext.SaveChanges();

            List<Product> gardenProducts = new List<Product>
            {
                 new Product
                 {
                     Id = 141,
                     ProductWeight = 12.1,
                     ShippingWeight = 12.2,
                     OptionId = 1,
                     Price = 15.3M,
                     PreviewId = 15,
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
                    QuantityId = (int)QuantityTypes.Piece,
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
                        }
                 },
                 new Product
                 {
                     Id = 142,
                     ProductWeight = 1.5,
                     ShippingWeight = 2,
                     OptionId = 1,
                     ItemNumber = "AJK-34",
                     Price = 15.3M,
                     DiscountPercent = 10,
                     PreviewId = 16,
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
                    QuantityId = (int)QuantityTypes.Piece,
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
                        }
                 },
                 new Product
                 {
                     Id = 143,
                     ProductWeight = 1.5,
                     ShippingWeight = 2,
                     OptionId = 1,
                     Price = 3.1M,
                     ItemNumber = "AJK-34",
                     DiscountPercent = 10,
                     PreviewId = 17,
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
                     Id = 144,
                     ProductWeight = 1.5,
                     ShippingWeight = 2,
                     OptionId = 1,
                     Price = 3.1M,
                     DiscountPercent = 10,
                     PreviewId = 18,
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


            List<Product> books = new()
            {
                    new Product
                     {
                         Id = 131,
                         ItemNumber = "AJK-34",
                         ProductWeight = 0.1,
                         ShippingWeight = 0.2,
                         OptionId = 1,
                         Price = 10.3M,
                         PreviewId = 19,
                         Media = medias,
                         Name = new Dictionary<string, string>
                         {
                            [LanguageType.EN] = "Chaga - König der Heilpilze, David Wolfe, ISBN: 978-3-442-22064-9 (!GERMAN LANGUAGE!)",
                            [LanguageType.DE] = "Chaga - König der Heilpilze, David Wolfe, ISBN: 978-3-442-22064-9"
                         }.ToJsonDocument(),
                         Description = new Dictionary<string, string>
                         {
                            [LanguageType.EN] = "! ONLY IN GERMAN LANGUAGE! Der bekannte Rohkost- und Heilnahrungsexperte David Wolfe präsentiert Heilpilze, die das Immunsystem stärken, Allergien beenden, die Krebsentwicklung aufhalten und Energie und Vitalität spenden. Er hebt insbesondere den Chaga-Pilz hervor, den König der Heilpilze, den die Menschen in Sibirien schon seit Jahrhunderten als Wundermittel kennen.",
                            [LanguageType.DE] = "Der bekannte Rohkost- und Heilnahrungsexperte David Wolfe präsentiert Heilpilze, die das Immunsystem stärken, Allergien beenden, die Krebsentwicklung aufhalten und Energie und Vitalität spenden. Er hebt insbesondere den Chaga-Pilz hervor, den König der Heilpilze, den die Menschen in Sibirien schon seit Jahrhunderten als Wundermittel kennen.",
                         }.ToJsonDocument(),
                         ShortDescription = new Dictionary<string, string>
                         {
                            [LanguageType.EN] = "Der bekannte Rohkost- und Heilnahrungsexperte David Wolfe präsentiert Heilpilze, die das Immunsystem stärken, Allergien beenden, die Krebsentwicklung aufhalten und Energie und Vitalität spenden.",
                            [LanguageType.DE] = "Der bekannte Rohkost- und Heilnahrungsexperte David Wolfe präsentiert Heilpilze, die das Immunsystem stärken, Allergien beenden, die Krebsentwicklung aufhalten und Energie und Vitalität spenden."
                         }.ToJsonDocument(),
                         BasePrice = new Dictionary<string, string>
                         {
                            [LanguageType.EN] = "30 g pack (13,25€)",
                            [LanguageType.DE] = "30 g pack (13,25€)"
                         }.ToJsonDocument(),
                         Mass = new Dictionary<string, string>
                         {
                            [LanguageType.EN] = "1 pcs",
                            [LanguageType.DE] = "1 Stk"
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
                         Id = 132,
                         ItemNumber = "ANK-94",
                         ProductWeight = 0.1,
                         ShippingWeight = 0.2,
                         OptionId = 1,
                         Price = 30.8M,
                         PreviewId = 20,
                         Media = medias,
                         Name = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "Fantastische Pilze, Paul Stamets, ISBN: 978-3-03788-593-2",
                             [LanguageType.DE] = "Fantastische Pilze, Paul Stamets, ISBN: 978-3-03788-593-2"
                         }.ToJsonDocument(),
                         Description = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "! ONLY IN GERMAN LANGUAGE! Fantastische Pilze - Wie Pilze unser Bewusstsein erweitern und den Planeten retten können Der bekannte Rohkost- und Heilnahrungsexperte David Wolfe präsentiert Heilpilze, die das Immunsystem stärken, Allergien beenden, die Krebsentwicklung aufhalten und Energie und Vitalität spenden. Er hebt insbesondere den Chaga-Pilz hervor, den König der Heilpilze, den die Menschen in Sibirien schon seit Jahrhunderten als Wundermittel kennen.",
                             [LanguageType.DE] = "Fantastische Pilze - Wie Pilze unser Bewusstsein erweitern und den Planeten retten können Der bekannte Rohkost- und Heilnahrungsexperte David Wolfe präsentiert Heilpilze, die das Immunsystem stärken, Allergien beenden, die Krebsentwicklung aufhalten und Energie und Vitalität spenden. Er hebt insbesondere den Chaga-Pilz hervor, den König der Heilpilze, den die Menschen in Sibirien schon seit Jahrhunderten als Wundermittel kennen.",
                         }.ToJsonDocument(),
                         ShortDescription = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "Die Wissenschaft erkennt immer deutlicher, wie wichtig Pilze für die Entwicklung der menschlichen Gesellschaft und für die Lösung der ökologischen Probleme der Erde sind.",
                             [LanguageType.DE] = "Die Wissenschaft erkennt immer deutlicher, wie wichtig Pilze für die Entwicklung der menschlichen Gesellschaft und für die Lösung der ökologischen Probleme der Erde sind."
                         }.ToJsonDocument(),
                         BasePrice = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "30 g pack (13,25€)",
                             [LanguageType.DE] = "30 g pack (13,25€)"
                         }.ToJsonDocument(),
                         Mass = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "1 pcs",
                             [LanguageType.DE] = "1 Stk"
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
                         Id = 133,
                         ItemNumber = "ANK-94",
                         Price = 17.95M,
                         DiscountPercent = 50,
                         ProductWeight = 0.1,
                         ShippingWeight = 0.2,
                         OptionId = 1,
                         PreviewId = 21,
                         Media = medias,
                         Name = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "Natürlich koch ich! Pilze, Yvonne Schwarzinger, ISBN: 978-3-7066-2581-4",
                             [LanguageType.DE] = "Natürlich koch ich! Pilze, Yvonne Schwarzinger, ISBN: 978-3-7066-2581-4"
                         }.ToJsonDocument(),
                         Description = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "Aromatische Waldpilze wie Steinpilze und Eierschwammerl oder schmackhafte Zuchtpilze wie Shiitake und Champignons, das sind die Hauptdarsteller in den vielseitigen Rezepten von Yvonne Schwarzinger. Mit den raffinierten Zubereitungsideen zaubern Sie aus frischen Pilzen schmackhafte Suppen, Vorspeisen, Hauptgerichte mit Fisch und Fleisch und vegetarische Köstlichkeiten.",
                             [LanguageType.DE] = "Aromatische Waldpilze wie Steinpilze und Eierschwammerl oder schmackhafte Zuchtpilze wie Shiitake und Champignons, das sind die Hauptdarsteller in den vielseitigen Rezepten von Yvonne Schwarzinger. Mit den raffinierten Zubereitungsideen zaubern Sie aus frischen Pilzen schmackhafte Suppen, Vorspeisen, Hauptgerichte mit Fisch und Fleisch und vegetarische Köstlichkeiten.",
                         }.ToJsonDocument(),
                         ShortDescription = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "Pilze einfach und richtig zubereiten!Abwechslungsreiche Rezepte mit den beliebtesten Wald- und Zuchtpilzen. Bodenständige Alltagsküche und viele neue Ideen.",
                             [LanguageType.DE] = "Pilze einfach und richtig zubereiten!Abwechslungsreiche Rezepte mit den beliebtesten Wald- und Zuchtpilzen. Bodenständige Alltagsküche und viele neue Ideen."
                         }.ToJsonDocument(),
                         BasePrice = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "30 g pack (13,25€)",
                             [LanguageType.DE] = "30 g pack (13,25€)"
                         }.ToJsonDocument(),
                         Mass = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "1 pcs",
                             [LanguageType.DE] = "1 Stk"
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
                         Id = 134,
                         Price = 18M,
                         ItemNumber = "ANK-94",
                         ProductWeight = 0.1,
                         ShippingWeight = 0.2,
                         OptionId = 1,
                         PreviewId = 22,
                         Media = medias,
                         Name = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "Mushroom Cultivation IV - appropriate technology for mushroom growers, Peter Oei, ISBN 978-90-8251290-8",
                             [LanguageType.DE] = "Mushroom Cultivation IV - appropriate technology for mushroom growers, Peter Oei, ISBN 978-90-8251290-8"
                         }.ToJsonDocument(),
                         Description = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "This manual provides esssential information on how to grow mushrooms and gives details for the three most cultivated mushrooms: Button mushroom, Oyster mushroom and Shiitake. Furthermore, cultivation practices for ten other mushrooms are explained, as well as marketing aspects, feasibility studies, mechanisation, climate control, farm management, pests and diseases and post harvest handling. High tech cultivation of White button mushrooms receives much attention.",
                             [LanguageType.DE] = "This manual provides esssential information on how to grow mushrooms and gives details for the three most cultivated mushrooms: Button mushroom, Oyster mushroom and Shiitake. Furthermore, cultivation practices for ten other mushrooms are explained, as well as marketing aspects, feasibility studies, mechanisation, climate control, farm management, pests and diseases and post harvest handling. High tech cultivation of White button mushrooms receives much attention.",
                         }.ToJsonDocument(),
                         ShortDescription = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "The mushroom manual for growers, scientist, biology and agriculture students. With new information on: Biocontrol in mushrooms, Liquid Spawn, Recycling casing soil, Reusing spent substrate, Supplementation, Circular economy, Combining mushrooms and greenhouses and more.",
                             [LanguageType.DE] = "The mushroom manual for growers, scientist, biology and agriculture students. With new information on: Biocontrol in mushrooms, Liquid Spawn, Recycling casing soil, Reusing spent substrate, Supplementation, Circular economy, Combining mushrooms and greenhouses and more."
                         }.ToJsonDocument(),
                         BasePrice = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "30 g pack (13,25€)",
                             [LanguageType.DE] = "30 g pack (13,25€)"
                         }.ToJsonDocument(),
                         Mass = new Dictionary<string, string>
                         {
                             [LanguageType.EN] = "1 pcs",
                             [LanguageType.DE] = "1 Stk"
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

            dbContext.Products.AddOrUpdateRange(gardenProducts);

            dbContext.Products.AddOrUpdateRange(books);
            dbContext.SaveChanges();


            List<Category> categories = new()
            {
                  new Category
                {
                    Id = 12,
                    Index = 5,
                    Image = "http://5.189.140.208:5000/images/Mushroom-supplements.jpg",
                    GridTheme = new GridTheme
                    {
                       Color = "#4BC7CF",
                       Image = "http://5.189.140.208:3000/img/cultivation.png"
                    },
                    CatalogColors = new CategoryTheme
                    {
                        TopBar = "#188287",
                        Categories = "#4BC9CF"
                    },
                    Products = books.Union(gardenProducts).ToList(),
                    Name = new Dictionary<string, string>
                    {
                          [LanguageType.EN] = "Mushroom Cultivation",
                          [LanguageType.DE] = "Pilzanbau"
                    }.ToJsonDocument(),
                     Description = new Dictionary<string, string>
                     {
                          [LanguageType.EN] = "Spores, Spawn, Substrate and more. Everything to grow mushrooms - For Amateurs and Professionals.",
                          [LanguageType.DE] = "Pilzzucht Know-How: Bei uns finden Sie auch eine Auswahl an Büchern, in denen auf einfache und leicht verständliche Weise die Grundtechniken des Pilzanbaues erklärt werden. Das Buch Pilze selbst Anbauen ist für Anfänger sehr zu empfehlen!",
                     }.ToJsonDocument(),
                     GridDescription = new Dictionary<string, string>
                     {
                          [LanguageType.EN] = "Spores, Spawn, Substrate and more. Everything to grow mushrooms - For Amateurs and Professionals.",
                          [LanguageType.DE] = "Der Anbau von Speise- und Vitalpilzen in Haus und Garten erfreut sich zunehmender Beliebtheit! "
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
                    Id = 13,
                    ParentId = 12,
                    Image = "http://5.189.140.208:5000/images/Mushroom-supplements.jpg",
                    CatalogColors = new CategoryTheme
                    {
                        TopBar = "#188287",
                        Categories = "#4BC9CF"
                    },
                    Products = books,
                    Name = new Dictionary<string, string>
                    {
                        [LanguageType.EN] = "Cultivation Know-How",
                        [LanguageType.DE] = "Pilzzucht Know-How"
                    }.ToJsonDocument(),
                    Description = new Dictionary<string, string>
                    {
                        [LanguageType.EN] = "For most European gardeners and farmers, mushroom cultivation is still a new area. The books presented here will guide you to successfully cultivation of edible and medicinal mushrooms. Beside of basic literature for beginners (sorry, at the moment only in German language available), we offer further literature written by Dr. Paul Stamets, an world-wide recognized expert in mushroom cultivation.",
                        [LanguageType.DE] = "Der Anbau von Pilzen ist für viele Gärtner und Landwirte in Europa noch Neuland. Mit den hier vorgestellten Büchern lernen Sie, wie sie schmackhafte Pilze selbst anbauen können. Neben Basisliteratur für Anfänger in Deutscher Sprache finden Sie bei uns auch weiterführende Literatur vom international anerkannten Pilzanbau-Experten Dr. Paul Stamets.",
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
                    Id = 14,
                    ParentId = 12,
                    Image = "http://5.189.140.208:5000/images/Mushroom-supplements.jpg",
                    CatalogColors = new CategoryTheme
                    {
                         TopBar = "#188287",
                         Categories = "#4BC9CF"
                    },
                    Products = gardenProducts,
                    Name = new Dictionary<string, string>
                    {
                          [LanguageType.EN] = "Mushroom garden",
                          [LanguageType.DE] = "Pilzanbau im Garten"
                    }.ToJsonDocument(),
                    Description = new Dictionary<string, string>
                    {
                          [LanguageType.EN] = "With little work and endurance, you can grow your own mushrooms in your garden!",
                          [LanguageType.DE] = "Mit wenig Aufwand und etwas Geduld können Sie Ihre eigenen Pilze selbst anbauen. Unsere Pilzbrut (Saatgut für Pilze) ist für die biologische Pilzzucht zertifiziert. Als Standort eignet sich ein schattiger Platz im Garten. Egal ob Pilzanbau auf Strohballen, Baumstämmen oder die Anlage eines Gartenbeetes mit Pilzen, mit unseren Anleitungen und Produkten erzielen auch Anfänger Pilzzucht-Erfolge.",
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
