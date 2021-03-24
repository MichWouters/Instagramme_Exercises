using System;
using System.Collections.Generic;

namespace Instagramme_Exercises.Entities
{
    public class Post
    {
        public Post()
        {
            Comments = new List<Comment>();
            Likes = new List<Like>();
            PostTags = new List<PostTag>();
        }

        public int PostId { get; set; }
        public int UserId { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }

        public User User { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Like> Likes { get; set; }
        public List<PostTag> PostTags { get; set; }
    }
}
