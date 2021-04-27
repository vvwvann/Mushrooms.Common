using System;

namespace Mushrooms.Core
{
    public class Manager
    {
        public int Id { get; set; }

        public string UserName { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string Phone { get; set; }
        public string Language { get; set; }
        public string LastName { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime DeletedAt { get; set; }

        public bool IsDeleted { get; set; }
    }
}
