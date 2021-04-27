using Mushrooms.Core;
using Mushrooms.Core.Interfaces;
using Mushrooms.Database.Data.Extensions;
using System.Collections.Generic;
using Mushrooms.Core.Extensions;

namespace Mushrooms.Database.Seeds.InfoCategories
{
    public static class MycorrhizaSeed
    {
        public static void Seed(IApplicationDbContext dbContext)
        {
            List<InfoItem> items = new List<InfoItem>
            {
                new InfoItem
                {
                    Id = 31,
                    Title = new Dictionary<string, string>
                            {
                                [LanguageType.EN] = "FAQ",
                                [LanguageType.DE] = "FAQ"
                            }.ToJsonDocument(),
                    Description = new Dictionary<string, string>
                            {
                                [LanguageType.EN] = "Frequently asked questions regarding soil, fertilizers and fungi.",
                                [LanguageType.DE] = "Häufig gestellte Fragen zu Boden, Düngemitteln und Pilzen."
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
                new InfoItem
                {
                    Id = 32,
                    Title = new Dictionary<string, string>
                            {
                                [LanguageType.EN] = "Mycorrhiza Application",
                                [LanguageType.DE] = "Mykorrhiza-Anwendung"
                            }.ToJsonDocument(),
                    Description = new Dictionary<string, string>
                            {
                                [LanguageType.EN] = "Increased growth, higher fruit quality, more resistant against pests and plant diseases.",
                                [LanguageType.DE] = "Erhöhtes Wachstum, höhere Fruchtqualität, resistenter gegen Schädlinge und Pflanzenkrankheiten."
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

            dbContext.InfoItems.AddOrUpdateRange(items);

            List<InfoCategory> categories = new List<InfoCategory> {
                    new InfoCategory
                    {
                        Id = 3,
                        Index = 3,
                        GridTheme = new GridTheme
                        {
                           Color = "#FF7555",
                           Image = "http://5.189.140.208:3000/img/fertilizer.png"
                        },
                        CatalogColors = new CategoryTheme
                        {
                         TopBar = "#0D143F",
                         Categories = "#FF7555"
                        },
                        InfoItems = items,
                        Name = new Dictionary<string, string>
                        {
                            [LanguageType.EN] = "Mycorrhiza",
                            [LanguageType.DE] = "Mycorrhiza"
                        }.ToJsonDocument(),
                        GridDescription = new Dictionary<string, string>
                        {
                            [LanguageType.EN] = "The Mycorrhiza section. Everything about the important symbiotic soil fungi.",
                            [LanguageType.DE] = "Die Mykorrhiza-Sektion. Alles über die wichtigen symbiotischen Bodenpilze.",
                        }.ToJsonDocument(),
                        Title = new Dictionary<string, string>
                        {
                            [LanguageType.EN] = "Mycorrhiza",
                            [LanguageType.DE] = "Mycorrhiza"
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
