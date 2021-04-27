using System;

namespace Mushrooms.Database.Identity
{
    public class Session
    {
        public int Id { get; set; }

        public Guid RefreshToken { get; set; } = Guid.NewGuid();

        public DateTime ExpiresIn { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}
