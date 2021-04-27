using System.Collections.Generic;
using System.Text.Json;

namespace Mushrooms.Core
{
    public class Contact
    {
        public int Id { get; set; }

        public List<string> Phone { get; set; }

        public string Email { get; set; }

        public JsonDocument Address { get; set; }

        public JsonDocument Schedule { get; set; }

        public Seo Seo { get; set; }
    }
}
