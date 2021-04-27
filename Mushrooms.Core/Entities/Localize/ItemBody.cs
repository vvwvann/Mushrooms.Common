using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Mushrooms.Core
{
    public class ItemBody
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; }

        public InfoItem InfoItem { get; set; }

        public Seo Seo { get; set; }

        public JsonDocument Title { get; set; }

        public JsonDocument Body { get; set; }

        public InfoItemBodyType Type { get; set; }
    }


    public class FAQ
    {
        public string Question { get; set; }

        public string Answer { get; set; }
    }

    public enum InfoItemBodyType
    {
        None,
        FAQ
    }
}
