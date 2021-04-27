using Mushrooms.Core;
using Mushrooms.Core.Interfaces;
using Mushrooms.Database.Data.Extensions;
using System.Collections.Generic;
using Mushrooms.Core.Extensions;

namespace Mushrooms.Database.Seeds
{
    public static class MushroomDelightsSeed
    {
        public static void Seed(IApplicationDbContext dbContext)
        {
            List<Media> medias = new List<Media> {
                new Media
                {
                    Id = 23,
                    PreviewPath = "http://5.189.140.208:5000/images/bio-shiitake-frischpilze-lentinula-edodes.jpg" ,
                    Path = "http://5.189.140.208:5000/images/bio-shiitake-frischpilze-lentinula-edodes.jpg"
                },
                new Media
                {
                    Id = 25,
                    PreviewPath = "http://5.189.140.208:5000/images/natuerlich-koch-ich-pilze-yvonne-schwarzinger-isbn-978-3-7066-2581-4.jpg",
                    Path = "http://5.189.140.208:5000/images/natuerlich-koch-ich-pilze-yvonne-schwarzinger-isbn-978-3-7066-2581-4.jpg"
                },
                new Media
                {
                    Id = 26,
                    PreviewPath = "http://5.189.140.208:5000/images/trueffeln-die-heimischen-exoten-dumaine-wojtko-isbn-978-3-03800-496-7-german-language.jpg",
                    Path = "http://5.189.140.208:5000/images/trueffeln-die-heimischen-exoten-dumaine-wojtko-isbn-978-3-03800-496-7-german-language.jpg"
                },
                new Media
                {
                    Id = 27,
                    PreviewPath = "http://5.189.140.208:5000/images/wald-wiesen-pilze-das-kochbuch-ralf-frenzel-dieter-gewalt-isbn-978-3941641556-german-language.jpg",
                    Path = "http://5.189.140.208:5000/images/wald-wiesen-pilze-das-kochbuch-ralf-frenzel-dieter-gewalt-isbn-978-3941641556-german-language.jpg"
                }
            };

            dbContext.Medias.AddOrUpdateRange(medias);
            dbContext.SaveChanges();

            List<Product> products = new List<Product>
            {
                 new Product
                 {
                     Id = 1,
                     ItemNumber = "A-3432",
                     ProductWeight = 0.1,
                     ShippingWeight = 0.2,
                     OptionId = 1,
                     Price = 9.9M,
                     PreviewId = 23,
                     Media = medias,
                     AddToBasket = false,
                     Name = new Dictionary<string, string>
                        {
                             [LanguageType.EN] = "Bio Shiitake Frischpilze - Lentinula edodes",
                             [LanguageType.DE] = "Bio Shiitake Frischpilze - Lentinula edodes"
                        }.ToJsonDocument(),
                        Description = new Dictionary<string, string>
                        {
                             [LanguageType.EN] = "Shiitake besitzt die Geschmacksqualiät umami (herzhaft, wohlschmeckend) und wird in Ost-Asien wegen seines unvergleichlich würzigen Aromas auch duftender Pilz genannt. Beim Shiitake kann der gesamte Pilz, also Hut und Stiel verwendet werden. Die Stiele haben eine etwas längere Garzeit und werden deshalb etwas dünner geschnitten als die Hüte. In Gerichten mit Faschiertem kann ein Teil des Fleisches durch fein gehackte Shiitake Pilze ersetzet werden.",
                             [LanguageType.DE] = "Shiitake besitzt die Geschmacksqualiät umami (herzhaft, wohlschmeckend) und wird in Ost-Asien wegen seines unvergleichlich würzigen Aromas auch duftender Pilz genannt. Beim Shiitake kann der gesamte Pilz, also Hut und Stiel verwendet werden. Die Stiele haben eine etwas längere Garzeit und werden deshalb etwas dünner geschnitten als die Hüte. In Gerichten mit Faschiertem kann ein Teil des Fleisches durch fein gehackte Shiitake Pilze ersetzet werden.",
                        }.ToJsonDocument(),
                        ShortDescription = new Dictionary<string, string>
                        {
                             [LanguageType.EN] = "Bio Shiitake - 100 % geboren und gewachsen in Österreich. Nur bei uns finden Kulturenführung, Substratherstellung und Anbau in Österreich statt.",
                             [LanguageType.DE] = "Bio Shiitake - 100 % geboren und gewachsen in Österreich. Nur bei uns finden Kulturenführung, Substratherstellung und Anbau in Österreich statt."
                        }.ToJsonDocument(),
                        BasePrice = new Dictionary<string, string>
                        {
                             [LanguageType.EN] = "30 g pack (13,25€)",
                             [LanguageType.DE] = "30 g pack (13,25€)"
                        }.ToJsonDocument(),
                        Mass = new Dictionary<string, string>
                        {
                             [LanguageType.EN] = "100 g",
                             [LanguageType.DE] = "100 g"
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
                     Id = 1,
                     ItemNumber = "A-3434",
                     ProductWeight = 1,
                     ShippingWeight = 1.2,
                     OptionId = 2,
                     Price = 19.9M,
                     PreviewId = 23,
                     Media = medias,
                     AddToBasket = false,
                     Name = new Dictionary<string, string>
                        {
                             [LanguageType.EN] = "Bio Shiitake Frischpilze - Lentinula edodes",
                             [LanguageType.DE] = "Bio Shiitake Frischpilze - Lentinula edodes"
                        }.ToJsonDocument(),
                        Description = new Dictionary<string, string>
                        {
                             [LanguageType.EN] = "Shiitake besitzt die Geschmacksqualiät umami (herzhaft, wohlschmeckend) und wird in Ost-Asien wegen seines unvergleichlich würzigen Aromas auch duftender Pilz genannt. Beim Shiitake kann der gesamte Pilz, also Hut und Stiel verwendet werden. Die Stiele haben eine etwas längere Garzeit und werden deshalb etwas dünner geschnitten als die Hüte. In Gerichten mit Faschiertem kann ein Teil des Fleisches durch fein gehackte Shiitake Pilze ersetzet werden.",
                             [LanguageType.DE] = "Shiitake besitzt die Geschmacksqualiät umami (herzhaft, wohlschmeckend) und wird in Ost-Asien wegen seines unvergleichlich würzigen Aromas auch duftender Pilz genannt. Beim Shiitake kann der gesamte Pilz, also Hut und Stiel verwendet werden. Die Stiele haben eine etwas längere Garzeit und werden deshalb etwas dünner geschnitten als die Hüte. In Gerichten mit Faschiertem kann ein Teil des Fleisches durch fein gehackte Shiitake Pilze ersetzet werden.",
                        }.ToJsonDocument(),
                        ShortDescription = new Dictionary<string, string>
                        {
                             [LanguageType.EN] = "Bio Shiitake - 100 % geboren und gewachsen in Österreich. Nur bei uns finden Kulturenführung, Substratherstellung und Anbau in Österreich statt.",
                             [LanguageType.DE] = "Bio Shiitake - 100 % geboren und gewachsen in Österreich. Nur bei uns finden Kulturenführung, Substratherstellung und Anbau in Österreich statt."
                        }.ToJsonDocument(),
                        BasePrice = new Dictionary<string, string>
                        {
                             [LanguageType.EN] = "30 g pack (13,25€)",
                             [LanguageType.DE] = "30 g pack (13,25€)"
                        }.ToJsonDocument(),
                        Mass = new Dictionary<string, string>
                        {
                             [LanguageType.EN] = "100 g",
                             [LanguageType.DE] = "100 g"
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
                     Id = 2,
                     Price = 17.95M,
                     DiscountPercent = 50,
                     ProductWeight = 0.1,
                     ItemNumber = "AJK-34",
                     ShippingWeight = 0.2,
                     OptionId = 1,
                     PreviewId = 25,
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
                             [LanguageType.EN] = "100 g",
                             [LanguageType.DE] = "100 g"
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
                     Id = 3,
                     Price = 8.77M,
                     DiscountPercent = 10,
                     ProductWeight = 0.1,
                     ShippingWeight = 0.2,
                     OptionId = 1,
                     ItemNumber = "AJK-34",
                     PreviewId = 26,
                     Media = medias,
                     Name = new Dictionary<string, string>
                        {
                             [LanguageType.EN] = "Trüffeln - die heimischen Exoten, Dumaine, Wojtko, ISBN:978-3-03800-496-7 (German language!)",
                             [LanguageType.DE] = "Trüffeln - die heimischen Exoten, Dumaine, Wojtko, ISBN:978-3-03800-496-7"
                        }.ToJsonDocument(),
                        Description = new Dictionary<string, string>
                        {
                             [LanguageType.EN] = "Trüffeln sind nicht nur das kostbre Edelprodukt aus dem Périgord oder dem Piemont, es gibt sie auch bei uns. Noch gegen Ende des 19. Jahrhunderts war Deutschland ein Trüffelexportland. Doch das Wissen über die heimischen Arten ist heute in Vergessenheit geraten.",
                             [LanguageType.DE] = "Trüffeln sind nicht nur das kostbre Edelprodukt aus dem Périgord oder dem Piemont, es gibt sie auch bei uns. Noch gegen Ende des 19. Jahrhunderts war Deutschland ein Trüffelexportland. Doch das Wissen über die heimischen Arten ist heute in Vergessenheit geraten.",
                        }.ToJsonDocument(),
                        ShortDescription = new Dictionary<string, string>
                        {
                             [LanguageType.EN] = "Trüffeln sind nicht nur das kostbre Edelprodukt aus dem Périgord oder dem Piemont, es gibt sie auch bei uns. Doch das Wissen über die heimischen Arten ist heute in Vergessenheit geraten.",
                             [LanguageType.DE] = "Trüffeln sind nicht nur das kostbre Edelprodukt aus dem Périgord oder dem Piemont, es gibt sie auch bei uns. Doch das Wissen über die heimischen Arten ist heute in Vergessenheit geraten."
                        }.ToJsonDocument(),
                        BasePrice = new Dictionary<string, string>
                        {
                             [LanguageType.EN] = "30 g pack (13,25€)",
                             [LanguageType.DE] = "30 g pack (13,25€)"
                        }.ToJsonDocument(),
                        Mass = new Dictionary<string, string>
                        {
                             [LanguageType.EN] = "100 g",
                             [LanguageType.DE] = "100 g"
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
                     Id = 4,
                     Price = 20.5M,
                     DiscountPercent = 10,
                     ItemNumber = "AJK-34",
                     ProductWeight = 0.1,
                     ShippingWeight = 0.2,
                     OptionId = 1,
                     PreviewId = 27,
                     Media = medias,
                     Name = new Dictionary<string, string>
                        {
                             [LanguageType.EN] = "Wald & Wiesen Pilze - Das Kochbuch, Ralf Frenzel, Dieter Gewalt, ISBN: 978-3941641556 (German language!)",
                             [LanguageType.DE] = "Wald & Wiesen Pilze - Das Kochbuch, Ralf Frenzel, Dieter Gewalt, ISBN: 978-3941641556 (German language!)"
                        }.ToJsonDocument(),
                        Description = new Dictionary<string, string>
                        {
                             [LanguageType.EN] = "Mit dem Herbst beginnt die Pilzsaison! Endlich sind wieder Frische Wildpilze wie Pfifferlinge und Steinpilze auf dem Markt erhältlich. Doch was tun mit den kleinen Köstlichkeiten? Abwechslungsreiche Rezeptideen für die beliebtesten Kultur- und Wildpilze sowie viele praktische Informationen rund ums Sammeln und die Zubereitung bietet der neue Band der beliebten Hausgemacht-Reihe.",
                             [LanguageType.DE] = "Mit dem Herbst beginnt die Pilzsaison! Endlich sind wieder Frische Wildpilze wie Pfifferlinge und Steinpilze auf dem Markt erhältlich. Doch was tun mit den kleinen Köstlichkeiten? Abwechslungsreiche Rezeptideen für die beliebtesten Kultur- und Wildpilze sowie viele praktische Informationen rund ums Sammeln und die Zubereitung bietet der neue Band der beliebten Hausgemacht-Reihe.",
                        }.ToJsonDocument(),
                        ShortDescription = new Dictionary<string, string>
                        {
                             [LanguageType.EN] = "Köstliche und einfach nach zu kochende Rezepte mit Champignons, Pfifferlingen, Kräuterseitlingen, Shiitakepilzen und vielen anderen Sorten.",
                             [LanguageType.DE] = "Köstliche und einfach nach zu kochende Rezepte mit Champignons, Pfifferlingen, Kräuterseitlingen, Shiitakepilzen und vielen anderen Sorten."
                        }.ToJsonDocument(),
                        BasePrice = new Dictionary<string, string>
                        {
                             [LanguageType.EN] = "30 g pack (13,25€)",
                             [LanguageType.DE] = "30 g pack (13,25€)"
                        }.ToJsonDocument(),
                        Mass = new Dictionary<string, string>
                        {
                             [LanguageType.EN] = "100 g",
                             [LanguageType.DE] = "100 g"
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
                    Id = 4,
                    Index = 2,
                    Image = "http://5.189.140.208:5000/images/Mushroom-supplements.jpg",
                    GridTheme = new GridTheme
                    {
                       Color = "#59B2E4",
                       Image = "http://5.189.140.208:3000/img/delights.png"
                    },
                    CatalogColors = new CategoryTheme
                    {
                        TopBar = "#164259",
                        Categories = "#59B3E4",
                    },
                    Products = products,
                    Name = new Dictionary<string, string>
                    {
                        [LanguageType.EN] = "Mushroom Delights",
                        [LanguageType.DE] = "Pilzdelikatessen"
                    }.ToJsonDocument(),
                    Description = new Dictionary<string, string>
                    {
                        [LanguageType.EN] = "Organic dried fungi, gourmet mushroom and truffle products.",
                        [LanguageType.DE] = "Bio Pilze getrocknet, Pilzdelikatessen und Trüffelprodukte in höchster Qualität.",
                    }.ToJsonDocument(),
                    GridDescription = new Dictionary<string, string>
                    {
                        [LanguageType.EN] = "Organic dried fungi, gourmet mushroom and truffle products.",
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
                }
            };

            dbContext.Categories.AddOrUpdateRange(categories);
            dbContext.SaveChanges();
        }
    }
}
