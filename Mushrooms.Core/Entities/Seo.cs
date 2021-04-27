using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Mushrooms.Core
{
    public class Seo
    {
        public JsonDocument Title { get; set; }

        public JsonDocument Desc { get; set; }

        public JsonDocument Keys { get; set; }

    }

}

