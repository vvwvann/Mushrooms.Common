using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Mushrooms.Core
{
    public class Category
    {
        public int Id { get; set; }

        public int? ParentId { get; set; }

        public int Index { get; set; }

        public Category Parent { get; set; }

        public CategoryTheme CatalogColors { get; set; }

        public GridTheme GridTheme { get; set; }

        public string Image { get; set; }

        public JsonDocument Name { get; set; }

        public JsonDocument Description { get; set; }

        public JsonDocument GridDescription { get; set; }

        public Seo Seo { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public ICollection<Product> Products { get; set; }

        public ICollection<Category> SubCategories { get; set; }
    }
}

