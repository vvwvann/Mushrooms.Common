using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mushrooms.Core;
using System.Collections.Generic;

namespace Mushrooms.Database.Data.Configurations
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder
             .HasData(new List<Language>
             {
                    new Language
                    {
                        Id = 1,
                        Name = "English",
                        Code = "en"
                    },
                    new Language
                    {
                        Id = 2,
                        Name = "Deutsch",
                        Code = "de"
                    }
         });
        }
    }
}
