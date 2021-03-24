using System;

namespace Instagramme_Exercises.Entities
{
    public class Follower
    {
        public int FollowerId { get; set; }
        public int FolloweeId { get; set; }
        public DateTime CreatedAt { get; set; }

        public User Followee { get; set; }
        public User FollowerNavigation { get; set; }
    }
}
