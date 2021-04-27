using Mushrooms.Core;
using Mushrooms.Core.Interfaces;
using Mushrooms.Database.Data.Extensions;
using System.Collections.Generic;
using System.Linq;
using Mushrooms.Core.Extensions;

namespace Mushrooms.Database.Seeds
{
    public static partial class MedicinalMushroomsSeed
    {

        public static void Seed(IApplicationDbContext dbContext)
        {
            List<Media> medias = new List<Media> {
                new Media
                {
                    Id = 5,
                    PreviewPath = "http://5.189.140.208:5000/images/oyster-mushroom-powder-organic-pleurotus-ostreatus-organic-mushroom-powder-capsules-120-pcs.jpg",
                    Path = "http://5.189.140.208:5000/images/oyster-mushroom-powder-organic-pleurotus-ostreatus-organic-mushroom-powder-capsules-120-pcs.jpg"
                },
                new Media
                {
                    Id = 6,
                    PreviewPath = "http://5.189.140.208:5000/images/chaga-pakuri-liquid-extract-organic-inonotus-obliquus-organic-mushroom-liquid-extract-100ml-bottle.jpg",
                    Path = "http://5.189.140.208:5000/images/chaga-pakuri-liquid-extract-organic-inonotus-obliquus-organic-mushroom-liquid-extract-100ml-bottle.jpg"
                },
                new Media
                {
                    Id = 7,
                    PreviewPath = "http://5.189.140.208:5000/images/zhu-ling-powder-organic-polyporus-umbellatus-organic-mushroom-powder-capsules-120-pcs.jpg",
                    Path = "http://5.189.140.208:5000/images/zhu-ling-powder-organic-polyporus-umbellatus-organic-mushroom-powder-capsules-120-pcs.jpg"
                },
                new Media
                {
                    Id = 8,
                    PreviewPath = "http://5.189.140.208:5000/images/lions-mane-liquid-extract-organic-hericium-erinaceus-organic-mushroom-liquid-extract-100ml.jpg",
                    Path = "http://5.189.140.208:5000/images/lions-mane-liquid-extract-organic-hericium-erinaceus-organic-mushroom-liquid-extract-100ml.jpg"
                },
                new Media
                {
                    Id = 9,
                    PreviewPath = "http://5.189.140.208:5000/images/zhu-ling-powder-organic-polyporus-umbellatus-organic-mushroom-powder-capsules-120-pcs.jpg",
                    Path = "http://5.189.140.208:5000/images/zhu-ling-powder-organic-polyporus-umbellatus-organic-mushroom-powder-capsules-120-pcs.jpg"
                },
                new Media
                {
                    Id = 10,
                    PreviewPath = "http://5.189.140.208:5000/images/fantastische-pilze-paul-stamets-isbn-978-3-03788-593-2_1.jpg",
                    Path = "http://5.189.140.208:5000/images/fantastische-pilze-paul-stamets-isbn-978-3-03788-593-2_1.jpg"
                }
            };

            dbContext.Medias.AddOrUpdateRange(medias);
            dbContext.SaveChanges();

            List<Product> medicinal = new List<Product>
            {
                   new Product
                         {
                             Id = 301,
                             ItemNumber = "ANK-44",
                             ProductWeight = 0.200,
                             ShippingWeight = 0.250,
                             OptionId = 1,
                             Price = 31.9M,
                             PreviewId = 5,
                             Media = medias,
                             Name = new Dictionary<string, string>
                             {
                                 [LanguageType.EN] = "Oyster mushroom Powder ORGANIC - Pleurotus ostreatus ORGANIC Mushroom Powder Capsules 120 pcs.",
                                 [LanguageType.DE] = "Austernpilz Pulver BIO - Pleurotus ostreatus BIO Pilzpulverkapseln 120 Stk."
                             }.ToJsonDocument(),
                             Description = new Dictionary<string, string>
                             {
                                 [LanguageType.EN] = "Syn.: Hiratake, Tamogitake, Píng Gu, Sadafi, Chippikkoon Annual, warmth loving, 20-40cm-high, light germinator. Sowing: first crop from middle of April, transplant 2 - 3 plants together or direct drilling from end of May. 3 - 4g for 1000 plants.Spacing: 20x20cm.",
                                 [LanguageType.DE] = "Syn.: Austernseitling, Hiratake, Tamogitake, Píng Gu, Sadafi, Chippikkoon Einjährig, wärmeliebend, 20-40 cm hoch, Lichtkeimer. Aussaat: Vorkultur ab Mitte April, 2-3 Pflanzen gemeinsam pikieren oder Direktsaat ab Ende Mai. 3-4g für 1000 Pflanzen. Abstände: Pflanzabstand 20x20 cm.",
                             }.ToJsonDocument(),
                             ShortDescription = new Dictionary<string, string>
                             {
                                 [LanguageType.EN] = "Pleurotus dietary supplement, certified organic. Syn.: Hiratake, Tamogitake, Píng Gu, Sadafi, Chippikkoon",
                                 [LanguageType.DE] = "Pleurotus Nahrungsergänzungsmittel in Bio Qualität. Syn.: Austernseitling, Hiratake, Tamogitake, Píng Gu, Sadafi, Chippikkoon"
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
                                 [LanguageType.EN] = "ABOUT THE MUSHROOM.",
                                 [LanguageType.DE] = "ÜBER DEN PILZ"
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
                             Id = 302,
                             ItemNumber = "ANK-301",
                             ProductWeight = 0.200,
                             ShippingWeight = 0.250,
                             OptionId = 1,
                             Price = 79.4M,
                             DiscountPercent = 30,
                             PreviewId = 6,
                             Media = medias,
                             Name = new Dictionary<string, string>
                             {
                                 [LanguageType.EN] = "Chaga (Pakuri) Liquid Extract ORGANIC - Inonotus obliquus - ORGANIC Mushroom Liquid Extract, 100ml bottle",
                                 [LanguageType.DE] = "Chaga (Pakuri) Flüssigextrakt BIO 100ml Flasche"
                             }.ToJsonDocument(),
                             Description = new Dictionary<string, string>
                             {
                                 [LanguageType.EN] = "Syn.: Clinker Polypore, Cinder conk, Black Mass Polypore, Birch Canker Polypore, norwegian: Kreftkjuke', Kabanoanatake, Bai Hua Rong",
                                 [LanguageType.DE] = "Syn.:  Schiefer Schillerporling, Pakuri, Kabanoanatake, Bai Hua Rong",
                             }.ToJsonDocument(),
                             ShortDescription = new Dictionary<string, string>
                             {
                                 [LanguageType.EN] = "Chaga Extract, certified organic. Syn.: Inonotus obliquus, Pakuri",
                                 [LanguageType.DE] = "Chaga Flüssigextrakt in Bio Qualität. Syn.: Schiefer Schillerporling, Pakuri, Kabanoanatake, Bai Hua Rong"
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
                                 [LanguageType.EN] = "ABOUT THE MUSHROOM.",
                                 [LanguageType.DE] = "ÜBER DEN PILZ"
                             }.ToJsonDocument(),
                             QuantityId = (int)QuantityTypes.Piece,
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

                         },
                   new Product
                         {
                             Id = 303,
                             ItemNumber = "ANK-303",
                             ProductWeight = 0.200,
                             ShippingWeight = 0.250,
                             OptionId = 1,
                             Price = 31M,
                             DiscountPercent = 20,
                             PreviewId = 7,
                             Media = medias,
                             Name = new Dictionary<string, string>
                             {
                                 [LanguageType.EN] = "Zhu Ling Powder ORGANIC - Polyporus umbellatus ORGANIC Mushroom Powder Capsules 120 pcs.",
                                 [LanguageType.DE] = "Eichhase Pulver BIO - Polyporus umbellatus BIO Pilzpulverkapseln 120 Stk."
                             }.ToJsonDocument(),
                             Description = new Dictionary<string, string>
                             {
                                 [LanguageType.EN] = "Organic Zhu Ling - mushroom powder capsules",
                                 [LanguageType.DE] = "Syn.: Polyporus umbellatus, Eichhase, Ästiger Büschel-Porling, Zhu Ling, Chorei-maitake, Tsuchi-maitake, Umbrella polypore, Chinese sclerotium",
                             }.ToJsonDocument(),
                             ShortDescription = new Dictionary<string, string>
                             {
                                 [LanguageType.EN] = "Polyporus dietary supplement, certified organic. Syn.: Polyporus umbellatus, Umbrella polypore, Zhu Ling, Chorei-maitake, Tsuchi-maitake, Chinese sclerotium",
                                 [LanguageType.DE] = "Polyporus Nahrungsergänzungsmittel in Bio Qualität. Syn.: Polyporus umbellatus, Eichhase, Ästiger Büschel-Porling, Zhu Ling, Chorei-maitake, Tsuchi-maitake, Umbrella polypore, Chinese sclerotium"
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
                             QuantityId = (int)QuantityTypes.Piece,
                             Characteristics = new Dictionary<string, string>
                             {
                                 [LanguageType.EN] = "Synonyms: Umbrella polypore, Zhu Ling, Chorei-maitake, Tsuchi-maitake, Chinese Sclerotium",
                                 [LanguageType.DE] = "Synonyme: Eichhase, Ästiger Büschel-Porling, Zhu Ling, Chorei-maitake, Tsuchi-maitake, Umbrella Polypore, Chinese Sclerotium"
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
                         },
                   new Product
                         {
                             Id = 304,
                             ItemNumber = "ANK-303",
                             ProductWeight = 0.200,
                             ShippingWeight = 0.250,
                             OptionId = 1,
                             Price = 70M,
                             DiscountPercent = 20,
                             PreviewId = 8,
                             Media = medias,
                             Name = new Dictionary<string, string>
                             {
                                 [LanguageType.EN] = "Lion's Mane Liquid Extract ORGANIC - Hericium erinaceus ORGANIC Mushroom Liquid Extract, 100ml",
                                 [LanguageType.DE] = "Igelstachelbart Flüssigextrakt BIO - Hericium erinaceus BIO Flüssigextrakt, 100ml"
                             }.ToJsonDocument(),
                             Description = new Dictionary<string, string>
                             {
                                 [LanguageType.EN] = "Syn.: Yamabusitake (jap.: mountain hidden mushroom), Pom-Pom blanc, hóu tóu gu (chin.: monkey's head), nam dau khi, Norugongdengi-beoseot (vietnam.: deertail mushroom)",
                                 [LanguageType.DE] = "Syn.: Affenkopfpilz, Löwenmähne, Yamabusitake (versteckter Bergpilz), Pom-Pom blanc, hóu tóu gu (chin.: Affenkopf), nam dau khi, Norugongdengi-beoseot (vietnamesisch: Rehschwanz-Pilz)",
                             }.ToJsonDocument(),
                             ShortDescription = new Dictionary<string, string>
                             {
                                 [LanguageType.EN] = "Hericium Liquid Extract, certified organic. Syn.: Yamabusitake (jap.: mountain hidden mushroom), Pom-Pom blanc, hóu tóu gu (chin.: monkey's head)",
                                 [LanguageType.DE] = "Hericium Flüssigextrakt in Bio Qualität. Syn.: Affenkopfpilz, Löwenmähne, Yamabusitake (versteckter Bergpilz), Pom-Pom blanc, hóu tóu gu (chin.: Affenkopf)"
                             }.ToJsonDocument(),
                             QuantityId = (int)QuantityTypes.Piece,
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
                                 [LanguageType.EN] = "Synonyms: Umbrella polypore, Zhu Ling, Chorei-maitake, Tsuchi-maitake, Chinese Sclerotium",
                                 [LanguageType.DE] = "Synonyme: Eichhase, Ästiger Büschel-Porling, Zhu Ling, Chorei-maitake, Tsuchi-maitake, Umbrella Polypore, Chinese Sclerotium"
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
                   }
            };

            List<Product> books = new()
            {
                new Product
                {
                    Id = 201,
                    ItemNumber = "ANK-309",
                    ProductWeight = 0.200,
                    ShippingWeight = 0.250,
                    OptionId = 1,
                    Price = 79.9M,
                    PreviewId = 9,
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
                    QuantityId = (int)QuantityTypes.Piece,
                    ShortDescription = new Dictionary<string, string>
                    {
                        [LanguageType.EN] = "Pleurotus dietary supplement, certified organic. Syn.: Hiratake, Tamogitake, Píng Gu, Sadafi, Chippikkoon",
                        [LanguageType.DE] = "Pleurotus dietary supplement, certified organic. Syn.: Hiratake, Tamogitake, Píng Gu, Sadafi, Chippikkoon."
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
                        [LanguageType.EN] = "ABOUT THE MUSHROOM.",
                        [LanguageType.DE] = "ÜBER DEN PILZ"
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
                },
                new Product
                {
                    Id = 202,
                    ItemNumber = "ANK-383",
                    ProductWeight = 0.200,
                    ShippingWeight = 0.250,
                    OptionId = 1,
                    Price = 79.9M,
                    PreviewId = 10,
                    Media = medias,
                    Name = new Dictionary<string, string>
                    {
                        [LanguageType.EN] = "Fantastische Pilze, Paul Stamets, ISBN: 978-3-03788-593-2",
                        [LanguageType.DE] = "Fantastische Pilze, Paul Stamets, ISBN: 978-3-03788-593-2"
                    }.ToJsonDocument(),
                    Description = new Dictionary<string, string>
                    {
                        [LanguageType.EN] = "! ONLY IN GERMAN LANGUAGE! Fantastische Pilze - Wie Pilze unser Bewusstsein erweitern und den Planeten retten können",
                        [LanguageType.DE] = "Fantastische Pilze - Wie Pilze unser Bewusstsein erweitern und den Planeten retten können",
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
                        [LanguageType.EN] = "200 g",
                        [LanguageType.DE] = "200 g"
                    }.ToJsonDocument(),
                    Characteristics = new Dictionary<string, string>
                    {
                        [LanguageType.EN] = "ABOUT THE MUSHROOM.",
                        [LanguageType.DE] = "ÜBER DEN PILZ"
                    }.ToJsonDocument(),
                    QuantityId = (int)QuantityTypes.Piece,
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

                }
            };
            dbContext.Products.AddOrUpdateRange(medicinal);

            dbContext.Products.AddOrUpdateRange(books);
            dbContext.SaveChanges();


            List<Category> categories = new()
            {
                new Category
                {
                    Id = 3,
                    Index = 1,
                    Image = "http://5.189.140.208:5000/images/Mushroom-supplements.jpg",
                    GridTheme = new GridTheme
                    {
                        Color = "#435561",
                        Image = "http://5.189.140.208:3000/img/medicinal.png",
                    },
                    CatalogColors = new CategoryTheme
                    {
                        TopBar = "#435561",
                        Categories = "#BB4238"
                    },
                    Products = books.Union(medicinal).ToList(),
                    Name = new Dictionary<string, string>
                    {
                        [LanguageType.EN] = "Medicinal mushrooms",
                        [LanguageType.DE] = "Vitalpilze"
                    }.ToJsonDocument(),
                    Description = new Dictionary<string, string>
                    {
                        [LanguageType.EN] = "Vital mushrooms are known since ancient times. While in Europe the knowledge about the power of this mushrooms has fallen into oblivion through the centuries, in Asia they are used up to the present. As Traditional Chinese Medicine has boomed during the last decades in Europe, also the usage of mushrooms shifted more into public awareness.",
                        [LanguageType.DE] = "Vitalpilze werden schon seit der Antike genutzt. Während in Europa das Wissen um die Kraft dieser Pilze etwas in Vergessenheit geraten ist, werden diese Pilze in Asien bis heute erfolgreich genutzt.",
                    }.ToJsonDocument(),
                    GridDescription = new Dictionary<string, string>
                    {
                        [LanguageType.EN] = "Mushroom supplements Books",
                        [LanguageType.DE] = "Mushroom supplements Books"
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
                    Id = 1,
                    ParentId = 3,
                    Image = "http://5.189.140.208:5000/images/Mushroom-supplements.jpg",
                    CatalogColors = new CategoryTheme
                    {
                        TopBar = "#435561",
                        Categories = "#BB4238"
                    },
                    Products = medicinal,
                    Name = new Dictionary<string, string>
                    {
                        [LanguageType.EN] = "Mushroom supplemens",
                        [LanguageType.DE] = "Vitalpilz Pulver und Extrakt in Bio Qualität"
                    }.ToJsonDocument(),
                    Description = new Dictionary<string, string>
                    {
                        [LanguageType.EN] = "Vital mushroom powder and extract supplements, certified organic.",
                        [LanguageType.DE] = "Wegen ihrer vielfältigen wertvollen Nährstoffe (z.B. Polysaccharide, Triterpene, Vitamine, Mineralstoffe u.v.m.) nehmen immer mehr Menschen Vitalpilze als Pilzpuvler oder Pilzextrakt zu sich. Das Pilzpulver enthält alle Pilz-Inhaltsstoffe in der natürlichen Konzentration und Zusammensetzung. Wenn Sie Pilzpulver verwenden, erhalten sie das gesamte Wirkungsspektrum der Pilze. Beim Pilzextrakt handelt es sich um ein Heißwasserextrakt. Der Extrakt enthält hauptsächlich die Polysaccharide, diese aber in hochkonzentrierter Form, einige ander Pilzinhaltsstoffe fehlen im Extrakt.",
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
                    Id = 2,
                    ParentId = 3,
                    Image = "http://5.189.140.208:5000/images/Mushroom-supplements.jpg",
                    CatalogColors = new CategoryTheme
                    {
                        TopBar = "#435561",
                        Categories = "#BB4238"
                    },
                    Products = books,
                    Name = new Dictionary<string, string>
                    {
                        [LanguageType.EN] = "Books",
                        [LanguageType.DE] = "Vitalpilz Literatur"
                    }.ToJsonDocument(),
                    Description = new Dictionary<string, string>
                    {
                        [LanguageType.EN] = "Literature about vital mushrooms. Some of the most important books in this field.",
                        [LanguageType.DE] = "In Asien finden Pilze seit Jahrhunderten in der Traditionellen Chinesischen Medizin (TCM) Verwendung. Auch in Europa wurden sie zum Teil in alten Kräuterbüchern erwähnt. Seit Mitte des 20.",
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
