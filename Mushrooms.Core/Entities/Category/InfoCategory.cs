using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Mushrooms.Core
{
    public class InfoCategory
    {
        public int Id { get; set; }

        public int Index { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; }

        public JsonDocument Name { get; set; }

        public JsonDocument GridDescription { get; set; }

        public JsonDocument Title { get; set; }

        public Seo Seo { get; set; }

        public CategoryTheme CatalogColors { get; set; }

        public GridTheme GridTheme { get; set; }

        public ICollection<InfoItem> InfoItems { get; set; }
    }
}
