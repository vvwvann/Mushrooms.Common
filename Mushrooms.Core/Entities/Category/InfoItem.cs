using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Mushrooms.Core
{
    public class InfoItem
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; }

        public Media Preview { get; set; }

        public int? PreviewId { get; set; }

        public InfoCategory InfoCategory { get; set; }

        public Seo Seo { get; set; }

        public JsonDocument Title { get; set; }

        public JsonDocument Description { get; set; }

        public ICollection<InfoLink> Links { get; set; }              
        
        public ICollection<ItemBody> Bodies { get; set; }
    }
}
