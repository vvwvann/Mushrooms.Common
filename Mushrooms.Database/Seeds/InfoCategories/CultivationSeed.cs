using Mushrooms.Core;
using Mushrooms.Core.Interfaces;
using Mushrooms.Database.Data.Extensions;
using System.Collections.Generic;
using Mushrooms.Core.Extensions;

namespace Mushrooms.Database.Seeds.InfoCategories
{
    public static class CultivationSeed
    {
        public static void Seed(IApplicationDbContext dbContext)
        {
            List<InfoItem> items = new List<InfoItem>
            {
                new InfoItem
                {
                    Id = 21,
                    Title = new Dictionary<string, string>
                            {
                                [LanguageType.EN] = "Introduction",
                                [LanguageType.DE] = "Einführung"
                            }.ToJsonDocument(),
                    Description = new Dictionary<string, string>
                            {
                                [LanguageType.EN] = "A brief introduction to the world of mushrooms",
                                [LanguageType.DE] = "Eine kurze Einführung in die Welt der Pilze"
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
                    Links = new List<InfoLink>
                    {
                        new InfoLink {
                        Id = 1,
                        Name = new Dictionary<string, string>
                            {
                                [LanguageType.EN] = "The life cycle of a mushroom",
                                [LanguageType.DE] = "Der Lebenszyklus eines Pilzes"
                            }.ToJsonDocument(),
                        Body = new Dictionary<string, string>
                            {
                                [LanguageType.EN] = "What is a mushroom? Due to the lack of scientific knowledge fungi were classified as plants for a long time.Today's understanding of genetic and physiological facts show that fungi are more closely related to animals than plants. Unlike plants they neither are able to carry out photosynthesis nor can they produce the carbohydrates they need.",
                                [LanguageType.DE] = "Was ist ein Pilz? Aufgrund des Mangels an wissenschaftlichen Erkenntnissen wurden Pilze lange Zeit als Pflanzen eingestuft. Das heutige Verständnis genetischer und physiologischer Fakten zeigt, dass Pilze enger mit Tieren verwandt sind als Pflanzen. Im Gegensatz zu Pflanzen können sie weder Photosynthese durchführen noch die benötigten Kohlenhydrate produzieren."
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
                        new InfoLink {
                        Id = 2,
                        Name = new Dictionary<string, string>
                            {
                                [LanguageType.EN] = "Introduction to cultivating mushrooms",
                                [LanguageType.DE] = "Einführung in die Pilzzucht"
                            }.ToJsonDocument(),
                        Body = new Dictionary<string, string>
                            {
                                [LanguageType.EN] = "What is a mushroom? Due to the lack of scientific knowledge fungi were classified as plants for a long time.Today's understanding of genetic and physiological facts show that fungi are more closely related to animals than plants. Unlike plants they neither are able to carry out photosynthesis nor can they produce the carbohydrates they need.",
                                [LanguageType.DE] = "Was ist ein Pilz? Aufgrund des Mangels an wissenschaftlichen Erkenntnissen wurden Pilze lange Zeit als Pflanzen eingestuft. Das heutige Verständnis genetischer und physiologischer Fakten zeigt, dass Pilze enger mit Tieren verwandt sind als Pflanzen. Im Gegensatz zu Pflanzen können sie weder Photosynthese durchführen noch die benötigten Kohlenhydrate produzieren."
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
                    Id = 22,
                    Title = new Dictionary<string, string>
                            {
                                [LanguageType.EN] = "Laboratory work",
                                [LanguageType.DE] = "Labor arbeit"
                            }.ToJsonDocument(),
                    Description = new Dictionary<string, string>
                            {
                                [LanguageType.EN] = "From spores to 'ready to fruit' mycelium, step by step.",
                                [LanguageType.DE] = "Schritt für Schritt von den Sporen bis zum fruchtfertigen Myzel."
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
                     Links = new List<InfoLink>
                    {
                        new InfoLink {
                        Id = 3,
                        Name = new Dictionary<string, string>
                            {
                                [LanguageType.EN] = "Production of spore prints",
                                [LanguageType.DE] = "Herstellung von Sporendrucken"
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
                        new InfoLink {
                        Id = 4,
                        Name = new Dictionary<string, string>
                            {
                                [LanguageType.EN] = "Microscopic examination of spores",
                                [LanguageType.DE] = "Mikroskopische Untersuchung von Sporen"
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
                        Id = 2,
                        Index = 2,
                        GridTheme = new GridTheme
                        {
                           Color = "#4BC7CF",
                           Image = "http://5.189.140.208:3000/img/cultivation.png"
                        },
                        CatalogColors = new CategoryTheme
                        {
                         TopBar = "#188287",
                         Categories = "#4BC7CF"
                        },
                        InfoItems = items,
                        Name = new Dictionary<string, string>
                        {
                            [LanguageType.EN] = "Cultivation techniques",
                            [LanguageType.DE] = "Kultivierungstechniken"
                        }.ToJsonDocument(),
                        GridDescription = new Dictionary<string, string>
                        {
                            [LanguageType.EN] = "Introduction to cultivation and laboratory working steps, as well as fruiting techniques.",
                            [LanguageType.DE] = "Einführung in die Kultivierungs- und Laborarbeitsschritte sowie in die Fruchttechniken.",
                        }.ToJsonDocument(),
                        Title = new Dictionary<string, string>
                        {
                            [LanguageType.EN] = "Cultivation techniques",
                            [LanguageType.DE] = "Kultivierungstechniken"
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
