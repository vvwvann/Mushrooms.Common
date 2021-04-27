using System.Collections.Generic;
using System.Text.Json;

namespace Mushrooms.Core
{
    public class InfoLink
    {
        public int Id { get; set; }

        public JsonDocument Name { get; set; }

        public JsonDocument Body { get; set; }

        public Seo Seo { get; set; }
    }
}
