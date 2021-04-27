using Mushrooms.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mushrooms.Core
{
    public class SeoPage
    {
        [Key]
        public int Id { get; set; }

        public PageSeoType Page { get; set; }

        public Seo Seo { get; set; }
    }

}

