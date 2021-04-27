using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Mushrooms.Database.Identity
{
    public class ApplicationUser : IdentityUser<int>
    {
        public ICollection<Session> Sessions { get; set; }
    }
}
