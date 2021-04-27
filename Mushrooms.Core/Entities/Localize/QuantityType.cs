using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace Mushrooms.Core
{

    public class QuantityType
    {
        [Key]
        public int Id { get; set; }

        public JsonDocument Name { get; set; }
    }
}
