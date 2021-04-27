using Mushrooms.Core;
using Mushrooms.Core.Interfaces;
using Mushrooms.Database.Data.Extensions;
using System.Collections.Generic;
using Mushrooms.Core.Extensions;
using System.Text.Json;

namespace Mushrooms.Database.Seeds
{
    public static class ContactsSeed
    {
        public static void Seed(IApplicationDbContext dbContext)
        {
            var contact = new Contact
            {
                Id = 1,
                Email = "info@gluckspilze.com",
                Phone = new List<string> { "+43 (0)512 25 10 66", "+43 (0)512 23 89 71" },
                Address = new Dictionary<string, string>
                {
                    [LanguageType.EN] = "Karmelitergasse 21, 6020 Innsbruck",
                    [LanguageType.DE] = "Karmelitergasse 21, 6020 Innsbruck"
                }.ToJsonDocument(),
                Schedule = new Dictionary<string, string>
                {
                    [LanguageType.EN] = "Mo-Do, 8:00 — 18:00",
                    [LanguageType.DE] = "Mo-Do, 8:00 — 18:00"
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
            };

            dbContext.Contacts.AddOrUpdate(contact);
            dbContext.SaveChanges();
        }
    }
}


