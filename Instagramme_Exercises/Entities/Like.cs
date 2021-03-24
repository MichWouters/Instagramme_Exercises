using System;

namespace Instagramme_Exercises.Entities
{
    public class Like
    {
        public int UserId { get; set; }
        public int PostId { get; set; }
        public DateTime CreatedAt { get; set; }

        public Post Post { get; set; }
        public User User { get; set; }
    }
}
