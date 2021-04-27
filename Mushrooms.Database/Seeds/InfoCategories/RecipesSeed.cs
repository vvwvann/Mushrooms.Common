using Mushrooms.Core;
using Mushrooms.Core.Interfaces;
using Mushrooms.Database.Data.Extensions;
using System.Collections.Generic;
using Mushrooms.Core.Extensions;

namespace Mushrooms.Database.Seeds.InfoCategories
{
    public static class RecipesSeed
    {
        public static void Seed(IApplicationDbContext dbContext)
        {
            List<Media> medias = new List<Media> {
                new Media
                {
                    Id = 40,
                    PreviewPath = "http://5.189.140.208:5000/images/bio-shiitake-frischpilze-lentinula-edodes.jpg" ,
                    Path = "http://5.189.140.208:5000/images/bio-shiitake-frischpilze-lentinula-edodes.jpg"
                },
                new Media
                {
                    Id = 41,
                    PreviewPath = "http://5.189.140.208:5000/images/natuerlich-koch-ich-pilze-yvonne-schwarzinger-isbn-978-3-7066-2581-4.jpg",
                    Path = "http://5.189.140.208:5000/images/natuerlich-koch-ich-pilze-yvonne-schwarzinger-isbn-978-3-7066-2581-4.jpg"
                }
            };


            dbContext.Medias.AddOrUpdateRange(medias);
            dbContext.SaveChanges();

            List<InfoItem> items = new List<InfoItem>
            {
                new InfoItem
                {
                    Id = 41,
                    PreviewId = 40,
                    Title = new Dictionary<string, string>
                            {
                                [LanguageType.EN] = "Tree Oyster - Pleurotus ostreatus",
                                [LanguageType.DE] = "Baumauster - Pleurotus ostreatus"
                            }.ToJsonDocument(),
                    Description = new Dictionary<string, string>
                            {
                                [LanguageType.EN] = "Hiratake, Tamogitake, Píng Gu, Sadafi, Chippikkoon",
                                [LanguageType.DE] = "Hiratake, Tamogitake, Píng Gu, Sadafi, Chippikkoon"
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
                    Bodies = new List<ItemBody>
                    {
                        new ItemBody
                        {
                            Title = new Dictionary<string, string>
                            {
                                [LanguageType.EN] = "Tree Oyster",
                                [LanguageType.DE] = "Baumauster"
                            }.ToJsonDocument(),
                            Body = new Dictionary<string, string>
                            {
                                [LanguageType.EN] = "Scientific name: Pleurotus ostreatus The tree oyster is very simple in cultivation. The mycelium of this pleurotus species is very robust and therefore very popular in commercial cultivation. Fruiting bodies become 5 to 15 cm in diameter. The cap is grayish brown to violet. Pleurotus is rich in B-vitamins such as thiamine, riboflavin, and niacin, vitamin C, vitamin D (calciferol) and folic acid. One fourth of the dry matter of pleurotus is proteins, containing all essential amino acids. The most important compounds of pleurotus are lovastatin and the polysaccharide pleuran.",
                                [LanguageType.DE] = "Wissenschaftlicher Name: Pleurotus ostreatus Die Baumauster ist sehr einfach zu kultivieren. Das Myzel dieser Pleurotus-Art ist sehr robust und daher im kommerziellen Anbau sehr beliebt. Fruchtkörper haben einen Durchmesser von 5 bis 15 cm. Die Kappe ist graubraun bis violett. Pleurotus ist reich an B-Vitaminen wie Thiamin, Riboflavin und Niacin, Vitamin C, Vitamin D (Calciferol) und Folsäure. Ein Viertel der Trockenmasse von Pleurotus sind Proteine, die alle essentiellen Aminosäuren enthalten. Die wichtigsten Verbindungen des Pleurotus sind Lovastatin und das Polysaccharid Pleuran."
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
                    }
                },
                 new InfoItem
                {
                    Id = 42,
                    PreviewId = 41,
                    Title = new Dictionary<string, string>
                            {
                                [LanguageType.EN] = "Caterpillar fungus - Cordyceps sinensis",
                                [LanguageType.DE] = "Caterpillar fungus - Cordyceps sinensis"
                            }.ToJsonDocument(),
                    Description = new Dictionary<string, string>
                            {
                                [LanguageType.EN] = "Ophiocordyceps sinensis, Chinese caterpillar mushroom, Tibetian caterpillar fungus, yartsa gunbu, yatsa gunbu, yarshagumba",
                                [LanguageType.DE] = "Ophiocordyceps sinensis, Chinese caterpillar mushroom, Tibetian caterpillar fungus, yartsa gunbu, yatsa gunbu, yarshagumba"
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
                    Bodies = new List<ItemBody>
                    {
                        new ItemBody
                        {
                            Title = new Dictionary<string, string>
                            {
                                [LanguageType.EN] = "Caterpillar fungus",
                                [LanguageType.DE] = "Caterpillar fungus"
                            }.ToJsonDocument(),
                            Body = new Dictionary<string, string>
                            {
                                [LanguageType.EN] = "Caterpillar fungus - Cordyceps sinensis The tree oyster is very simple in cultivation. The mycelium of this pleurotus species is very robust and therefore very popular in commercial cultivation. Fruiting bodies become 5 to 15 cm in diameter. The cap is grayish brown to violet. Pleurotus is rich in B-vitamins such as thiamine, riboflavin, and niacin, vitamin C, vitamin D (calciferol) and folic acid. One fourth of the dry matter of pleurotus is proteins, containing all essential amino acids. The most important compounds of pleurotus are lovastatin and the polysaccharide pleuran.",
                                [LanguageType.DE] = "Caterpillar fungus - Cordyceps sinensis Das Myzel dieser Pleurotus-Art ist sehr robust und daher im kommerziellen Anbau sehr beliebt. Fruchtkörper haben einen Durchmesser von 5 bis 15 cm. Die Kappe ist graubraun bis violett. Pleurotus ist reich an B-Vitaminen wie Thiamin, Riboflavin und Niacin, Vitamin C, Vitamin D (Calciferol) und Folsäure. Ein Viertel der Trockenmasse von Pleurotus sind Proteine, die alle essentiellen Aminosäuren enthalten. Die wichtigsten Verbindungen des Pleurotus sind Lovastatin und das Polysaccharid Pleuran."
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
                    }
                }
            };

            dbContext.InfoItems.AddOrUpdateRange(items);

            List<InfoCategory> categories = new List<InfoCategory> {
                    new InfoCategory
                    {
                        Id = 4,
                        Index = 4,
                        GridTheme = new GridTheme
                        {
                           Color = "#59B3E4",
                           Image = "http://5.189.140.208:3000/img/delights.png"
                        },
                        CatalogColors = new CategoryTheme
                        {
                         TopBar = "#164259",
                         Categories = "#59B3E4"
                        },
                        InfoItems = items,
                        Name = new Dictionary<string, string>
                        {
                            [LanguageType.EN] = "Recipes",
                            [LanguageType.DE] = "Rezepte"
                        }.ToJsonDocument(),
                        GridDescription = new Dictionary<string, string>
                        {
                            [LanguageType.EN] = "A small collection of yummy recipes.",
                            [LanguageType.DE] = "Eine kleine Sammlung leckerer Rezepte.",
                        }.ToJsonDocument(),
                        Title = new Dictionary<string, string>
                        {
                            [LanguageType.EN] = "Yummy mushroom recipes with:",
                            [LanguageType.DE] = "Leckere Pilzrezepte mit:"
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

            dbContext.InfoCategories.AddOrUpdateRange(categories);
            dbContext.SaveChanges();

        }
    }
}
