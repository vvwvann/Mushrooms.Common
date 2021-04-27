using Mushrooms.Core;
using Mushrooms.Database.Data.Extensions;
using System.Collections.Generic;
using Mushrooms.Core.Extensions;
using Mushrooms.Core.Interfaces;

namespace Mushrooms.Database.Seeds
{
    public static class BooksGiftsAndSouvenirsSeed
    {
        public static void Seed(IApplicationDbContext dbContext)
        {
            List<Media> medias = new List<Media> {
                new Media
                {
                    Id = 1,
                    PreviewPath = "http://5.189.140.208:5000/images/zhu-ling-powder-organic-polyporus-umbellatus-organic-mushroom-powder-capsules-120-pcs.jpg",
                    Path = "http://5.189.140.208:5000/images/zhu-ling-powder-organic-polyporus-umbellatus-organic-mushroom-powder-capsules-120-pcs.jpg"
                },
                new Media
                {
                    Id = 2,
                    PreviewPath = "http://5.189.140.208:5000/images/fantastische-pilze-paul-stamets-isbn-978-3-03788-593-2_1.jpg",
                    Path = "http://5.189.140.208:5000/images/fantastische-pilze-paul-stamets-isbn-978-3-03788-593-2_1.jpg"
                },
                new Media
                {
                    Id = 3,
                    PreviewPath = "http://5.189.140.208:5000/images/natuerlich-koch-ich-pilze-yvonne-schwarzinger-isbn-978-3-7066-2581-4.jpg",
                    Path = "http://5.189.140.208:5000/images/natuerlich-koch-ich-pilze-yvonne-schwarzinger-isbn-978-3-7066-2581-4.jpg"
                },
                new Media
                {
                    Id = 4,
                    PreviewPath = "http://5.189.140.208:5000/images/fantastische-pilze-paul-stamets-isbn-978-3-03788-593-2_1.jpg",
                    Path = "http://5.189.140.208:5000/images/fantastische-pilze-paul-stamets-isbn-978-3-03788-593-2_1.jpg"
                },
                new Media
                {
                    Id = 555,
                    PreviewPath = "http://5.189.140.208:5000/images/set-vital-mushrooms-and-book-gesund-mit-heilpilzen_1.jpg",
                    Path = "http://5.189.140.208:5000/images/set-vital-mushrooms-and-book-gesund-mit-heilpilzen_1.jpg"
                }
            };

            dbContext.Medias.AddOrUpdateRange(medias);
            dbContext.SaveChanges();

            List<Product> books = new List<Product>
                {
                new Product
                     {
                         Id = 801,
                         ItemNumber = "AJK-34",
                         ProductWeight = 0.1,
                         ShippingWeight = 0.2,
                         OptionId = 1,
                         Price = 10.3M,
                         PreviewId = 1,
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
                         Id = 802,
                         ItemNumber = "ANK-94",
                         ProductWeight = 0.1,
                         ShippingWeight = 0.2,
                         OptionId = 1,
                         Price = 30.8M,
                         PreviewId = 2,
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
                        Id = 803,
                        ItemNumber = "ANK-94",
                        Price = 17.95M,
                        DiscountPercent = 50,
                        ProductWeight = 0.1,
                        ShippingWeight = 0.2,
                        OptionId = 1,
                        PreviewId = 3,
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
                        Id = 804,
                        Price = 18M,
                        ItemNumber = "ANK-94",
                        ProductWeight = 0.1,
                        ShippingWeight = 0.2,
                        OptionId = 1,
                        PreviewId = 4,
                        Media = medias,
                        Name = new Dictionary<string, string>
                        {
                             [LanguageType.EN] = "Mushroom Cultivation IV - appropriate technology for mushroom growers, Peter Oei, ISBN 978-90-8251290-8",
                             [LanguageType.DE] = "Natürlich koch ich! Pilze, Yvonne Schwarzinger, ISBN: 978-3-7066-2581-4"
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
                    },
                    new Product
                       {
                        Id = 800,
                        ItemNumber = "AJАK-34",
                        ProductWeight = 0.1,
                        ShippingWeight = 0.2,
                        OptionId = 1,
                        Price = 69.9M,
                        PreviewId = 555,
                        Media = new List<Media> { medias[4] },
                        Name = new Dictionary<string, string>
                        {
                             [LanguageType.EN] = "Set Vital-mushrooms and Book \"Gesund mit Heilpilzen\"",
                             [LanguageType.DE] = "Set Vitalpilze und Buch \"Heilpilze\""
                        }.ToJsonDocument(),
                        Description = new Dictionary<string, string>
                        {
                             [LanguageType.EN] = "This manual provides esssential information on how to grow mushrooms and gives details for the three most cultivated mushrooms: Button mushroom, Oyster mushroom and Shiitake. Furthermore, cultivation practices for ten other mushrooms are explained, as well as marketing aspects, feasibility studies, mechanisation, climate control, farm management, pests and diseases and post harvest handling. High tech cultivation of White button mushrooms receives much attention.",
                             [LanguageType.DE] = "This manual provides esssential information on how to grow mushrooms and gives details for the three most cultivated mushrooms: Button mushroom, Oyster mushroom and Shiitake. Furthermore, cultivation practices for ten other mushrooms are explained, as well as marketing aspects, feasibility studies, mechanisation, climate control, farm management, pests and diseases and post harvest handling. High tech cultivation of White button mushrooms receives much attention.",
                        }.ToJsonDocument(),
                        ShortDescription = new Dictionary<string, string>
                        {
                             [LanguageType.EN] = "Gesund mit Heilpilzen - Immunsystem stärken, Krankheiten heilen und Beschwerden lindern Autoren: Mag.a Eva Fauma, Dr.in med.Manuela Angerer. Softcover: 144 Seiten Dieser Ratgeber stellt die wichtigsten Heilpilze detailliert vor.Sie erfahren alles Wesentliche zu Vorkommen, Anwendungsmöglichkeiten und - arten sowie mögliche Therapieerfolge.Hierfür wurden alle relevanten wissenschaftlichen Studien der letzten Jahrzehnte berücksichtigt, hinzu kommt das Wissen der Erfahrungsheilkunde und letztlich kommen auch AnwenderInnen zu Wort, die über ihre Erfolge nach der Einnahme von Heilpilzen berichten.",
                             [LanguageType.DE] = "Wohlbefinden zum Probierpreis: 1 x Buch \"Heilpilze\", 2 x BIO Pilzpulverkapseln Ihrer Wahl, je 120 Stk. Statt 81,70 im Set nur 69,90"
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

            dbContext.Products.AddOrUpdateRange(books);

            List<Category> categories = new()
            {
                new Category
                {
                    Id = 20,
                    Index = 6,
                    Image = "http://5.189.140.208:5000/images/Mushroom-supplements.jpg",
                    GridTheme = new GridTheme
                    {
                        Color = "#59B2E4",
                        Image = "http://5.189.140.208:3000/img/delights.png"
                    },
                    CatalogColors = new CategoryTheme
                    {
                        TopBar = "#435561",
                        Categories = "#BB4238"
                    },
                    Products = books,
                    Name = new Dictionary<string, string>
                    {
                        [LanguageType.EN] = "Books, Gifts and Souvenirs",
                        [LanguageType.DE] = "Bücher & Geschenkartikel aus der wunderbaren Welt der Pilze"
                    }.ToJsonDocument(),
                    Description = new Dictionary<string, string>
                    {
                        [LanguageType.EN] = "Books and gifts from the delightful world of mushrooms!",
                        [LanguageType.DE] = "Bücher & Geschenkartikel aus der wunderbaren Welt der Pilze.",
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


            dbContext.Categories.AddOrUpdate(categories[0]);
            dbContext.SaveChanges();

        }
    }

}

